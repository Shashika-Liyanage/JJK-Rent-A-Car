namespace JJK_Rent_A_Car
{
    partial class Rent_Details
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
            this.lbloption = new System.Windows.Forms.Label();
            this.rdbtndriver2 = new System.Windows.Forms.RadioButton();
            this.rdbtndriver1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPreturneddate = new System.Windows.Forms.DateTimePicker();
            this.DTPrenteddate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtcustomerID = new System.Windows.Forms.TextBox();
            this.lblCusID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView_Rent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloption
            // 
            this.lbloption.AutoSize = true;
            this.lbloption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloption.Location = new System.Drawing.Point(320, 146);
            this.lbloption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloption.Name = "lbloption";
            this.lbloption.Size = new System.Drawing.Size(52, 16);
            this.lbloption.TabIndex = 173;
            this.lbloption.Text = "Option";
            this.lbloption.Click += new System.EventHandler(this.lbloption_Click);
            // 
            // rdbtndriver2
            // 
            this.rdbtndriver2.AutoSize = true;
            this.rdbtndriver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtndriver2.Location = new System.Drawing.Point(201, 175);
            this.rdbtndriver2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbtndriver2.Name = "rdbtndriver2";
            this.rdbtndriver2.Size = new System.Drawing.Size(122, 20);
            this.rdbtndriver2.TabIndex = 172;
            this.rdbtndriver2.TabStop = true;
            this.rdbtndriver2.Text = "Without Driver";
            this.rdbtndriver2.UseVisualStyleBackColor = true;
            this.rdbtndriver2.CheckedChanged += new System.EventHandler(this.rdbtndriver2_CheckedChanged);
            // 
            // rdbtndriver1
            // 
            this.rdbtndriver1.AutoSize = true;
            this.rdbtndriver1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtndriver1.Location = new System.Drawing.Point(201, 130);
            this.rdbtndriver1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbtndriver1.Name = "rdbtndriver1";
            this.rdbtndriver1.Size = new System.Drawing.Size(101, 20);
            this.rdbtndriver1.TabIndex = 171;
            this.rdbtndriver1.TabStop = true;
            this.rdbtndriver1.Text = "With Driver";
            this.rdbtndriver1.UseVisualStyleBackColor = true;
            this.rdbtndriver1.CheckedChanged += new System.EventHandler(this.rdbtndriver1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 170;
            this.label3.Text = "Driver Option";
            // 
            // DTPreturneddate
            // 
            this.DTPreturneddate.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPreturneddate.Location = new System.Drawing.Point(597, 126);
            this.DTPreturneddate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DTPreturneddate.Name = "DTPreturneddate";
            this.DTPreturneddate.Size = new System.Drawing.Size(254, 23);
            this.DTPreturneddate.TabIndex = 169;
            this.DTPreturneddate.ValueChanged += new System.EventHandler(this.DTPreturneddate_ValueChanged);
            // 
            // DTPrenteddate
            // 
            this.DTPrenteddate.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPrenteddate.Location = new System.Drawing.Point(597, 77);
            this.DTPrenteddate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DTPrenteddate.Name = "DTPrenteddate";
            this.DTPrenteddate.Size = new System.Drawing.Size(254, 23);
            this.DTPrenteddate.TabIndex = 168;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(458, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 167;
            this.label2.Text = "Returned Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(457, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 166;
            this.label1.Text = "Rented Date";
            // 
            // txtrentID
            // 
            this.txtrentID.Location = new System.Drawing.Point(201, 77);
            this.txtrentID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtrentID.Name = "txtrentID";
            this.txtrentID.Size = new System.Drawing.Size(214, 23);
            this.txtrentID.TabIndex = 165;
            this.txtrentID.TextChanged += new System.EventHandler(this.txtrentID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(30, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 164;
            this.label5.Text = "Rent ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 175;
            this.label6.Text = "RENT DETAILS";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RosyBrown;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(193)))));
            this.button6.FlatAppearance.BorderSize = 7;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(12, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(872, 274);
            this.button6.TabIndex = 182;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // txtcustomerID
            // 
            this.txtcustomerID.Location = new System.Drawing.Point(201, 226);
            this.txtcustomerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcustomerID.Name = "txtcustomerID";
            this.txtcustomerID.Size = new System.Drawing.Size(214, 23);
            this.txtcustomerID.TabIndex = 203;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.BackColor = System.Drawing.Color.RosyBrown;
            this.lblCusID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCusID.Location = new System.Drawing.Point(30, 230);
            this.lblCusID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(106, 19);
            this.lblCusID.TabIndex = 202;
            this.lblCusID.Text = "Customer ID";
            this.lblCusID.Click += new System.EventHandler(this.lblCusID_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(461, 312);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 34);
            this.btnDelete.TabIndex = 207;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JJK_Rent_A_Car.Properties.Resources.logo_pic;
            this.pictureBox1.Location = new System.Drawing.Point(891, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 176;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdate.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(277, 309);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 34);
            this.btnUpdate.TabIndex = 211;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBack.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(960, 593);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 29);
            this.btnBack.TabIndex = 212;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnInsert.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnInsert.Location = new System.Drawing.Point(67, 309);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 37);
            this.btnInsert.TabIndex = 208;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView_Rent
            // 
            this.dataGridView_Rent.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_Rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rent.Location = new System.Drawing.Point(110, 387);
            this.dataGridView_Rent.Name = "dataGridView_Rent";
            this.dataGridView_Rent.Size = new System.Drawing.Size(717, 201);
            this.dataGridView_Rent.TabIndex = 213;
            // 
            // Rent_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1071, 647);
            this.Controls.Add(this.dataGridView_Rent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtcustomerID);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbloption);
            this.Controls.Add(this.rdbtndriver2);
            this.Controls.Add(this.rdbtndriver1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPreturneddate);
            this.Controls.Add(this.DTPrenteddate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Rent_Details";
            this.Text = "Rent_Details";
            this.Load += new System.EventHandler(this.Rent_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloption;
        private System.Windows.Forms.RadioButton rdbtndriver2;
        private System.Windows.Forms.RadioButton rdbtndriver1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPreturneddate;
        private System.Windows.Forms.DateTimePicker DTPrenteddate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtcustomerID;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView_Rent;
    }
}