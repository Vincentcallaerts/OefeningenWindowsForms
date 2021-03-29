using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedOefening
{
    public partial class Form1 : Form
    {
        private List<Bedrijf> werkgevers = new List<Bedrijf>();
        public Form1()
        {
            InitializeComponent();
            Bedrijf bedrijf1 = new Bedrijf("Tesla");
            Bedrijf bedrijf2 = new Bedrijf("Ook Tesla");
            Bedrijf bedrijf3 = new Bedrijf("TeslaCoin");

            werkgevers.Add(bedrijf1);
            werkgevers.Add(bedrijf2);
            werkgevers.Add(bedrijf3);

            bedrijf1.AddWerknemer(new Werknemer(new Salaris(false, 2440.55), "Geert", "België"));
            bedrijf1.AddWerknemer(new Werknemer(new Salaris(false, 2440.55), "Daniel", "Nederland"));
            bedrijf1.AddWerknemer(new Werknemer(new Salaris(true, 2200.00), "Frank", "België"));
            bedrijf2.AddWerknemer(new Werknemer(new Salaris(true, 3110.00), "Sofia", "Nederland"));
            bedrijf3.AddWerknemer(new Werknemer(new Salaris(true, 3110.00), "Sofia", "Nederland"));
            bedrijf3.AddWerknemer(new Werknemer(new Salaris(true, 3110.00), "Sofia", "Nederland"));
            bedrijf3.AddWerknemer(new Werknemer(new Salaris(true, 3110.00), "Sofia", "Nederland"));

            cbBox.DataSource = werkgevers;
            cbBox.DisplayMember = nameof(Bedrijf.Naam);
            cbBoxWerknemers.DataSource = werkgevers[0].Werknemers;
            cbBoxWerknemers.DisplayMember = nameof(Werknemer.Naam);

        }

        private void cbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                cbBoxWerknemers.DataSource = null;
                cbBoxWerknemers.DataSource = werkgevers[cbBox.SelectedIndex].Werknemers;
                cbBoxWerknemers.DisplayMember = nameof(Werknemer.Naam);
            
        }

        private void cbBoxWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxWerknemers.DataSource != null)
            {
                Werknemer temp = cbBoxWerknemers.SelectedItem as Werknemer;

                txtBoxOutput.Text = temp.ToString();
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {

            using (Form2 form2 = new Form2())
            {
                
                switch (form2.ShowDialog())
                {
                    case DialogResult.OK:

                    werkgevers[cbBox.SelectedIndex].Werknemers.Add(new Werknemer(new Salaris(form2.MaandContract, form2.BrutoLoon), form2.Naam, form2.LandVanHerkomst));
                        cbBoxWerknemers.DataSource = null;
                        cbBoxWerknemers.DataSource = werkgevers[cbBox.SelectedIndex].Werknemers;
                        cbBoxWerknemers.DisplayMember = nameof(Werknemer.Naam);
                        break;                       
                }               
            }           
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            werkgevers[cbBox.SelectedIndex].Werknemers.RemoveAt(cbBoxWerknemers.SelectedIndex);
            cbBoxWerknemers.DataSource = null;
            cbBoxWerknemers.DataSource = werkgevers[cbBox.SelectedIndex].Werknemers;
            cbBoxWerknemers.DisplayMember = nameof(Werknemer.Naam);
        }
    }
}
