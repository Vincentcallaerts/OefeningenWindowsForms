using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_3
{
    public partial class Form1 : Form
    {
        List<string> randomNamen;

        public Form1()
        {
            randomNamen = new List<string>();
            randomNamen.Add("Claire");
            randomNamen.Add("Bart");
            randomNamen.Add("Tom");
            randomNamen.Add("Kenny");
            InitializeComponent();
            lstBox.Items.Add(randomNamen[0]);
            lstBox.Items.Add(randomNamen[1]);
            lstBox.Items.Add(randomNamen[2]);
            lstBox.Items.Add(randomNamen[3]);
        }
        
        private void btKnop_Click(object sender, EventArgs e)
        {

            lstBox.Items.Clear();
            for (int i = 0; i < randomNamen.Count; i++)
            {
                if (randomNamen[i].Contains(txtBox.Text.First()))
                {
                    lstBox.Items.Add(randomNamen[i]);
                }
            }
            
        }
    }
}
