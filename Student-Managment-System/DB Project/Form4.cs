using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {

            classes_for_studenr classes_For_Studenr = new classes_for_studenr();

            panel2.Controls.Clear();
            panel2.Controls.Add(classes_For_Studenr);
            classes_For_Studenr.Dock = DockStyle.Fill;




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



           Attendance_Report attendance_Report = new Attendance_Report();   


            panel2.Controls.Clear();
            panel2.Controls.Add(attendance_Report);
            attendance_Report.Dock = DockStyle.Fill;



        }
    }
}
