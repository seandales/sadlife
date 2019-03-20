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
    public partial class Inventorycs : Form
    {
        public Main refToDash { get; set; }
        public MySqlConnection conn;

        public Inventorycs()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd=root;SslMode=none;");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InventoryAddItem invadd = new InventoryAddItem();
            invadd.reftoinventory = this;
            this.Hide();
            if (invadd.ShowDialog() == DialogResult.OK)
            {
                
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventorycs_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select * from items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView1.DataSource = dt;

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();


                dataGridView1.Columns[0].Visible = false;
                foreach (DataGridViewColumn ya in dataGridView1.Columns)
                {
                    ya.SortMode = DataGridViewColumnSortMode.NotSortable;
                    ya.Width = 100;
                }
                foreach (DataGridViewRow ro in dataGridView1.Rows)
                {
                    ro.Height = 60;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah!" + ee);
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Do you want to exit?", "Inventory Management", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                
            }
        }

        private void Inventorycs_FormClosing(object sender, FormClosingEventArgs e)
        {
            //refToDash.Show();
            Main ma = new Main();
            ma.Show();
        }
    }
}
