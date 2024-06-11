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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCustomerReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer obj = new Customer();
            obj.Show();
        }

        private void btnDriverReg_Click(object sender, EventArgs e)
        {

            this.Hide();
            Driver obj = new Driver();
            obj.Show();
        }

        private void btnVehicleReg_Click(object sender, EventArgs e)
        {

            this.Hide();
            Vehicle obj = new Vehicle();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash_board obj = new Dash_board();
            obj.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_Type obj = new Vehicle_Type();
            obj.Show();
        }
    }
}
