using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JJK_Rent_A_Car
{
    public partial class Rent_Details : Form
    {
        public Rent_Details()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void lblCusID_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void rdbtndriver1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtndriver1.Enabled == true)
            {
                lbloption.Text = "WITH DRIVER";
            }
        }

        private void rdbtndriver2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtndriver2.Enabled == true)
            {
                lbloption.Text = "WITHOUT DRIVER";
            }
        }

        private void lbloption_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=AYUBO_DRIVE;Integrated Security=True";
            commandString = "UPDATE Rent SET driver_option = '" + lbloption.Text + "', rented_date = '" + DTPrenteddate.Text + "', returned_date = '" +
                DTPreturneddate.Text + "' , Customer_ID = '" + txtcustomerID 
                + "' where rent_ID = '" + txtrentID.Text + "'";


            if (MessageBox.Show("Are you sure you want to update this record ?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandString, conn);
            conn.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Rent Update Successfully");

            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=AYUBO_DRIVE;Integrated Security=True";
            commandString = "INSERT INTO Rent VALUES ('" + txtrentID.Text + "','" + lbloption.Text + "','" + DTPrenteddate.Text + "','"
                + DTPreturneddate.Text + "','" + txtcustomerID.Text + "')";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Rent Insert Succesfully");

            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash_board obj = new Dash_board();
            obj.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=AYUBO_DRIVE;Integrated Security=True";
            commandString = "DELETE Rent FROM Rent where Rent.rent_ID = '" + txtrentID.Text + "'";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandString, conn);
            conn.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Rent Delete successfully");
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtrentID.Text = "";
            lbloption.Text = "";
            rdbtndriver1.Text = "";
            rdbtndriver2.Text = "";
            DTPrenteddate.Text = "";
            DTPreturneddate.Text = "";
            txtcustomerID.Text = "";
            MessageBox.Show("Vehicle Details Clear");
        }

        private void DTPreturneddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Rent_Details_Load(object sender, EventArgs e)
        {

        }

        private void txtrentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
