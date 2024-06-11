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
    public partial class Rent_Management : Form
    {
        public Rent_Management()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private int driverPrice;
        int dailyPrice = 2000;
        int WeeklyPrice = 10000;
        int monthlyprice = 50000;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash_board obj = new Dash_board();
            obj.Show();
        }

        private void Cbox1vehicletype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox1vehicletype.SelectedItem == "Small car")
            {

                dailyPrice = 3500;
                txtdailyprice.Text = dailyPrice.ToString();

            }
            else if (Cbox1vehicletype.SelectedItem == "Sedan car")
            {

                dailyPrice = 5000;
                txtdailyprice.Text = dailyPrice.ToString();

            }
            else if (Cbox1vehicletype.SelectedItem == "SUVs")
            {

                dailyPrice = 5500;
                txtdailyprice.Text = dailyPrice.ToString();

            }
            else if (Cbox1vehicletype.SelectedItem == "Jeep")
            {

                dailyPrice = 6000;
                txtdailyprice.Text = dailyPrice.ToString();

            }
            else if (Cbox1vehicletype.SelectedItem == "7-Seater van")
            {

                dailyPrice = 7500;
                txtdailyprice.Text = dailyPrice.ToString();

            }
            else if (Cbox1vehicletype.SelectedItem == "Commuter van")
            {

                dailyPrice = 8000;
                txtdailyprice.Text = dailyPrice.ToString();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            DateTime starttime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime endtime = Convert.ToDateTime(dateTimePicker2.Text);

            int timeframe = endtime.Subtract(starttime).Days;
            int weekTime = timeframe / 7;
            int monthTime = timeframe / 30;
            int remWeekTime = timeframe % 7;
            int remMonthTime = timeframe % 30;
            int remMonthWeeks = remMonthTime / 7;
            int remweekDays = remMonthWeeks % 7;

            if (endtime >= starttime)
            {
                txtdaycount.Text = timeframe.ToString();
                txtweekcount.Text = weekTime.ToString();
                txtmonthcount.Text = monthTime.ToString();
            }
            if (timeframe < 7)
            {
                int price = (timeframe * dailyPrice) + (driverPrice * timeframe);
                txttotrentcost.Text = price.ToString();
            }
            else if (timeframe >= 7 && timeframe <= 30)
            {
                int price = (weekTime * WeeklyPrice) + (remWeekTime * dailyPrice) + (driverPrice * timeframe);
                txttotrentcost.Text = price.ToString();
            }
            else if (timeframe > 30)
            {
                int price = (monthTime * monthlyprice) + (weekTime * WeeklyPrice) + (remWeekTime * dailyPrice) + (driverPrice * timeframe);
                txttotrentcost.Text = price.ToString();
            }
            string Rent_ID = txtrentID.Text;
            string Customer_ID = txtcustomerID.Text;
            string Start_date = dateTimePicker1.Text;
            string End_date = dateTimePicker2.Text;
            string Vehicle_type = Cbox1vehicletype.Text;
            string Vehicle_number = txtvehiclenumber.Text;
            string Driver_status = Cbox2driverstatus.Text;
            int Total_Rent = int.Parse(txttotrentcost.Text);
            MessageBox.Show("Rend ID = " + Rent_ID + ", \n customer ID = " + Customer_ID + ", \n Start date = " + Start_date + ", \n " +
                "End date = " + End_date + ", \n vehicle type = "
                + Vehicle_type + ", \n Driver status = " + Driver_status + ", \n Total rent cost = " + Total_Rent);

        }

        private void Cbox2driverstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox2driverstatus.SelectedItem == "With driver")
            {
                driverPrice = 2500;
                txttotdrivercost.Text = driverPrice.ToString();
            }
            else
            {
                driverPrice = 0;
                txttotdrivercost.Text = driverPrice.ToString();
            }
        }

        private void Rent_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
