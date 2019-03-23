﻿using System;
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
        MySqlConnection conn;
        public Boolean withIMG = false;
        public byte[] img;
        public InventoryAddItem()
        {

            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd=root;SslMode=none;");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (withIMG)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                img = new byte[ms.Length];
                ms.Read(img, 0, img.Length);
                MessageBox.Show("" + img.Length);
                withIMG = false;
            }
            try
            {
                conn.Open();
                //INSERT INTO items (itemName, description, price, status, image) VALUES ('Pen', 'Tom B. Erichsen', '21', 'Active', 'img');
                MySqlCommand command = new MySqlCommand("INSERT into items(itemName, description, price, status, image) values('" + tbName.Text + "','" + tbDesc.Text + "','" + tbPrice.Text + "','Active'" + ",'" + img + "')", conn);

                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Data Inserted");
                else MessageBox.Show("Data not inserted");
            }
            catch (Exception ee)
            {
                MessageBox.Show(""+ee);
                conn.Close();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            withIMG = true;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG;*)|*.jpg;*.png;";


            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.Tag = opf.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region form traversal
        private void InventoryAddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            reftoinventory.Show();
        }

        private void InventoryAddItem_Load(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
        #endregion
        #region button header design
        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

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
            e.Graphics.DrawString("ADD ITEM", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }
        #endregion
    }
}
