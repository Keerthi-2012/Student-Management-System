using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DB_Project
{
    public partial class student_login : UserControl
    {

        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");

        public student_login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {





            if (id_box.Text == "")
            {


                MessageBox.Show("Dont Leave Empty Id");
                return;
            }

            int sid = Convert.ToInt32(id_box.Text);


            StreamWriter sw = new StreamWriter("D://stud.txt");
            sw.WriteLine(sid);

            sw.Flush();

            sw.Close();


            //  tc.teacherId = tid;
            Form4 form = new Form4();
            form.ShowDialog();



        }

        private void student_login_Load(object sender, EventArgs e)
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
    }
}
