using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_4
{
    public partial class Form1 : Form
    {
        private List<User> users;
        private List<string> userNames;
        public Form1()
        {
            users = new List<User>();
            userNames = new List<string>();
            users.Add(new User("Vincent", "Callaerts"));
            users.Add(new User("Kampiel", "Clumpers"));
            users.Add(new User("Quinten", "Leboi"));

            InitializeComponent();
            Prep();
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            if (!(cbNamen.SelectedItem == null))
            {
                User tempuser = users[cbNamen.SelectedIndex];
                MessageBox.Show($"De geselecteerde user heet {tempuser.VolledigeNaam()}");
            }
            else
            {
                MessageBox.Show("Duit iets aan he");
            }                      
        }
        private void Prep()
        {
            
            for (int i = 0; i < users.Count; i++)
            {
                userNames.Add(users[i].Name);
            }
            cbNamen.Items.AddRange(userNames.ToArray());
        }
        

        private void btAanpassen_Click(object sender, EventArgs e)
        {
            if (!(cbNamen.SelectedItem == null) && txtNewName.TextLength != 0 && txtNewLastName.TextLength != 0)
            {
                users[cbNamen.SelectedIndex].Name = txtNewName.Text;
                users[cbNamen.SelectedIndex].LastName = txtNewLastName.Text;
                cbNamen.Items.Clear();
                userNames.Clear();
                cbNamen.Text = "";
                Prep();
            }
        }
    }   
}
