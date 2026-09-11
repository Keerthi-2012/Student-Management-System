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
using System.IO;

namespace DB_Project
{
    public partial class teacher_login : UserControl
    {


        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");

        private teacher_classes teacherClassesControl;
        int tid;
        public teacher_login()
        {
            InitializeComponent();
        }
        public void SetTeacherClassesControl(teacher_classes control)
        {
            teacherClassesControl = control;
        }
        private void button2_Click(object sender, EventArgs e)
        {

              
           
            if (id_box.Text == "")
            {


                MessageBox.Show("Dont Leave Empty Id");
                return;
            }

            tid = Convert.ToInt32(id_box.Text);
        

            StreamWriter sw = new StreamWriter("D://ok.txt");
            sw.WriteLine(tid);

            sw.Flush();

            sw.Close();


            //  tc.teacherId = tid;
            Form3 form = new Form3();
            form.ShowDialog();

        }
        public int get_tid() {

            return tid; 
        }
        private void teacher_login_Load(object sender, EventArgs e)
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
