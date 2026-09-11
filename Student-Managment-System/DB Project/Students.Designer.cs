namespace DB_Project
{
    partial class Students
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOODGROUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DB_Project.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.sTUDENTTableAdapter = new DB_Project.DataSet1TableAdapters.STUDENTTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adress_textBox = new System.Windows.Forms.TextBox();
            this.contact_textBox = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name_t_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.cONTACTNODataGridViewTextBoxColumn,
            this.bLOODGROUPDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 644);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            this.fIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Width = 183;
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            this.lASTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lASTNAMEDataGridViewTextBoxColumn.Width = 176;
            // 
            // rEGISTRATIONDATEDataGridViewTextBoxColumn
            // 
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "REGISTRATION_DATE";
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.HeaderText = "REGISTRATION_DATE";
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.Name = "rEGISTRATIONDATEDataGridViewTextBoxColumn";
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEGISTRATIONDATEDataGridViewTextBoxColumn.Width = 274;
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.ReadOnly = true;
            this.gENDERDataGridViewTextBoxColumn.Width = 136;
            // 
            // cONTACTNODataGridViewTextBoxColumn
            // 
            this.cONTACTNODataGridViewTextBoxColumn.DataPropertyName = "CONTACT_NO";
            this.cONTACTNODataGridViewTextBoxColumn.HeaderText = "CONTACT_NO";
            this.cONTACTNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cONTACTNODataGridViewTextBoxColumn.Name = "cONTACTNODataGridViewTextBoxColumn";
            this.cONTACTNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cONTACTNODataGridViewTextBoxColumn.Width = 200;
            // 
            // bLOODGROUPDataGridViewTextBoxColumn
            // 
            this.bLOODGROUPDataGridViewTextBoxColumn.DataPropertyName = "BLOOD_GROUP";
            this.bLOODGROUPDataGridViewTextBoxColumn.HeaderText = "BLOOD_GROUP";
            this.bLOODGROUPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bLOODGROUPDataGridViewTextBoxColumn.Name = "bLOODGROUPDataGridViewTextBoxColumn";
            this.bLOODGROUPDataGridViewTextBoxColumn.ReadOnly = true;
            this.bLOODGROUPDataGridViewTextBoxColumn.Width = 213;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDRESSDataGridViewTextBoxColumn.Width = 148;
            // 
            // fEESPAIDSTATUSDataGridViewTextBoxColumn
            // 
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn.DataPropertyName = "FEES_PAID_STATUS";
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn.HeaderText = "FEES_PAID_STATUS";
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn.Name = "fEESPAIDSTATUSDataGridViewTextBoxColumn";
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.fEESPAIDSTATUSDataGridViewTextBoxColumn.Width = 252;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(245, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "Edit selected ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adress_textBox);
            this.panel1.Controls.Add(this.contact_textBox);
            this.panel1.Controls.Add(this.last_name);
            this.panel1.Controls.Add(this.first_name_t_box);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 733);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(398, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 52);
            this.label3.TabIndex = 37;
            this.label3.Text = "Update Student ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(420, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 56);
            this.button2.TabIndex = 36;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(620, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "New Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(130, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "New Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(634, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "New Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(130, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "New First Name";
            // 
            // adress_textBox
            // 
            this.adress_textBox.BackColor = System.Drawing.Color.CadetBlue;
            this.adress_textBox.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.adress_textBox.Location = new System.Drawing.Point(602, 432);
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(342, 45);
            this.adress_textBox.TabIndex = 27;
            // 
            // contact_textBox
            // 
            this.contact_textBox.BackColor = System.Drawing.Color.CadetBlue;
            this.contact_textBox.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.contact_textBox.Location = new System.Drawing.Point(119, 432);
            this.contact_textBox.Name = "contact_textBox";
            this.contact_textBox.Size = new System.Drawing.Size(342, 45);
            this.contact_textBox.TabIndex = 26;
            // 
            // last_name
            // 
            this.last_name.BackColor = System.Drawing.Color.CadetBlue;
            this.last_name.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.last_name.Location = new System.Drawing.Point(602, 304);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(342, 45);
            this.last_name.TabIndex = 25;
            // 
            // first_name_t_box
            // 
            this.first_name_t_box.BackColor = System.Drawing.Color.CadetBlue;
            this.first_name_t_box.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_t_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.first_name_t_box.Location = new System.Drawing.Point(119, 304);
            this.first_name_t_box.Name = "first_name_t_box";
            this.first_name_t_box.Size = new System.Drawing.Size(342, 45);
            this.first_name_t_box.TabIndex = 24;
            this.first_name_t_box.TextChanged += new System.EventHandler(this.first_name_t_box_TextChanged);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Students";
            this.Size = new System.Drawing.Size(1102, 739);
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox adress_textBox;
        protected internal System.Windows.Forms.TextBox contact_textBox;
        private System.Windows.Forms.TextBox last_name;
        protected internal System.Windows.Forms.TextBox first_name_t_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGISTRATIONDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOODGROUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEESPAIDSTATUSDataGridViewTextBoxColumn;
    }
}
