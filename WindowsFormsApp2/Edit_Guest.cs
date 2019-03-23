using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Edit_Guest : Form
    {
        Guest EG;
        public Tuple<int, string, string, int, string, string> Gu_Details { get; set; }
        int clientID;

        public Edit_Guest(Guest Main)
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guest gt = new Guest();
            if (gt.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                gt.Show();
            }


        }

        private void Edit_Guest_Load(object sender, EventArgs e)
        {
            clientID = Gu_Details.Item1;
            tbFname.Text = Gu_Details.Item2;
            tbLname.Text = Gu_Details.Item3;
            tbContact.Text = Gu_Details.Item4.ToString();
            tbAddress.Text = Gu_Details.Item5;
            
            
        }

        private void Edit_Guest_Deactivate(object sender, EventArgs e)
        {
            

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(tbFname.Text == "" || tbLname.Text == "" || tbContact.Text == "" || tbAddress.Text == "")
            {
                MessageBox.Show("Please fill in all the required information", "Hold up!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if(tbFname.Text == Gu_Details.Item2 && tbLname.Text == Gu_Details.Item3 && tbContact.Text == Gu_Details.Item4.ToString() && tbAddress.Text == Gu_Details.Item5)
            {
                MessageBox.Show("No information has been updated", "Hey wtf", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want so save changes?", "sure na jud?", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    string query = "UPDATE client set fname = '" + tbFname.Text + "', lname = '" + tbLname.Text + "', contactNum = '" + tbContact.Text + "', address = '" + tbAddress.Text + "' where clientID = '" + clientID + "'";
                }
            }
        }
    }
}
