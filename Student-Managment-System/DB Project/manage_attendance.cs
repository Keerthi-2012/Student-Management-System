using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DB_Project
{
    public partial class manage_attendance : UserControl
    {

        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");
        int classId;
        public manage_attendance()
        {
            InitializeComponent();
        }
        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)dataGridView2.Rows[e.RowIndex].Cells["Status"];

            // Clear existing items and add new items
            comboBoxCell.Items.Clear();
            comboBoxCell.Items.AddRange(new string[] { "Present", "Absent", "Late" });

            // Set the default value
            comboBoxCell.Value = "Present";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manage_attendance_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;

            StreamReader sw = new StreamReader("D://ok.txt");
            int teacherId = Convert.ToInt32(sw.ReadLine());
            sw.Close();


            OracleCommand command = con.CreateCommand();

            string query = "SELECT CLASS_ID, CLASS_NAME FROM CLASS WHERE TEACHER_ID = :teacherId";

            command.CommandText = query;
            command.Parameters.Add(":teacherId", OracleDbType.Int32).Value = teacherId;

            con.Open();

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            con.Close();    
            panel1.Show();
            dataGridView1.Refresh();
            dataGridView1.Show();




        }

        private void button2_Click(object sender, EventArgs e)
        {


            DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;


             classId = Convert.ToInt32(selectedRow["CLASS_ID"]);

            panel1.Visible= false;





            // Get the class ID from a TextBox or any other control
         

            OracleCommand command = con.CreateCommand();

            string query = "SELECT S.* FROM STUDENT S " +
                           "JOIN CLASS_STUDENT CS ON S.SID = CS.STUDENT_ID " +
                           "WHERE CS.CLASS_ID = :classId";

            command.CommandText = query;
            command.Parameters.Add(":classId", OracleDbType.Int32).Value = classId;

           con.Open();

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            dataGridView2.DataSource = dataSet.Tables[0];

            con.Close();

            panel2.Show();

           
            dataGridView2.Refresh();
            dataGridView2.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {








            DateTime attendanceDate = dateTimePicker1.Value.Date;


            string queryCheck = "SELECT COUNT(*) FROM ATTENDANCE WHERE CLASS_ID = :classID AND ATTENDANCE_DATE = :attendanceDate";

            using (OracleCommand commandCheck = new OracleCommand(queryCheck, con))
            {
                commandCheck.Parameters.Add("classID", OracleDbType.Int32).Value = classId;
                commandCheck.Parameters.Add("attendanceDate", OracleDbType.Date).Value = attendanceDate;

                con.Open();
                int count = Convert.ToInt32(commandCheck.ExecuteScalar());
                con.Close();

                if (count > 0)
                {
                    // A record with the same date and class already exists
                    MessageBox.Show("Attendance record for the same date and class already exists.");
                    return;
                }
            }

          
          





            // Assuming you have a connection object named "connection" and a DataGridView named "dataGridView1"
            // Iterate over the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                // Retrieve the necessary data from each row
                int studentID = Convert.ToInt32(row.Cells["SID"].Value);
                string attendanceStatus = row.Cells["Status"].Value.ToString();

                if (attendanceStatus == "")
                {
                    MessageBox.Show("Please Mark All Students");
                return;
                }

                // Create a parameterized SQL query for inserting into the ATTENDANCE table
                string query = "INSERT INTO ATTENDANCE (CLASS_ID, STUDENT_ID, ATTENDANCE_DATE, ATTENDANCE_STATUS) VALUES (:classID, :studentID, :attendanceDate, :attendanceStatus)";

                // Execute the query to insert the attendance data
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    command.Parameters.Add("classID", OracleDbType.Int32).Value = classId;
                    command.Parameters.Add("studentID", OracleDbType.Int32).Value = studentID;
                    command.Parameters.Add("attendanceDate", OracleDbType.Date).Value = attendanceDate;
                    command.Parameters.Add("attendanceStatus", OracleDbType.Varchar2).Value = attendanceStatus;

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Submitted Succesfully");








        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
