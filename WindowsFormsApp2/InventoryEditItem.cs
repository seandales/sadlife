using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class InventoryEditItem : Form
    {
        public Inventorycs reftoinventory { get; set; }
        MySqlConnection conn;
        public int itemID { get; set; }
        public InventoryEditItem()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd=root;SslMode=none;");
        }

        private void InventoryEditItem_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + itemID);
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select * from items WHERE itemID ="+ itemID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                
                if(dt.Rows.Count > 0)
                {
                    tbName.Text = dt.Rows[0]["itemName"].ToString();
                    tbDesc.Text = dt.Rows[0]["description"].ToString();
                    tbPrice.Text = dt.Rows[0]["price"].ToString();
                }

                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah!" + ee);
                conn.Close();
            }
        }

        public void initializeform()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE items SET itemName ='" + tbName.Text + "', description ='"+ tbDesc.Text +"', price ='" + tbPrice.Text + "' WHERE itemID = '" + itemID + "';", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }
        }



        #region button header design
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button1.Text = string.Empty;
            e.Graphics.DrawString("EDIT ITEM", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }
        #endregion

        #region form traversal
        private void InventoryEditItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            reftoinventory.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            initializeform();
            this.DialogResult = DialogResult.OK;
        }
    }
}
