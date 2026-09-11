using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DB_Project
{

  
    public partial class teacher_classes : UserControl
    {


        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");
       
      


        public teacher_classes()
        {
            InitializeComponent();
        }

        private void teacher_classes_Load(object sender, EventArgs e)
        {


            //teacher_login teacher_Login = new teacher_login();
            //int teacherId=teacher_Login.get_tid();

          
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

            dataGridView1.Refresh();
            dataGridView1.Show();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
