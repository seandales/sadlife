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
    public partial class InventoryAddItem : Form
    {
        public Inventorycs reftoinventory { get; set; }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root; password=root;database=radio");

        public InventoryAddItem()
        {

            InitializeComponent();
           
        }
        

        
        /**
        private void button2_Click(object sender, EventArgs e)
        {

        }
        **/

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();



            connection.Open();
            String insertQuery = "INSERT into items(itemName, description, price, status, image) values('" + tbName.Text + "','" + tbDesc.Text + "','" + tbPrice.Text  + "','Active'" + ",'" + img + "')";
            //INSERT INTO items (itemName, description, price, status, image) VALUES ('Pen', 'Tom B. Erichsen', '21', 'Active', 'img');
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }

                else
                {
                    MessageBox.Show("Data not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " bad si shainna");
            }
            

            connection.Close();
            this.DialogResult = DialogResult.OK;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventorycs inv = new Inventorycs();
            inv.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG;*)|*.jpg;*.png;";


            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void InventoryAddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            reftoinventory.Show();
        }
    }
}
