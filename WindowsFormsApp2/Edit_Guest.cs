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
        

        public Edit_Guest()
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
    }
}
