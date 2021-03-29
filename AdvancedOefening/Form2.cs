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
    public partial class Form2 : Form
    {
        public bool MaandContract { get; set; }
        public double BrutoLoon { get; set; }
        public string Naam { get; set; }
        public string LandVanHerkomst { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnToevoegenF2_Click(object sender, EventArgs e)
        {
            MaandContract = radioButton1.Checked;
            BrutoLoon = Convert.ToDouble(textBox2.Text);
            Naam = textBox3.Text;
            LandVanHerkomst = textBox4.Text;
        }
    }
}
