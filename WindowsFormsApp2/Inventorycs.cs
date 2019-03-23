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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Inventorycs : Form
    {
        public Main refToDash { get; set; }
        public MySqlConnection conn;
        public Boolean once = true;
        public int currID;

        public Inventorycs()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd=root;SslMode=none;");
        }
        private void Inventorycs_Load(object sender, EventArgs e)
        {
            refresh_inventory();
        }

        #region load datagridview
        public void refresh_inventory()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Active'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView1.DataSource = dt;
                
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Columns["itemID"].Visible = false;
                    dataGridView1.Columns["Status"].Visible = false;
                }
                
                conn.Close();
                foreach (DataGridViewColumn ya in dataGridView1.Columns)
                {
                    ya.SortMode = DataGridViewColumnSortMode.NotSortable;
                    ya.Width = 220;
                }
                foreach (DataGridViewRow ro in dataGridView1.Rows)
                {
                    ro.Height = 60;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }
        // cmd = whole thing cmd2 = for image
        public void filter_inventory( string cmd)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(cmd, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Columns["itemID"].Visible = false;
                    dataGridView1.Columns["Status"].Visible = false;
                }
                
                conn.Close();
                foreach (DataGridViewColumn ya in dataGridView1.Columns)
                {
                    ya.SortMode = DataGridViewColumnSortMode.NotSortable;
                    ya.Width = 220;
                }
                foreach (DataGridViewRow ro in dataGridView1.Rows)
                {
                    ro.Height = 60;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }
        public void search_inventory(string search)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Active' AND itemName LIKE '%"+ search + "%' OR description LIKE '%" + search + "%' OR price LIKE '%" + search + "%'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Columns["itemID"].Visible = false;
                    dataGridView1.Columns["Status"].Visible = false;
                }
                
                conn.Close();
                foreach (DataGridViewColumn ya in dataGridView1.Columns)
                {
                    ya.SortMode = DataGridViewColumnSortMode.NotSortable;
                    ya.Width = 220;
                }
                foreach (DataGridViewRow ro in dataGridView1.Rows)
                {
                    ro.Height = 60;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }
        #endregion

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InventoryAddItem invadd = new InventoryAddItem();
            invadd.reftoinventory = this;
            this.Hide();
            if (invadd.ShowDialog() == DialogResult.OK)
            {
                refresh_inventory();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InventoryEditItem invedit = new InventoryEditItem();
            invedit.reftoinventory = this;
            //MessageBox.Show("" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            invedit.itemID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.Hide();
            if (invedit.ShowDialog() == DialogResult.OK)
            {
                refresh_inventory();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Do you want to exit?", "Inventory Management", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                this.Close();
                
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE items SET status='Inactive' WHERE itemID = '" + currID + "';", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }
            refresh_inventory();
            btnRemove.Enabled = false;
        }
        private void filter_Click(object sender, EventArgs e)
        {
            string strquery = "";
            filter fil = new filter();
            fil.reftoinventory = this;
            if (fil.ShowDialog() == DialogResult.OK)
            {
                if (fil.rbActive.Checked && fil.rbAsc.Checked && fil.rbName.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Active' ORDER BY Name ASC";
                else if (fil.rbActive.Checked && fil.rbAsc.Checked && fil.rbPrice.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Active' ORDER BY Price ASC";
                else if (fil.rbActive.Checked && fil.rbDesc.Checked && fil.rbName.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Active' ORDER BY Name DESC";
                else if (fil.rbActive.Checked && fil.rbDesc.Checked && fil.rbPrice.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Active' ORDER BY Price DESC";
                else if (fil.rbInactive.Checked && fil.rbAsc.Checked && fil.rbName.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Inactive' ORDER BY Name ASC";
                else if (fil.rbInactive.Checked && fil.rbAsc.Checked && fil.rbPrice.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Inactive' ORDER BY Price ASC";
                else if (fil.rbInactive.Checked && fil.rbDesc.Checked && fil.rbName.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Inactive' ORDER BY Name DESC";
                else if (fil.rbInactive.Checked && fil.rbDesc.Checked && fil.rbPrice.Checked) strquery = "Select itemID, itemName AS Name, description AS Description, price AS Price, status AS Status from items WHERE Status = 'Inactive' ORDER BY Price DESC";

                filter_inventory(strquery);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search_inventory(searchBar.Text);
        }
        #endregion

        #region drag mouse
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
        private void label13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void Inventorycs_FormClosing(object sender, FormClosingEventArgs e)
        {
            refToDash.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            currID = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            btnRemove.Enabled = true;

        }


    }
}
