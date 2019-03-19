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
        public Form refToDash { get; set; }
        public MySqlConnection conn;
        //MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;username=root; password=root");

        public Inventorycs()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd=root;");
        }

        /**
        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        **/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryAddItem invadd = new InventoryAddItem();
            if (invadd.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventorycs_Load(object sender, EventArgs e)
        {
            String sqlString = "Select * from items";
            String connString = "server=127.0.0.1;uid=root;pwd=root;database=radio";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand my_command = new MySqlCommand(sqlString, my_conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(my_command);

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            DataTable dt = new DataTable();
            my_adapter.Fill(dt);
            
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            my_adapter.Dispose();
            //---------------------------
            my_conn.Open();

            /**
            String sqlString1 = "Select * from film";
            MySqlCommand my_command1 = new MySqlCommand(sqlString1, my_conn);

            MySqlDataReader my_reader = my_command1.ExecuteReader();

            while (my_reader.Read())
            {
                textBox1.Text = textBox1.Text + my_reader.GetString("title") + ", ";
            }

            my_reader.Close();
            **/
            my_conn.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Do you want to exit?", "Inventory Management", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                refToDash.Show();
                
            }
        }
    }
}
