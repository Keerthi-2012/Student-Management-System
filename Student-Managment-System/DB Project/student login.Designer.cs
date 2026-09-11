namespace DB_Project
{
    partial class student_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(184, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Id";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(258, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 65);
            this.button4.TabIndex = 10;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(182, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 60);
            this.label5.TabIndex = 7;
            this.label5.Text = "Welcome Student";
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.Color.CadetBlue;
            this.id_box.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_box.FormattingEnabled = true;
            this.id_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.id_box.Location = new System.Drawing.Point(183, 246);
            this.id_box.MaxDropDownItems = 100;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(342, 40);
            this.id_box.TabIndex = 44;
            // 
            // student_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Name = "student_login";
            this.Size = new System.Drawing.Size(758, 622);
            this.Load += new System.EventHandler(this.student_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox id_box;
    }
}
