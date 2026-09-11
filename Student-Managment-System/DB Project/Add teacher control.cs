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
    public partial class UserControl1 : UserControl
    {

        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

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
            string sql = "SELECT tid  FROM teacher";
            OracleCommand command = new OracleCommand(sql, con);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("tid"));

            }
            reader.Close();

            id++;

            //---------------------------------------------------------------------------------------------------------------------




            string query = "INSERT INTO TEACHER (TID, FIRST_NAME, LAST_NAME, USERNAME , EMAIL,REGISTRATION_DATE, GENDER, BLOOD_GROUP, CONTACT_NO, ADDRESS) VALUES (:TID, :FIRST_NAME, :LAST_NAME,  :USERNAME , :EMAIL, :REGISTRATION_DATE, :GENDER, :BLOOD_GROUP, :CONTACT_NO,  :ADDRESS)";
            OracleCommand command1 = new OracleCommand(query, con);

            command1.Parameters.Add(":TID", OracleDbType.Int32).Value = id;
            command1.Parameters.Add(":FIRST_NAME", OracleDbType.Varchar2).Value = first_name_t_box.Text;
            command1.Parameters.Add(":LAST_NAME", OracleDbType.Varchar2).Value = last_name.Text;

            command1.Parameters.Add(":USERNAME", OracleDbType.Varchar2).Value = "";
            command1.Parameters.Add(":EMAIL", OracleDbType.Varchar2).Value = teacher_username_textBox.Text;

            command1.Parameters.Add(":REGISTRATION_DATE", OracleDbType.Date).Value = Convert.ToDateTime(dateTimePicker1.Text);
            command1.Parameters.Add(":GENDER", OracleDbType.Varchar2).Value = student_gender_comboBox2.Text;

            command1.Parameters.Add(":BLOOD_GROUP", OracleDbType.Varchar2).Value = student_b_group_comboBox.Text;
            command1.Parameters.Add(":CONTACT_NO", OracleDbType.Varchar2).Value = contact_textBox.Text;
            command1.Parameters.Add(":ADDRESS", OracleDbType.Varchar2).Value = adress_textBox.Text;
 




            int rowsInserted = command1.ExecuteNonQuery();



            if (rowsInserted > 0)
            {
                MessageBox.Show("Teacher record inserted successfully.");
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
            teacher_username_textBox.Clear() ;



            con.Close();









        }

        private void teacher_username_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
