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

namespace DB_Project
{
    public partial class Student_for_teacher : UserControl
    {
        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");
        DataTable dt = new DataTable();
        public Student_for_teacher()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_for_teacher_Load(object sender, EventArgs e)
        {


            con.Open();

            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM STUDENT", con);



            da.Fill(dt);

            dataGridView1.DataSource = dt;


            con.Close();

            dataGridView1.Refresh();

            dataGridView1.Show();






        }
    }
}
