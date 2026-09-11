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
    public partial class Form3 : Form
    {

    



        public Form3()


        {
            InitializeComponent();

            
        }

    private void add_teacher_button_Click(object sender, EventArgs e)
        {





      
            Student_for_teacher st_fr= new Student_for_teacher();


            panel1.Controls.Clear();
            panel1.Controls.Add(st_fr);
            st_fr.Dock = DockStyle.Fill;



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_student_button_Click(object sender, EventArgs e)
        {




            teacher_classes teacher_Classes = new teacher_classes();



            panel1.Controls.Clear();
            panel1.Controls.Add(teacher_Classes);
            teacher_Classes.Dock = DockStyle.Fill;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_view_button_Click(object sender, EventArgs e)
        {




            manage_attendance manage_Attendance = new manage_attendance();      

            panel1.Controls.Clear();
            panel1.Controls.Add(manage_Attendance);
            manage_Attendance.Dock = DockStyle.Fill;





        }
    }
}
