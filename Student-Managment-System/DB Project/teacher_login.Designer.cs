namespace DB_Project
{
    partial class teacher_login
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
            this.id_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.Color.CadetBlue;
            this.id_box.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_box.FormattingEnabled = true;
            this.id_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.id_box.Location = new System.Drawing.Point(316, 316);
            this.id_box.MaxDropDownItems = 100;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(342, 40);
            this.id_box.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(325, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Teacher Id";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(375, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 56);
            this.button2.TabIndex = 44;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacher_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label2);
            this.Name = "teacher_login";
            this.Size = new System.Drawing.Size(1099, 721);
            this.Load += new System.EventHandler(this.teacher_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
