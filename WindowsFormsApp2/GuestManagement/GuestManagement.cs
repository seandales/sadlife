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
    public partial class Guest : Form
    {
        public MySqlConnection conn;
        public Form refToDash { get; set; }

        public Guest()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd=root;");
        }

        
        int selectedRow;

        private void Guest_Load(object sender, EventArgs e)
        {
            
            conn.Open();

            LoadData_Guest();
            LoadData_ProgramSeg();

            conn.Close();

        }

        public void LoadData_Guest()
        {
            String sqlStringG = "Select * from client";
            MySqlCommand my_command = new MySqlCommand(sqlStringG, conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(my_command);

            DataTable dt = new DataTable();
            my_adapter.Fill(dt);

            DGV_Guest.DataSource = dt;
        }

        public void LoadData_ProgramSeg()
        {
            String sqlStringR = "Select * from radio_program";

            MySqlCommand my_command_ = new MySqlCommand(sqlStringR, conn);
            MySqlDataAdapter my_adapter_ = new MySqlDataAdapter(my_command_);

            DataTable dt_ = new DataTable();
            my_adapter_.Fill(dt_);

            DGV_Program.DataSource = dt_;
        }
        
        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            String sqlString = "Select * from client";
            String connString = "server=127.0.0.1;uid=root;pwd=root;database=radio";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand my_command = new MySqlCommand(sqlString, my_conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(my_command);

            DataTable dt = new DataTable();
            my_adapter.Fill(dt);

            dataGridView1.DataSource = dt;

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
        //my_conn.Close();



        //}


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventorycs invcs = new Inventorycs();
            if (invcs.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }


            //Inventorycs iv = new Inventorycs();
            //this.Hide();
            //iv.ShowDialog();
            //this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetRGuestAppointment setapp = new SetRGuestAppointment();
            if (setapp.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                LoadData_Guest();
            }


        }
        */

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = DGV_Guest.Rows[selectedRow];
            tbName.Text = row.Cells[1].Value.ToString() + ", " + row.Cells[2].Value.ToString();
            tbContact.Text = row.Cells[3].Value.ToString();
            tbAddress.Text = row.Cells[4].Value.ToString();
            cbType.Text = row.Cells[5].Value.ToString();
        }

        private void Guest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Do you want to Exit?", "Guest Management", MessageBoxButtons.YesNo);
                {
                    if (result == DialogResult.Yes)
                    {
                        refToDash.Show();
                    }

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            SetRGuestAppointment sa = new SetRGuestAppointment();
            sa.refToGuest = this;
            sa.Show();
            this.Hide();

            //SetRGuestAppointment setapp = new SetRGuestAppointment();
            //setapp.refToGuest = this;
            //setapp.Show();
            //this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            if (m.ShowDialog() == DialogResult.OK)
            {
                refToDash.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Guest EG = new Edit_Guest();
            EG.Show();
        }

        private void btnAdd_Guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetRGuestAppointment setapp = new SetRGuestAppointment();
            if (setapp.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                LoadData_Guest();
            }
        }

        private void btnAdd_Prog_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProgramSegment addseg = new AddProgramSegment();

            if (addseg.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                LoadData_ProgramSeg();
            }
        }
       
    }
}
