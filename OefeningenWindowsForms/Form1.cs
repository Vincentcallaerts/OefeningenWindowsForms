using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningenWindowsForms
{
    public partial class Form1 : Form
    {
        public List<string> strings = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btClick_Click(object sender, EventArgs e)
        {

            strings.Add(txtBoxInput.Text);
            txtBox.Clear();
            txtBox.Lines = strings.ToArray();
            for (int i = 0; i < txtBox.Lines.Length; i++)
            {
                txtBox.Lines[i] = strings[i];
            }

            if (strings.Count == 5)
            {
                btClick.Enabled = false;
            }
            else
            {
                txtBoxInput.Focus();
            }   
            
        }     

        private void txtBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {                
                btClick_Click(this, new EventArgs());
            }
        }
    }
}
