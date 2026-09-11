using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Attendance_Report : UserControl
    {

        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");

        public Attendance_Report()
        {
            InitializeComponent();
        }

        private void Attendance_Report_Load(object sender, EventArgs e)
        {






            panel2.Visible = false;     

            StreamReader sw = new StreamReader("D://stud.txt");
            int studentid = Convert.ToInt32(sw.ReadLine());
            sw.Close();


            string query = @"
    SELECT c.CLASS_ID,c.CLASS_NAME, c.START_TIME, c.END_TIME, c.DAYS_OF_CLASS
    FROM CLASS c
    JOIN CLASS_STUDENT cs ON c.CLASS_ID = cs.CLASS_ID
    JOIN STUDENT s ON cs.STUDENT_ID = s.SID
    WHERE s.SID = :studentId";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                command.Parameters.Add("studentId", OracleDbType.Int32).Value = studentid;

                using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
                    dataGridView1.Show();
                }
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;

           
            int classId = Convert.ToInt32(selectedRow["CLASS_ID"]);

            StreamReader sw = new StreamReader("D://stud.txt");
            int studentid = Convert.ToInt32(sw.ReadLine());
            sw.Close();

          
           


            // Assuming you have a connection object named "connection" established to your database

            string query = @"
    SELECT a.ATTENDANCE_DATE, a.ATTENDANCE_STATUS
    FROM ATTENDANCE a
    WHERE a.CLASS_ID = :classId
      AND a.STUDENT_ID = :studentId";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                command.Parameters.Add("classId", OracleDbType.Int32).Value = classId;
                command.Parameters.Add("studentId", OracleDbType.Int32).Value =  studentid ;

                using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;

                    dataGridView2.Refresh(); 
                    
                    dataGridView2.Show();      
                }
            }


            // Assuming you have a connection object named "connection" established to your database

            string query1 = @"
 SELECT ROUND((COUNT(CASE WHEN a.ATTENDANCE_STATUS = 'P' THEN 1 END) / COUNT(*)) * 100) AS ATTENDANCE_PERCENTAGE
FROM ATTENDANCE a
WHERE a.CLASS_ID = :classId
  AND a.STUDENT_ID = :studentid";
;




            using (OracleCommand command = new OracleCommand(query1, con))
            {
                command.Parameters.Add("classId", OracleDbType.Int32).Value = classId ;
                command.Parameters.Add("studentId", OracleDbType.Int32).Value =  studentid;

                con.Open();
                int progress = Convert.ToInt32(  command.ExecuteScalar());
              


                progressBar1.Value = progress;
                label3.Text = progress.ToString()+"%";
                con.Close();


            }


            panel1.Visible = false;

            panel2.Visible = true;







        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
