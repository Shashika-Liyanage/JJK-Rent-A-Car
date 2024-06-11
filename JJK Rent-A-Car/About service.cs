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
    public partial class About_service : Form
    {
        public About_service()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash_board obj = new Dash_board();
            obj.Show();
        }

        private void About_service_Load(object sender, EventArgs e)
        {

        }
    }
}
