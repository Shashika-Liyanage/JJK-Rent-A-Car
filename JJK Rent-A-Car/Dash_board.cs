using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJK_Rent_A_Car
{
    public partial class Dash_board : Form
    {
        public Dash_board()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_page obj = new Login_page();
            obj.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration obj = new Registration();
            obj.Show();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Payment obj = new Payment();
            obj.Show();
        }

        private void btnRent_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rent_Details obj = new Rent_Details();
            obj.Show();
        }

        private void btnRentMan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rent_Management obj = new Rent_Management();
            obj.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Log Out?";
            string title = "Log Out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Login_page Login = new Login_page();
                Login.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void Dash_board_Load(object sender, EventArgs e)
        {

        }
    }
}
