using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NogEenOefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MakeMessage());
        }
        private string MakeMessage()
        {
            string temp = string.Empty;
            
            temp += $"{txtBoxNaam.Text}\n";
            temp += $"{txtBoxVoornaam.Text}\n";
            temp += $"{nudLeeftijd.Value}\n";
            // geslacht
            var buttons = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            temp += $"{buttons.Text}\n";
            // provincie
            buttons = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            temp += $"{buttons.Text}\n";
            return temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
