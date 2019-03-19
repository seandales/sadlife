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
    public partial class AddProgramSegment : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;username=root; password=root;database=radio");
        public AddProgramSegment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            
            String insertQuery = "INSERT into radio_program(programTopic, program_Speaker, description, start_time, end_time, start_date, end_date, status) " +
                "values('" + tbProgTopic.Text + "','" + tbSpeaker.Text + "','" + tbDesc.Text + "','" + tbSHour.Text + ":" + tbSMinute.Text + cbTime.Text +"','" + tbEHour.Text + ":" + tbEMinute.Text + cbTime2.Text + "','" + dtpSDate.Value.Date.ToString("yyyy-MM-dd HH:mm") + "','" + dtpEDate.Value.Date.ToString("yyyy-MM-dd HH:mm") + "','Active'" + ")";
            //INSERT INTO items (itemName, description, price, status, image) VALUES ('Pen', 'Tom B. Erichsen', '21', 'Active', 'img');
            MySqlCommand command = new MySqlCommand(insertQuery, conn);

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
                MessageBox.Show(ex.Message);
            }

            
            conn.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void AddProgramSegment_Load(object sender, EventArgs e)
        {
            //dtpSTime.Value = DateTime.Now;
            //dtpETime.Value = DateTime.Now;

            dtpSDate.Value = DateTime.Now;
            dtpEDate.Value = DateTime.Now;

            
        }

        private void tbSHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                MessageBox.Show("Please enter only numbers [01-60]");
                e.Handled = true;
            }





            tbSHour.MaxLength = 2;
        }



        /*
        public void timeAddValue()
        {
            for(int i = 0; i <=12; i++)
            {
                cbSTime_hour.Items.Add(i.ToString());

            }
        }
        */
    }
}
