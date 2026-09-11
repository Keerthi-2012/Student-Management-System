using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DB_Project
{
    public partial class Classes : UserControl
    {
        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");
        DataTable dt = new DataTable();

        public Classes()
        {
            InitializeComponent();

            panel1.Show();

          panel2.Hide();    
           // panel3.Hide();  

        }

        private void Classes_Load(object sender, EventArgs e)
        {
            con.Open();

            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM Class", con);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();

            dataGridView1.Refresh();

            dataGridView1.Show();

            panel2.Hide();      
       
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            // Get the class ID from a TextBox or any other control
            DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;


            int classId= Convert.ToInt32(selectedRow["CLASS_ID"]);

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

            panel1.Hide();
            dataGridView2.Refresh();
            dataGridView2.Show();

        
           
           
     

        }

        private void button1_Click(object sender, EventArgs e)
        {













            OracleCommand command = con.CreateCommand();

            string query = "SELECT * FROM STUDENT  " ;

            command.CommandText = query;
          

            con.Open();

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            dataGridView3.DataSource = dataSet.Tables[0];

            con.Close();

            panel2.Hide();
            panel1.Hide();
            dataGridView3.Refresh();

            dataGridView3.Show();
         

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {



        }


        private bool IsStudentInClass(int sid, int classId)
        {

            OracleCommand command = con.CreateCommand();

            string query = "SELECT COUNT(*) FROM CLASS_STUDENT WHERE STUDENT_ID = :sid AND CLASS_ID = :classId";

            command.CommandText = query;
            command.Parameters.Add(":sid", OracleDbType.Int32).Value = sid;
            command.Parameters.Add(":classId", OracleDbType.Int32).Value = classId;

            con.Open();

            int count = Convert.ToInt32(command.ExecuteScalar());

            con.Close();
           

            return count > 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {





            DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
            DataRowView selectedRow1 = dataGridView3.SelectedRows[0].DataBoundItem as DataRowView;


            int classId = Convert.ToInt32(selectedRow["CLASS_ID"]);
            int sid = Convert.ToInt32(selectedRow1["SID"]);

            if (IsStudentInClass(sid, classId)) {


                MessageBox.Show("student is already in class .");
                return;

            }
              

            OracleCommand command = con.CreateCommand();

            string query = "INSERT INTO CLASS_STUDENT ( CLASS_ID,STUDENT_ID) VALUES (:classId, :sid)";

            command.CommandText = query;
            command.Parameters.Add(":sid", OracleDbType.Int32).Value = sid;
            command.Parameters.Add(":classId", OracleDbType.Int32).Value = classId;

            con.Open();

            int rowsInserted = command.ExecuteNonQuery();

            con.Close();
            

            if (rowsInserted > 0)
            {
                MessageBox.Show("Class-Student record inserted successfully.");
            }
            else
            {
                MessageBox.Show("Error inserting Class-Student record.");
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
