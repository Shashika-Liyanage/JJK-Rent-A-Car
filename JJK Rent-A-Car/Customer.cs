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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EK4BSML;Initial Catalog=JJK_RENT_A_CAR;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        private void Load_data()
        {
            cmd = new SqlCommand("Select * from Customer", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView_customer.DataSource = dt;


        }
        private void NClear()
        {
            txtcustomerID.Text = txtFname.Text = txtLname.Text = txtHouseNo.Text = txtlane.Text = txtcity.Text = lblGen.Text = txtEmail.Text = txtconNo1.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration obj = new Registration();
            obj.Show();
        }

       

        private void btnmale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (btnfemale.Enabled == true)
            {
                lblGen.Text = "Female";
            }
        }

        private void btnmale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btnmale.Enabled == true)
            {
                lblGen.Text = "Male";
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete From Customer where Customer_ID = @Customer_ID", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Load_data();
            MessageBox.Show("Record Delete Successfully");
            NClear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            

          

            
        }

        private void btnadd2_Click(object sender, EventArgs e)
        {
            
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void dataGridView_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView_customer.Rows[index];
            txtcustomerID.Text = selectedrow.Cells[1].Value.ToString();
            txtFname.Text = selectedrow.Cells[2].Value.ToString();
            txtLname.Text = selectedrow.Cells[3].Value.ToString();
            txtHouseNo.Text = selectedrow.Cells[4].Value.ToString();
            txtlane.Text = selectedrow.Cells[5].Value.ToString();
            txtcity.Text = selectedrow.Cells[6].Value.ToString();
            lblGen.Text = selectedrow.Cells[7].Value.ToString();
            txtEmail.Text = selectedrow.Cells[8].Value.ToString();
            txtconNo1.Text = selectedrow.Cells[9].Value.ToString();
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("Customer_ID", txtcustomerID.Text);
            cmd.Parameters.AddWithValue("First_name", txtFname.Text);
            cmd.Parameters.AddWithValue("Last_name", txtLname.Text);
            cmd.Parameters.AddWithValue("House_no", txtHouseNo.Text);
            cmd.Parameters.AddWithValue("Lane", txtlane.Text);
            cmd.Parameters.AddWithValue("City", txtcity.Text);
            cmd.Parameters.AddWithValue("Gender", lblGen.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Contact_No", txtconNo1.Text);
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcustomerID.Text) || String.IsNullOrEmpty(txtFname.Text) || String.IsNullOrEmpty(txtLname.Text) ||
                String.IsNullOrEmpty(txtHouseNo.Text) || String.IsNullOrEmpty(txtlane.Text) || String.IsNullOrEmpty(txtcity.Text) ||
               String.IsNullOrEmpty(lblGen.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtconNo1.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into Customer Values (@Customer_ID, @First_name, @Last_name, @House_no, @Lane, @City,  @Gender, @Email, @Contact_No)", con);
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
            if (String.IsNullOrEmpty(txtcustomerID.Text) || String.IsNullOrEmpty(txtFname.Text) || String.IsNullOrEmpty(txtLname.Text) || 
                String.IsNullOrEmpty(txtHouseNo.Text) || String.IsNullOrEmpty(txtlane.Text ) || String.IsNullOrEmpty(txtcity.Text) || 
              String.IsNullOrEmpty(lblGen.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtconNo1.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update Customer set Customer_ID = @Customer_ID, First_name = @First_name, Last_name = @Last_name, House_no = @House_no," +
                    " Lane = @Lane, City = @City, Gender = @Gender, Email = @Email, Contact_No = @Contact_No  where Customer_ID = @Customer_ID", con);

                
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Update Successfully");
                NClear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dash_board obj = new Dash_board();
            obj.Show();
        }
    }
}
