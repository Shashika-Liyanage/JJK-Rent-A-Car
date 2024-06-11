namespace JJK_Rent_A_Car
{
    partial class Dash_board
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnRentMan = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JJK_Rent_A_Car.Properties.Resources.logo_pic;
            this.pictureBox1.Location = new System.Drawing.Point(362, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1114, 402);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 20);
            this.btnMinimize.TabIndex = 107;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            this.btnRegistration.FlatAppearance.BorderSize = 2;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.Black;
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(60, 86);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnRegistration.Size = new System.Drawing.Size(208, 43);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "        REGISTRATION";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 2;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(60, 171);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(208, 43);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "         PAYMENT";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click_1);
            // 
            // btnRent
            // 
            this.btnRent.FlatAppearance.BorderSize = 2;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.ForeColor = System.Drawing.Color.Black;
            this.btnRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRent.Location = new System.Drawing.Point(60, 270);
            this.btnRent.Margin = new System.Windows.Forms.Padding(2);
            this.btnRent.Name = "btnRent";
            this.btnRent.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnRent.Size = new System.Drawing.Size(208, 43);
            this.btnRent.TabIndex = 5;
            this.btnRent.Text = "              RENT";
            this.btnRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click_1);
            // 
            // btnRentMan
            // 
            this.btnRentMan.FlatAppearance.BorderSize = 2;
            this.btnRentMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentMan.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentMan.ForeColor = System.Drawing.Color.Black;
            this.btnRentMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentMan.Location = new System.Drawing.Point(60, 368);
            this.btnRentMan.Margin = new System.Windows.Forms.Padding(2);
            this.btnRentMan.Name = "btnRentMan";
            this.btnRentMan.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnRentMan.Size = new System.Drawing.Size(208, 43);
            this.btnRentMan.TabIndex = 6;
            this.btnRentMan.Text = "  RENT MANAGEMENT";
            this.btnRentMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentMan.UseVisualStyleBackColor = true;
            this.btnRentMan.Click += new System.EventHandler(this.btnRentMan_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(60, 471);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(208, 43);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "         LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Dash_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(617, 550);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRentMan);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dash_board";
            this.Text = "Dash_board";
            this.Load += new System.EventHandler(this.Dash_board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRentMan;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRegistration;
    }
}