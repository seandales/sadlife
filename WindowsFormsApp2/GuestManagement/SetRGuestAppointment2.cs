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
    public partial class SetRGuestAppointment2 : Form
    {
        public MySqlConnection conn;
        public string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public SetRGuestAppointment2()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=radio;Uid=root;Pwd=root;");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetRGuestAppointment setg = new SetRGuestAppointment();
            if (setg.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                setg.Show();
            }
        }

        private void SetRGuestAppointment2_Load(object sender, EventArgs e)
        {
            //dtpStart.Value = DateTime.Now;
            //dtpEnd.Value = DateTime.Now;
            dtpDate.Value = DateTime.Now;

            conn.Open();

            LoadProgramTopics();
            LoadData_ProgSegments();

            conn.Close();

        }

        public void LoadData_ProgSegments()
        {
            String sqlString = "Select * from radio_program";
            MySqlCommand my_command = new MySqlCommand(sqlString, conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(my_command);

            DataTable dt = new DataTable();
            my_adapter.Fill(dt);

            DGV_Prog.DataSource = dt;


        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        public void LoadProgramTopics()
        {
            String query = "SELECT programID, programTopic FROM radio_program";
            MySqlCommand my_command = new MySqlCommand(query, conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(my_command);

            DataTable dt = new DataTable();
            my_adapter.Fill(dt);

            if(dt.Rows.Count >= 1)
            {
                for(int i = 0; i<dt.Rows.Count; i++)
                {
                    cbProgram.Items.Add(dt.Rows[i]["programTopic"].ToString());
                    cbProgID.Items.Add(dt.Rows[i]["programID"].ToString());
                    //tbDesc.Text = row.Cells[3].Value.ToString();
                    //tbDesc.Text = dt.Rows[1]["description"].ToString();
                }
            }



        }
        public void Load_Appointments()
        {
            try
            {
                //conn.Open();
                //MySqlCommand comm = new MySqlCommand("SELECT *")
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProgID.SelectedIndex = cbProgram.SelectedIndex;
            getID = cbProgID.Text;
            //MessageBox.Show(getID);
            String query = "SELECT * FROM radio_program WHERE programID = "+getID+"";
            MySqlCommand my_command = new MySqlCommand(query, conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(my_command);

            DataTable dt = new DataTable();
            my_adapter.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                tbDesc.Text = dt.Rows[0]["description"].ToString();
                tbSTime.Text = dt.Rows[0]["start_time"].ToString();
                tbETime.Text = dt.Rows[0]["end_time"].ToString();
            }
        }

        public String getID;

    }
}
