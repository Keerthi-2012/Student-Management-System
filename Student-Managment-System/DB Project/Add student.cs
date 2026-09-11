using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class Add_student : UserControl
    {

        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");

        public Add_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (first_name_t_box.Text == "" || last_name.Text == "" || student_gender_comboBox2.Text == "")
            {

                MessageBox.Show("Dont insert empty record.");
                return;
            }

            con.Open();
            //------------------------------------------------------------------------------------------------------------

            //this code is for id generation for student 


            int id = 0;
            string sql = "SELECT sid  FROM student";
            OracleCommand command = new OracleCommand(sql, con);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("sid"));

            }
            reader.Close();

            id++;

            //---------------------------------------------------------------------------------------------------------------------




            string query = "INSERT INTO STUDENT (SID, FIRST_NAME, LAST_NAME, REGISTRATION_DATE, GENDER, CONTACT_NO, BLOOD_GROUP, ADDRESS, FEES_PAID_STATUS) VALUES (:SID, :FIRST_NAME, :LAST_NAME, :REGISTRATION_DATE, :GENDER, :CONTACT_NO, :BLOOD_GROUP, :ADDRESS, :FEES_PAID_STATUS)";
            OracleCommand command1 = new OracleCommand(query, con);

            command1.Parameters.Add(":SID", OracleDbType.Int32).Value = id;
            command1.Parameters.Add(":FIRST_NAME", OracleDbType.Varchar2).Value = first_name_t_box.Text;
            command1.Parameters.Add(":LAST_NAME", OracleDbType.Varchar2).Value = last_name.Text;
            command1.Parameters.Add(":REGISTRATION_DATE", OracleDbType.Date).Value = Convert.ToDateTime(dateTimePicker1.Text);
            command1.Parameters.Add(":GENDER", OracleDbType.Varchar2).Value = student_gender_comboBox2.Text;
            command1.Parameters.Add(":CONTACT_NO", OracleDbType.Varchar2).Value = contact_textBox.Text;
            command1.Parameters.Add(":BLOOD_GROUP", OracleDbType.Varchar2).Value = student_b_group_comboBox.Text;
            command1.Parameters.Add(":ADDRESS", OracleDbType.Varchar2).Value = adress_textBox.Text;
            command1.Parameters.Add(":FEES_PAID_STATUS", OracleDbType.Varchar2).Value = comboBox4.Text;




            int rowsInserted = command1.ExecuteNonQuery();



            if (rowsInserted > 0)
            {
                MessageBox.Show("Student record inserted successfully.");
            }
            else
            {
                MessageBox.Show("Error inserting student record.");
            }









            first_name_t_box.Clear();
            last_name.Clear();
            student_gender_comboBox2.Text = "";
            contact_textBox.Clear();
            student_b_group_comboBox.Text = "";
            adress_textBox.Clear();
            comboBox4.Text = "";



            con.Close();




        }

        private void student_reg_datecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_student_Load(object sender, EventArgs e)
        {

        }

        private void last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_student_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
