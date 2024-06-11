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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
            this.CenterToScreen();

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=JJK_RENT_A_CAR;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        private void Load_data()
        {
            cmd = new SqlCommand("Select * from Driver", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView_Driver.DataSource = dt;


        }
        private void NClear()
        {
            txtdriverID.Text = txtFname.Text = txtLname.Text = txtHouseNo.Text = txtlane.Text = txtcity.Text = txtconNo1.Text =  "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration obj = new Registration();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdriverID.Text) || String.IsNullOrEmpty(txtFname.Text) || String.IsNullOrEmpty(txtLname.Text) ||
                String.IsNullOrEmpty(txtHouseNo.Text) || String.IsNullOrEmpty(txtlane.Text) || String.IsNullOrEmpty(txtcity.Text) ||
              String.IsNullOrEmpty(txtconNo1.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update Driver set Driver_ID = @Driver_ID, First_name = @First_name, Last_name = @Last_name, House_no = @House_no," +
                    " Lane = @Lane, City = @City, Contact_No = @Contact_No  where Driver_ID = @Driver_ID", con);


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
            cmd = new SqlCommand("Delete From Driver where Driver_ID = @Driver_ID", con);
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

        private void btnadd1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void txtdriverID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Driver_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void lblDLasName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Driver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView_Driver.Rows[index];
            txtdriverID.Text = selectedrow.Cells[1].Value.ToString();
            txtFname.Text = selectedrow.Cells[2].Value.ToString();
            txtLname.Text = selectedrow.Cells[3].Value.ToString();
            txtHouseNo.Text = selectedrow.Cells[4].Value.ToString();
            txtlane.Text = selectedrow.Cells[5].Value.ToString();
            txtcity.Text = selectedrow.Cells[6].Value.ToString();
            txtconNo1.Text = selectedrow.Cells[7].Value.ToString();
            
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("Driver_ID", txtdriverID.Text);
            cmd.Parameters.AddWithValue("First_name", txtFname.Text);
            cmd.Parameters.AddWithValue("Last_name", txtLname.Text);
            cmd.Parameters.AddWithValue("House_no", txtHouseNo.Text);
            cmd.Parameters.AddWithValue("Lane", txtlane.Text);
            cmd.Parameters.AddWithValue("City", txtcity.Text);
            cmd.Parameters.AddWithValue("Contact_No", txtconNo1.Text);
          
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdriverID.Text) || String.IsNullOrEmpty(txtFname.Text) || String.IsNullOrEmpty(txtLname.Text) ||
               String.IsNullOrEmpty(txtHouseNo.Text) || String.IsNullOrEmpty(txtlane.Text) || String.IsNullOrEmpty(txtcity.Text) ||
              String.IsNullOrEmpty(txtconNo1.Text) )
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into Driver Values (@Driver_ID, @First_name, @Last_name, @House_no, " +
                    "@Lane, @City,  @Contact_No)", con);

                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Added Successfully");
                NClear();
            }
        }
    }
    
}
