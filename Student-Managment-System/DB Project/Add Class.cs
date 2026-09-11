using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;


namespace DB_Project
{
    public partial class Add_Class : UserControl
    {

        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");

        public Add_Class()
        {
            InitializeComponent();
        }

        private void Add_Class_Load(object sender, EventArgs e)
        {

            con.Open();
            OracleCommand command = con.CreateCommand();
            string query = "SELECT TID FROM TEACHER";

            command.CommandText = query;



            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                id_box.Items.Add(reader.GetInt32(0));
            }

            reader.Close();

            con.Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (class_name_t_box.Text == "" || class_start_time.Text == "" || Class_end_time.Text == "")
            {

                MessageBox.Show("Dont insert empty record.");
                return;
            }

            con.Open();
            //------------------------------------------------------------------------------------------------------------


        

            //---------------------------------------------------------------------------------------------------------------------



            string className = class_name_t_box.Text;
            int teacherId = Convert.ToInt32(id_box.Text);
            string startTime = class_start_time.Text;
            string endTime = Class_end_time.Text;
            string daysOfClass = Days_of_class_t_box.Text;

           
            OracleCommand command = con.CreateCommand();



            // Construct the SQL INSERT statement
            string sql = "INSERT INTO CLASS ( CLASS_NAME, TEACHER_ID, START_TIME, END_TIME, DAYS_OF_CLASS) " +
                         "VALUES ( :className, :teacherId, :startTime, :endTime, :daysOfClass)";

            command.CommandText = sql;

            // Set parameter values
            command.Parameters.Add(":className", OracleDbType.Varchar2).Value = className;
            command.Parameters.Add(":teacherId", OracleDbType.Int32).Value = teacherId;
            command.Parameters.Add(":startTime", OracleDbType.Varchar2).Value = startTime;
            command.Parameters.Add(":endTime", OracleDbType.Varchar2).Value = endTime;
            command.Parameters.Add(":daysOfClass", OracleDbType.Varchar2).Value = daysOfClass;

            

            // Execute the INSERT statement
            command.ExecuteNonQuery();

            // Show success message or perform any additional actions
            MessageBox.Show("Data inserted successfully!");





            Days_of_class_t_box.Clear();
            Class_end_time.Clear();
            class_name_t_box.Clear();


            con.Close();






        }

   

     

    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
