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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        SqlConnection con = new SqlConnection ("Data Source=DESKTOP-EK4BSML;Initial Catalog=JJK_RENT_A_CAR;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        private void Load_data()
        {
            cmd = new SqlCommand ("Select * from Payment", con);
            da = new SqlDataAdapter ();
            da.SelectCommand = cmd;
            dt = new DataTable ();
            dt.Clear ();
            da.Fill(dt);
            dataGridView_Payment.DataSource = dt;


        }
        private void NClear()
        {
            txtpaymentID.Text = txtamount.Text = txtpaymentmethod.Text = txtpaydate.Text = txtcustomerID.Text = txtrentID.Text = ""; 
        }



        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpaymentID.Text) || String.IsNullOrEmpty(txtamount.Text) || String.IsNullOrEmpty(txtpaymentmethod.Text) ||
                String.IsNullOrEmpty(txtpaydate.Text) || String.IsNullOrEmpty(txtcustomerID.Text) || String.IsNullOrEmpty(txtrentID.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into Payment Values (@Payment_ID, @Amount, @Method, @Pay_date, @Customer_ID, @Rent_ID)", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Added Successfully");
                NClear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpaymentID.Text) || String.IsNullOrEmpty(txtamount.Text) || String.IsNullOrEmpty(txtpaymentmethod.Text) ||
               String.IsNullOrEmpty(txtpaydate.Text) || String.IsNullOrEmpty(txtcustomerID.Text) || String.IsNullOrEmpty(txtrentID.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update Payment set Payment_ID = @Payment_ID, Amount = @Amount, Method = @Method, Pay_Date = @Pay_date," +
                    " Customer_ID = @Customer_ID, Rent_ID = @Rent_ID where Payment_ID = @Payment_ID", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Update Successfully");
                NClear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete From Payment where Payment_ID = @Payment_ID", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Load_data();
            MessageBox.Show("Record Delete Successfully");
            NClear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash_board obj = new Dash_board();
            obj.Show();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Load_data();

        }

        private void dataGridView_Payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView_Payment.Rows[index];
            txtpaymentID.Text = selectedrow.Cells[1].Value.ToString();
            txtamount.Text = selectedrow.Cells[2].Value.ToString();
            txtpaymentmethod.Text = selectedrow.Cells[3].Value.ToString();
            txtpaydate.Text = selectedrow.Cells[4].Value.ToString();
            txtcustomerID.Text = selectedrow.Cells[5].Value.ToString();
            txtrentID.Text = selectedrow.Cells[6].Value.ToString();

        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("Payment_ID" ,txtpaymentID.Text);
            cmd.Parameters.AddWithValue("Amount", txtamount.Text);
            cmd.Parameters.AddWithValue("Method", txtpaymentmethod.Text);
            cmd.Parameters.AddWithValue("Pay_date", txtpaydate.Text);
            cmd.Parameters.AddWithValue("Customer_ID", txtcustomerID.Text);
            cmd.Parameters.AddWithValue("Rent_ID", txtrentID.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NClear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Load_data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
