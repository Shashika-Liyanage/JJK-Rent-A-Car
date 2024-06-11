namespace JJK_Rent_A_Car
{
    partial class Rent_Management
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cbox1vehicletype = new System.Windows.Forms.ComboBox();
            this.txtcustomerID = new System.Windows.Forms.TextBox();
            this.lblRentID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdailyprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotrentcost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotdrivercost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdaycount = new System.Windows.Forms.TextBox();
            this.txtmonthcount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtweekcount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.Cbox2driverstatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtrentID = new System.Windows.Forms.TextBox();
            this.txtvehiclenumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(205, 213);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(272, 27);
            this.dateTimePicker2.TabIndex = 208;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 27);
            this.dateTimePicker1.TabIndex = 207;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Cbox1vehicletype
            // 
            this.Cbox1vehicletype.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox1vehicletype.FormattingEnabled = true;
            this.Cbox1vehicletype.Items.AddRange(new object[] {
            "Small car",
            "Sedan car",
            "SUVs",
            "Jeep",
            "7-Seater van",
            "Commuter van"});
            this.Cbox1vehicletype.Location = new System.Drawing.Point(205, 264);
            this.Cbox1vehicletype.Name = "Cbox1vehicletype";
            this.Cbox1vehicletype.Size = new System.Drawing.Size(148, 23);
            this.Cbox1vehicletype.TabIndex = 206;
            this.Cbox1vehicletype.SelectedIndexChanged += new System.EventHandler(this.Cbox1vehicletype_SelectedIndexChanged);
            // 
            // txtcustomerID
            // 
            this.txtcustomerID.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerID.Location = new System.Drawing.Point(205, 124);
            this.txtcustomerID.Name = "txtcustomerID";
            this.txtcustomerID.Size = new System.Drawing.Size(148, 23);
            this.txtcustomerID.TabIndex = 204;
            // 
            // lblRentID
            // 
            this.lblRentID.AutoSize = true;
            this.lblRentID.BackColor = System.Drawing.Color.RosyBrown;
            this.lblRentID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblRentID.Location = new System.Drawing.Point(37, 83);
            this.lblRentID.Name = "lblRentID";
            this.lblRentID.Size = new System.Drawing.Size(68, 19);
            this.lblRentID.TabIndex = 202;
            this.lblRentID.Text = "Rent ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.RosyBrown;
            this.label12.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(36, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 19);
            this.label12.TabIndex = 201;
            this.label12.Text = "Vehicle type";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Location = new System.Drawing.Point(755, 709);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 200;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.txtdailyprice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttotrentcost);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txttotdrivercost);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtdaycount);
            this.groupBox1.Controls.Add(this.txtmonthcount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtweekcount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 303);
            this.groupBox1.TabIndex = 199;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // txtdailyprice
            // 
            this.txtdailyprice.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdailyprice.Location = new System.Drawing.Point(177, 29);
            this.txtdailyprice.Name = "txtdailyprice";
            this.txtdailyprice.Size = new System.Drawing.Size(135, 23);
            this.txtdailyprice.TabIndex = 197;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 196;
            this.label8.Text = "Vehicle Daily price";
            // 
            // txttotrentcost
            // 
            this.txttotrentcost.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotrentcost.Location = new System.Drawing.Point(177, 273);
            this.txttotrentcost.Name = "txttotrentcost";
            this.txttotrentcost.Size = new System.Drawing.Size(139, 23);
            this.txttotrentcost.TabIndex = 171;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.RosyBrown;
            this.label11.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(9, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 170;
            this.label11.Text = "Total Rent cost";
            // 
            // txttotdrivercost
            // 
            this.txttotdrivercost.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotdrivercost.Location = new System.Drawing.Point(180, 234);
            this.txttotdrivercost.Name = "txttotdrivercost";
            this.txttotdrivercost.Size = new System.Drawing.Size(132, 23);
            this.txttotdrivercost.TabIndex = 169;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RosyBrown;
            this.label10.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(6, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 168;
            this.label10.Text = "Driver cost";
            // 
            // txtdaycount
            // 
            this.txtdaycount.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdaycount.Location = new System.Drawing.Point(177, 78);
            this.txtdaycount.Name = "txtdaycount";
            this.txtdaycount.Size = new System.Drawing.Size(135, 23);
            this.txtdaycount.TabIndex = 195;
            // 
            // txtmonthcount
            // 
            this.txtmonthcount.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthcount.Location = new System.Drawing.Point(177, 157);
            this.txtmonthcount.Name = "txtmonthcount";
            this.txtmonthcount.Size = new System.Drawing.Size(135, 23);
            this.txtmonthcount.TabIndex = 191;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RosyBrown;
            this.label9.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(10, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 194;
            this.label9.Text = "DAY Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(10, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 190;
            this.label2.Text = "MONTH Count";
            // 
            // txtweekcount
            // 
            this.txtweekcount.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweekcount.Location = new System.Drawing.Point(177, 116);
            this.txtweekcount.Name = "txtweekcount";
            this.txtweekcount.Size = new System.Drawing.Size(135, 23);
            this.txtweekcount.TabIndex = 193;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(10, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 192;
            this.label5.Text = "WEEK Count";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.LavenderBlush;
            this.btninsert.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btninsert.Location = new System.Drawing.Point(604, 383);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(235, 68);
            this.btninsert.TabIndex = 198;
            this.btninsert.Text = "Calculate Rent cost";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // Cbox2driverstatus
            // 
            this.Cbox2driverstatus.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox2driverstatus.FormattingEnabled = true;
            this.Cbox2driverstatus.Items.AddRange(new object[] {
            "With driver",
            "Without driver"});
            this.Cbox2driverstatus.Location = new System.Drawing.Point(205, 349);
            this.Cbox2driverstatus.Name = "Cbox2driverstatus";
            this.Cbox2driverstatus.Size = new System.Drawing.Size(148, 23);
            this.Cbox2driverstatus.TabIndex = 195;
            this.Cbox2driverstatus.SelectedIndexChanged += new System.EventHandler(this.Cbox2driverstatus_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RosyBrown;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(36, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 194;
            this.label7.Text = "Driver Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(37, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 193;
            this.label6.Text = "End date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 192;
            this.label4.Text = "Start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 191;
            this.label3.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 190;
            this.label1.Text = "Rent management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JJK_Rent_A_Car.Properties.Resources.logo_pic;
            this.pictureBox1.Location = new System.Drawing.Point(604, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 210;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RosyBrown;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(193)))));
            this.button6.FlatAppearance.BorderSize = 7;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(11, 12);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(572, 722);
            this.button6.TabIndex = 209;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // txtrentID
            // 
            this.txtrentID.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrentID.Location = new System.Drawing.Point(205, 82);
            this.txtrentID.Name = "txtrentID";
            this.txtrentID.Size = new System.Drawing.Size(148, 23);
            this.txtrentID.TabIndex = 211;
            // 
            // txtvehiclenumber
            // 
            this.txtvehiclenumber.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvehiclenumber.Location = new System.Drawing.Point(205, 307);
            this.txtvehiclenumber.Name = "txtvehiclenumber";
            this.txtvehiclenumber.Size = new System.Drawing.Size(148, 23);
            this.txtvehiclenumber.TabIndex = 213;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.RosyBrown;
            this.label13.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(36, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 19);
            this.label13.TabIndex = 212;
            this.label13.Text = "Vehicle Number";
            // 
            // Rent_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(851, 752);
            this.Controls.Add(this.txtvehiclenumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtrentID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Cbox1vehicletype);
            this.Controls.Add(this.txtcustomerID);
            this.Controls.Add(this.lblRentID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.Cbox2driverstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rent_Management";
            this.Text = "Rent_Management";
            this.Load += new System.EventHandler(this.Rent_Management_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Cbox1vehicletype;
        private System.Windows.Forms.TextBox txtcustomerID;
        private System.Windows.Forms.Label lblRentID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdailyprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotrentcost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotdrivercost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdaycount;
        private System.Windows.Forms.TextBox txtmonthcount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtweekcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.ComboBox Cbox2driverstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtrentID;
        private System.Windows.Forms.TextBox txtvehiclenumber;
        private System.Windows.Forms.Label label13;
    }
}