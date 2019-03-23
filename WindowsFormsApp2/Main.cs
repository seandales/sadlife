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

        private void Main_Load(object sender, EventArgs e)
        {

        }
        #region drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
