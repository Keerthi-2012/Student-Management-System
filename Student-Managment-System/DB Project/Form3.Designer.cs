namespace DB_Project
{
    partial class Form3
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
            this.buttons_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.add_teacher_button = new System.Windows.Forms.Button();
            this.add_student_button = new System.Windows.Forms.Button();
            this.student_view_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttons_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttons_panel
            // 
            this.buttons_panel.BackColor = System.Drawing.Color.CadetBlue;
            this.buttons_panel.Controls.Add(this.panel2);
            this.buttons_panel.Controls.Add(this.add_teacher_button);
            this.buttons_panel.Controls.Add(this.add_student_button);
            this.buttons_panel.Controls.Add(this.student_view_button);
            this.buttons_panel.Location = new System.Drawing.Point(2, 1);
            this.buttons_panel.Margin = new System.Windows.Forms.Padding(10);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.Size = new System.Drawing.Size(388, 1014);
            this.buttons_panel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 126);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(105, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // add_teacher_button
            // 
            this.add_teacher_button.BackColor = System.Drawing.Color.CadetBlue;
            this.add_teacher_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_teacher_button.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_teacher_button.ForeColor = System.Drawing.Color.Black;
            this.add_teacher_button.Location = new System.Drawing.Point(3, 135);
            this.add_teacher_button.Name = "add_teacher_button";
            this.add_teacher_button.Size = new System.Drawing.Size(375, 114);
            this.add_teacher_button.TabIndex = 2;
            this.add_teacher_button.Text = "Students";
            this.add_teacher_button.UseVisualStyleBackColor = false;
            this.add_teacher_button.Click += new System.EventHandler(this.add_teacher_button_Click);
            // 
            // add_student_button
            // 
            this.add_student_button.BackColor = System.Drawing.Color.CadetBlue;
            this.add_student_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_student_button.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_student_button.ForeColor = System.Drawing.Color.Black;
            this.add_student_button.Location = new System.Drawing.Point(3, 255);
            this.add_student_button.Name = "add_student_button";
            this.add_student_button.Size = new System.Drawing.Size(375, 121);
            this.add_student_button.TabIndex = 3;
            this.add_student_button.Text = "My Classes";
            this.add_student_button.UseVisualStyleBackColor = false;
            this.add_student_button.Click += new System.EventHandler(this.add_student_button_Click);
            // 
            // student_view_button
            // 
            this.student_view_button.BackColor = System.Drawing.Color.CadetBlue;
            this.student_view_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.student_view_button.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_view_button.ForeColor = System.Drawing.Color.Black;
            this.student_view_button.Location = new System.Drawing.Point(3, 382);
            this.student_view_button.Name = "student_view_button";
            this.student_view_button.Size = new System.Drawing.Size(375, 125);
            this.student_view_button.TabIndex = 4;
            this.student_view_button.Text = "Manage Attendance";
            this.student_view_button.UseVisualStyleBackColor = false;
            this.student_view_button.Click += new System.EventHandler(this.student_view_button_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(403, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 1014);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1675, 1016);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttons_panel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.buttons_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel buttons_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_teacher_button;
        private System.Windows.Forms.Button add_student_button;
        private System.Windows.Forms.Button student_view_button;
        private System.Windows.Forms.Panel panel1;
    }
}