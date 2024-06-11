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
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "shashika" && txtpassword.Text == "shashi123")
            {
                MessageBox.Show("Login successfully.Welcome to JJK-Rent-A-Car.");
                this.Hide();
                About_service obj = new About_service();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid successfully.Please try again");
                txtusername.Clear();
                txtpassword.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxAdminShow_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtconpsw_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
