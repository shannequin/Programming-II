using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class StadiumSeating : Form
    {
        public StadiumSeating()
        {
            InitializeComponent();
        }

        private void StadiumSeating_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double classAPrice = 15, classBPrice = 12, classCPrice = 9;
            int classATickets, classBTickets, classCTickets;
            double classARevenue, classBRevenue, classCRevenue, totalRevenue;

            while(int.TryParse(txtClassATickets.Text, out classATickets) == false)
            {
                MessageBox.Show("Enter a numeric value for Class A tickets.");
                txtClassATickets.Text = "0";
                txtClassATickets.Focus();
            }

            while(int.TryParse(txtClassBTickets.Text, out classBTickets) == false)
            {
                MessageBox.Show("Enter a numeric value for Class B tickets.");
                txtClassBTickets.Text = "0";
                txtClassBTickets.Focus();
            }

            while(int.TryParse(txtClassCTickets.Text, out classCTickets) == false)
            {
                MessageBox.Show("Enter a numeric value for Class C tickets.");
                txtClassCTickets.Text = "0";
                txtClassCTickets.Focus();
            }

            classARevenue = classAPrice * classATickets;
            classBRevenue = classBPrice * classBTickets;
            classCRevenue = classCPrice * classCTickets;
            totalRevenue = classARevenue + classBRevenue + classCRevenue;

            txtClassARevenue.Text = classARevenue.ToString("C");
            txtClassBRevenue.Text = classBRevenue.ToString("C");
            txtClassCRevenue.Text = classCRevenue.ToString("C");
            txtTotalRevenue.Text = totalRevenue.ToString("C");


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassATickets.Text = "0";
            txtClassBTickets.Text = "0";
            txtClassCTickets.Text = "0";
            txtClassARevenue.Text = "$0.00";
            txtClassBRevenue.Text = "$0.00";
            txtClassCRevenue.Text = "$0.00";
            txtTotalRevenue.Text = "$0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
