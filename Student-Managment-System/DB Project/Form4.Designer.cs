namespace DB_Project
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_student_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.add_student_button);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 62);
            this.panel1.TabIndex = 0;
            // 
            // add_student_button
            // 
            this.add_student_button.BackColor = System.Drawing.Color.CadetBlue;
            this.add_student_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_student_button.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_student_button.ForeColor = System.Drawing.Color.Black;
            this.add_student_button.Location = new System.Drawing.Point(3, -1);
            this.add_student_button.Name = "add_student_button";
            this.add_student_button.Size = new System.Drawing.Size(671, 60);
            this.add_student_button.TabIndex = 4;
            this.add_student_button.Text = "My Classes";
            this.add_student_button.UseVisualStyleBackColor = false;
            this.add_student_button.Click += new System.EventHandler(this.add_student_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(680, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(708, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Attendance Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 650);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1394, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_student_button;
        private System.Windows.Forms.Panel panel2;
    }
}