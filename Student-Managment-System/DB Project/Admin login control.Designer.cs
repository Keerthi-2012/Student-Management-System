namespace DB_Project
{
    partial class Admin_login_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.first_name_t_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(257, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 60);
            this.label5.TabIndex = 1;
            this.label5.Text = "Welcome Admin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.textBox1.Location = new System.Drawing.Point(257, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 55);
            this.textBox1.TabIndex = 3;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(310, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(258, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(249, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // first_name_t_box
            // 
            this.first_name_t_box.BackColor = System.Drawing.Color.CadetBlue;
            this.first_name_t_box.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_t_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.first_name_t_box.Location = new System.Drawing.Point(257, 211);
            this.first_name_t_box.Name = "first_name_t_box";
            this.first_name_t_box.Size = new System.Drawing.Size(342, 55);
            this.first_name_t_box.TabIndex = 2;
            // 
            // Admin_login_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.first_name_t_box);
            this.Controls.Add(this.label5);
            this.Name = "Admin_login_control";
            this.Size = new System.Drawing.Size(872, 621);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox first_name_t_box;
    }
}
