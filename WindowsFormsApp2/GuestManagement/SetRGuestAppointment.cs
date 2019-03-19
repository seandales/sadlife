using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.NET;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp2
{
   
    public partial class SetRGuestAppointment : Form
    {
        public Guest refToGuest { get; set; }

        int selectedRow;
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root; password=root;database=radio");

        

        public SetRGuestAppointment()
        {
            InitializeComponent();
            
        }

        private void SetRGuestAppointment_Load(object sender, EventArgs e)
        {
            tbReason.Visible = false;
            lbReason.Visible = false;
            tcGuest.SelectedIndex = 0;

            String sqlString = "Select * from client WHERE status='radio guest' ";
            String connString = "server=127.0.0.1;uid=root;pwd=root;database=radio";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand my_command = new MySqlCommand(sqlString, my_conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(my_command);

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            DataTable dt = new DataTable();
            my_adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            connection.Open();
            String insertQuery = "INSERT into client(fname, lname, contactNum, address, status) values('" + tbFname.Text + "','" + tbLname.Text + "','" + tbContact.Text + "','" + tbAddress.Text + "','" + cbGType.Text + "')";
            //INSERT INTO items (itemName, description, price, status, image) VALUES ('Pen', 'Tom B. Erichsen', '21', 'Active', 'img');
            //INSERT INTO items (itemName, description, price, status, image) VALUES ('Pen', 'Tom B. Erichsen', '21', 'Active', 'img');
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Data Inserted");
                    this.Hide();
                    SetRGuestAppointment2 sett = new SetRGuestAppointment2();
                    if (sett.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }

                }

                else
                {
                    MessageBox.Show("Data not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
            this.DialogResult = DialogResult.OK;
        }


        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            tcGuest.SelectedIndex = 2;
            rbnew.Visible = true;
            rbold.Visible = true;

        }

        private void btnOldGuest_Click(object sender, EventArgs e)
        {
            tcGuest.SelectedIndex = 1;
            rbnew.Visible = true;
            rbold.Visible = true;
        }

        private void rbnew_CheckedChanged(object sender, EventArgs e)
        {
            tcGuest.SelectedIndex = 2;
        }

        private void rbold_CheckedChanged(object sender, EventArgs e)
        {
            tcGuest.SelectedIndex = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            tbName_.Text = row.Cells[1].Value.ToString() + ", " + row.Cells[2].Value.ToString();
            tbContactNum_.Text = row.Cells[3].Value.ToString();
            //tbConta_.Text = row.Cells[3].Value.ToString();
            tbAddress_.Text = row.Cells[4].Value.ToString();
            cbStatus_.Text = row.Cells[5].Value.ToString();
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            /*
            DialogResult check = MessageBox.Show("Close this Window?", "Guest Management", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                trefhis.Hide();
                this.Close();
                refToGuest.Show();

            }
            */
        }

        private void SetRGuestAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            //refToGuest.Show();
        }

        private void cbGType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGType.SelectedIndex == 0)
            {
                tbReason.Visible = true;
                lbReason.Visible = true;
            }

            else if(cbGType.SelectedIndex == 1)
            {
                tbReason.Visible = false;
                lbReason.Visible = false;
            }
           
        }
    }
}
