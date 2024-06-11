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
    public partial class Vehicle : Form
    {
        public Vehicle()
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
            cmd = new SqlCommand("Select * from Vehicle", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView_Vehicle.DataSource = dt;


        }
        private void NClear()
        {
            txtvehicleID.Text = txtvehicletype.Text = txtownername.Text = txtownercontact.Text = txtvehiclenumber.Text = 
                txtperdaycharge.Text = txtperweekcharge.Text = txtpermonthcharge.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_Type obj = new Vehicle_Type();
            obj.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration obj = new Registration();
            obj.Show();
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtvehicleID.Text) || String.IsNullOrEmpty(txtvehicletype.Text) || String.IsNullOrEmpty(txtownername.Text) ||
                String.IsNullOrEmpty(txtownercontact.Text) || String.IsNullOrEmpty(txtvehiclenumber.Text) || String.IsNullOrEmpty(txtperdaycharge.Text) ||
              String.IsNullOrEmpty(txtperweekcharge.Text) || String.IsNullOrEmpty(txtpermonthcharge.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update Vehicle set vehicle_ID = @vehicle_ID, vehicle_type = @vehicle_type, owner_name = @owner_name, owner_contact = @owner_contact," +
                    " vehicle_number = @vehicle_number, per_day_charge = @per_day_charge, per_week_charge = @per_week_charge, per_month_charge = @per_month_charge  where vehicle_ID = @vehicle_ID", con);


                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Update Successfully");
                NClear();
            }
        }
       
        private void Vehicle_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void dataGridView_Vehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView_Vehicle.Rows[index];
            txtvehicleID.Text = selectedrow.Cells[1].Value.ToString();
            txtvehicletype.Text = selectedrow.Cells[2].Value.ToString();
            txtownername.Text = selectedrow.Cells[3].Value.ToString();
            txtownercontact.Text = selectedrow.Cells[4].Value.ToString();
            txtvehiclenumber.Text = selectedrow.Cells[5].Value.ToString();
            txtperdaycharge.Text = selectedrow.Cells[6].Value.ToString();
            txtperweekcharge.Text = selectedrow.Cells[7].Value.ToString();
            txtpermonthcharge.Text = selectedrow.Cells[7].Value.ToString();
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("vehicle_ID", txtvehicleID.Text);
            cmd.Parameters.AddWithValue("vehicle_type", txtvehicletype.Text);
            cmd.Parameters.AddWithValue("owner_name", txtownername.Text);
            cmd.Parameters.AddWithValue("owner_contact", txtownercontact.Text);
            cmd.Parameters.AddWithValue("vehicle_number", txtvehiclenumber.Text);
            cmd.Parameters.AddWithValue("per_day_charge", txtperdaycharge.Text);
            cmd.Parameters.AddWithValue("per_week_charge", txtperweekcharge.Text);
            cmd.Parameters.AddWithValue("per_month_charge", txtpermonthcharge.Text);


        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtvehicleID.Text) || String.IsNullOrEmpty(txtvehicletype.Text) || String.IsNullOrEmpty(txtownername.Text) ||
              String.IsNullOrEmpty(txtownercontact.Text) || String.IsNullOrEmpty(txtvehiclenumber.Text) || String.IsNullOrEmpty(txtperdaycharge.Text) ||
             String.IsNullOrEmpty(txtperweekcharge.Text) || String.IsNullOrEmpty(txtpermonthcharge.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into Vehicle Values (@vehicle_ID, @vehicle_type, @owner_name, @owner_contact, " +
                    "@vehicle_number, @per_day_charge,  @per_week_charge, @per_month_charge)", con);

                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Added Successfully");
                NClear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete From Vehicle where vehicle_ID = @vehicle_ID", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Load_data();
            MessageBox.Show("Record Delete Successfully");
            NClear();
        }
    }
}
