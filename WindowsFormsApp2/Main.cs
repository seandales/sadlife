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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Guest gt = new Guest();
            gt.refToDash = this;
            gt.Show();
            this.Hide();
            
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventorycs inv = new Inventorycs();
            inv.refToDash = this;
            inv.Show();
            this.Hide();
            
        }

        private void btnDash_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Do you want to Exit?", "Radio Management", MessageBoxButtons.YesNo);
                {
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
