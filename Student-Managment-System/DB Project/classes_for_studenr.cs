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
    public partial class classes_for_studenr : UserControl
    {
        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");
  
        public classes_for_studenr()
        {
            InitializeComponent();
        }

        private void classes_for_studenr_Load(object sender, EventArgs e)
        {



            StreamReader sw = new StreamReader("D://stud.txt");
            int studentid = Convert.ToInt32(sw.ReadLine());
            sw.Close();
           

            string query = @"
    SELECT c.CLASS_NAME, c.START_TIME, c.END_TIME, c.DAYS_OF_CLASS
    FROM CLASS c
    JOIN CLASS_STUDENT cs ON c.CLASS_ID = cs.CLASS_ID
    JOIN STUDENT s ON cs.STUDENT_ID = s.SID
    WHERE s.SID = :studentId";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                command.Parameters.Add("studentId", OracleDbType.Int32).Value =  studentid ;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
