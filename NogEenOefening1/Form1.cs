using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NogEenOefening1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btVoegToe_Click(object sender, EventArgs e)
        {
            lstBoxActief.Items.Add(txtBoxInput.Text);
        }

        private void btnToInactief_Click(object sender, EventArgs e)
        {
            lstBoxInactief.Items.Add(lstBoxActief.Items[lstBoxActief.SelectedIndex]);
            lstBoxActief.Items.RemoveAt(lstBoxActief.SelectedIndex);
        }

        private void btnToActief_Click(object sender, EventArgs e)
        {
            lstBoxActief.Items.Add(lstBoxInactief.Items[lstBoxInactief.SelectedIndex]);
            lstBoxInactief.Items.RemoveAt(lstBoxInactief.SelectedIndex);
        }

    }
}
