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
    public partial class Vehicle_Type : Form
    {
        public Vehicle_Type()
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
            cmd = new SqlCommand("Select * from Vehicle_type", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView_VehicleType.DataSource = dt;


        }
        private void NClear()
        {
            txtvehicletypeID.Text = txtvehicleType.Text = txtfualtype.Text = txtseatnumber.Text = txtcolor.Text =
                txtbrand.Text =  "";
        }
        private void Vehicle_Type_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash_board obj = new Dash_board();
            obj.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtvehicletypeID.Text) || String.IsNullOrEmpty(txtvehicleType.Text) || String.IsNullOrEmpty(txtfualtype.Text) ||
               String.IsNullOrEmpty(txtseatnumber.Text) || String.IsNullOrEmpty(txtcolor.Text) || String.IsNullOrEmpty(txtbrand.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into Vehicle_type Values (@Vehicle_type_ID, @Vehicle_type, @Fual_type, @Number_of_seat, " +
                    "@Color, @Brand)", con);

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
            if (String.IsNullOrEmpty(txtvehicletypeID.Text) || String.IsNullOrEmpty(txtvehicleType.Text) || String.IsNullOrEmpty(txtfualtype.Text) ||
               String.IsNullOrEmpty(txtseatnumber.Text) || String.IsNullOrEmpty(txtcolor.Text) || String.IsNullOrEmpty(txtbrand.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update Vehicle_type set Vehicle_type_ID = @Vehicle_type_ID, Vehicle_type = @Vehicle_type, Fual_type = @Fual_type, Number_of_seat = @Number_of_seat," +
                    " Color = @Color, Brand = @Brand where Vehicle_type_ID = @Vehicle_type_ID", con);


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
            cmd = new SqlCommand("Delete From Vehicle_type where Vehicle_type_ID = @Vehicle_type_ID", con);
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

        private void dataGridView_VehicleType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView_VehicleType.Rows[index];
            txtvehicletypeID.Text = selectedrow.Cells[1].Value.ToString();
            txtvehicleType.Text = selectedrow.Cells[2].Value.ToString();
            txtfualtype.Text = selectedrow.Cells[3].Value.ToString();
            txtseatnumber.Text = selectedrow.Cells[4].Value.ToString();
            txtcolor.Text = selectedrow.Cells[5].Value.ToString();
            txtbrand.Text = selectedrow.Cells[6].Value.ToString();
          
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("Vehicle_type_ID", txtvehicletypeID.Text);
            cmd.Parameters.AddWithValue("Vehicle_type", txtvehicleType.Text);
            cmd.Parameters.AddWithValue("Fual_type", txtfualtype.Text);
            cmd.Parameters.AddWithValue("Number_of_seat", txtseatnumber.Text);
            cmd.Parameters.AddWithValue("Color", txtcolor.Text);
            cmd.Parameters.AddWithValue("Brand", txtbrand.Text);
            

        }
    }
}
