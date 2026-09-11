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
    public partial class Teachers : UserControl
    {
        OracleConnection con = new OracleConnection(@"DATA SOURCE = localhost:1521/xe; USER ID=ROHIT1;PASSWORD=rohit");
        DataTable dt = new DataTable();

        public void func1()
        {
            con.Open();

            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM Teacher", con);



            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();

            dataGridView1.Refresh();

            dataGridView1.Show();
            con.Close();

            dataGridView1.Refresh();

            dataGridView1.Show();

         
        }

        public Teachers()
        {
            InitializeComponent();


            panel1.Hide();

            func1();

           
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           panel1.Show();    


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {








        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            if (first_name_t_box.Text == "" || last_name.Text == "")
            {

                MessageBox.Show("Dont insert empty record.");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string firstName = first_name_t_box.Text;
                string lastName = last_name.Text;

                string contactNo = contact_textBox.Text;

                string address = adress_textBox.Text;



                DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;


                int selectedIndex = Convert.ToInt32(selectedRow["TID"]);


                // Open the database connection
                con.Open();

                // Create an SQL command to update the corresponding row in the database
                string sql = "UPDATE TEACHER SET FIRST_NAME = :FirstName, LAST_NAME = :LastName, " +
                   "CONTACT_NO = :ContactNo, ADDRESS = :Address WHERE TID = :selectedIndex";

                // Create a new SqlCommand object
                OracleCommand command = new OracleCommand(sql, con);

                command.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = firstName;
                command.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = lastName;

                command.Parameters.Add(":ContactNo", OracleDbType.Varchar2).Value = contactNo;
                command.Parameters.Add(":Address", OracleDbType.Varchar2).Value = address;
                command.Parameters.Add(":selectedIndex", OracleDbType.Int32).Value = selectedIndex;

                // Execute the SQL command to update the row in the database
                int rowsAffected = command.ExecuteNonQuery();

                // Close the database connection
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully.");

                }
                else
                {
                    MessageBox.Show("Record not found.");

                }


            }



        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
