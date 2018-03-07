using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusEvents2
{
    public partial class CampusEvents : Form
    {
        public CampusEvents()
        {
            InitializeComponent();
        }

        Plays bookOfMormon = new Plays(40.0, "June 15, 2018", "7:00 PM", "Main Auditoriium", "The Book of Mormon");
        Plays cannibal = new Plays(30.0, "June 20, 2018", "3:00 PM", "Outdoor Ampitheater", "Cannibal");
        Fairs independenceDay = new Fairs(10.0, "July 4, 2018", "10:00 AM to 10:00 PM", "The Square", "Independence Day Fair");
        Fairs christmas = new Fairs(20.0, "December 20, 2018", "10:00 AM to 6:00 PM", "Outdoor Ampitheater", "Christmas Fair");
        FootballGames ducks = new FootballGames(5.0, "September 1, 2018", "7:00 PM", "Away Game", "Panthers vs. Ducks");
        FootballGames lemmings = new FootballGames(5.0, "September 10, 2018", "7:00 PM", "Home Game", "Panthers vs. Lemmings");

        double ticketTotal = 0;
        double extraPrice = 0;

        private void buttonEventType_Click(object sender, EventArgs e)
        {
            HideGroupBoxInfo();
            groupBoxEventNames.Visible = true;

            Button b = (Button)sender;

            switch (b.Name)
            {
                case "buttonPlays":
                    radioButtonEvent1.Text = bookOfMormon.Title;
                    radioButtonEvent1.Focus();
                    radioButtonEvent2.Text = cannibal.Title;
                    break;
                case "buttonFairs":
                    radioButtonEvent1.Text = independenceDay.Holiday;
                    radioButtonEvent1.Focus();
                    radioButtonEvent2.Text = christmas.Holiday;
                    break;
                case "buttonFootball":
                    radioButtonEvent1.Text = ducks.Teams;
                    radioButtonEvent1.Focus();
                    radioButtonEvent2.Text = lemmings.Teams;
                    break;
            }
        }

        private void radioButtonEventName_CheckedChanged(object sender, EventArgs e)
        {
            ShowGroupBoxInfo();

            ticketTotal = 0;

            RadioButton b = (RadioButton)sender;

            if (radioButtonEvent1.Checked)
            {
                switch (b.Text)
                {
                    case "The Book of Mormon":
                        labelEventName.Text = bookOfMormon.Title;
                        labelEventLocation.Text = bookOfMormon.Location;
                        labelDateTime.Text = bookOfMormon.Date + " at " + bookOfMormon.Time;
                        labelPrice.Text = bookOfMormon.Price.ToString("C");
                        checkBoxExtra1.Text = bookOfMormon.Valet.ToString("C") + " Valet";
                        checkBoxExtra2.Text = bookOfMormon.BackstagePass.ToString("C") + " Backstage Pass";
                        foreach (string s in bookOfMormon.MainAuditoriumSeating)
                        {
                            listBoxSeatSelection.Items.Add(s);
                        }
                        listBoxSeatSelection.SelectedIndex = 0;
                        ticketTotal = bookOfMormon.Price;
                        break;
                    case "Independence Day Fair":
                        labelEventName.Text = independenceDay.Holiday;
                        labelEventLocation.Text = independenceDay.Location;
                        labelDateTime.Text = independenceDay.Date + " from " + independenceDay.Time;
                        labelPrice.Text = independenceDay.Price.ToString("C");
                        checkBoxExtra1.Text = independenceDay.Guests.ToString("C") + " Guests";
                        checkBoxExtra2.Text = independenceDay.MealVoucher.ToString("C") + " Meal Voucher";
                        ticketTotal = independenceDay.Price;
                        break;
                    case "Panthers vs. Ducks":
                        labelEventName.Text = ducks.Teams;
                        labelEventLocation.Text = ducks.Location;
                        labelDateTime.Text = ducks.Date + " at " + ducks.Time;
                        labelPrice.Text = ducks.Price.ToString("C");
                        checkBoxExtra1.Text = ducks.Parking.ToString("C") + " Parking";
                        checkBoxExtra2.Text = ducks.Consessions.ToString("C") + " Consessions";
                        ticketTotal = ducks.Price;
                        break;
                }
            }

            else if (radioButtonEvent2.Checked)
            {
                switch (b.Text)
                {
                    case "Cannibal":
                        labelEventName.Text = cannibal.Title;
                        labelEventLocation.Text = cannibal.Location;
                        labelDateTime.Text = cannibal.Date + " at " + cannibal.Time;
                        labelPrice.Text = cannibal.Price.ToString("C");
                        checkBoxExtra1.Text = cannibal.Valet.ToString("C") + " Valet";
                        checkBoxExtra2.Text = cannibal.BackstagePass.ToString("C") + " Backstage Pass";
                        foreach (string s in cannibal.OutdoorAmpitheaterSeating)
                        {
                            listBoxSeatSelection.Items.Add(s);
                        }
                        listBoxSeatSelection.SelectedIndex = 0;
                        ticketTotal = cannibal.Price;
                        break;
                    case "Christmas Fair":
                        labelEventName.Text = christmas.Holiday;
                        labelEventLocation.Text = christmas.Location;
                        labelDateTime.Text = christmas.Date + " from " + christmas.Time;
                        labelPrice.Text = christmas.Price.ToString("C");
                        checkBoxExtra1.Text = christmas.Guests.ToString("C") + " Guests";
                        checkBoxExtra2.Text = christmas.MealVoucher.ToString("C") + " Meal Voucher";
                        ticketTotal = christmas.Price;
                        break;
                    case "Panthers vs. Lemmings":
                        labelEventName.Text = lemmings.Teams;
                        labelEventLocation.Text = lemmings.Location;
                        labelDateTime.Text = lemmings.Date + " at " + lemmings.Time;
                        labelPrice.Text = lemmings.Price.ToString("C");
                        checkBoxExtra1.Text = lemmings.Parking.ToString("C") + " Parking";
                        checkBoxExtra2.Text = lemmings.Consessions.ToString("C") + " Consessions";
                        ticketTotal = lemmings.Price;
                        break;
                }
            }
        }

        private void checkBoxExtra_CheckedChanged(object sender, EventArgs e)
        {
            extraPrice = GetExtraPrice();
        }

        private double GetExtraPrice()
        {
            double price = 0;

            if (checkBoxExtra1.Checked)
            {
                if (radioButtonEvent1.Text == "The Book of Mormon")
                {
                    price += bookOfMormon.Valet;
                }
                else if(radioButtonEvent1.Text == "Independence Day Fair")
                {
                    price += independenceDay.Guests;
                }
                else if (radioButtonEvent1.Text == "Panthers vs. Ducks")
                {
                    price += ducks.Parking;
                }
            }

            if (checkBoxExtra2.Checked)
            {
                if (radioButtonEvent2.Text == "Cannibal")
                {
                    price += cannibal.Valet;
                }
                else if (radioButtonEvent2.Text == "Christmas Fair")
                {
                    price += christmas.Guests;
                }
                else if (radioButtonEvent2.Text == "Panthers vs. Lemmings")
                {
                    price += lemmings.Parking;
                }
            }

            return price;
        }

        public void HideGroupBoxInfo()
        {
            groupBoxEventInfo.Hide();
            radioButtonEvent1.Checked = false;
            radioButtonEvent2.Checked = false;
            buttonGetTicket.Hide();
        }

        public void ShowGroupBoxInfo()
        {
            groupBoxEventInfo.Show();
            buttonGetTicket.Show();
            listBoxSeatSelection.Items.Clear();
            checkBoxExtra1.Checked = false;
            checkBoxExtra2.Checked = false;
        }

        private void buttonGetTicket_Click(object sender, EventArgs e)
        {
            string showTicketInfo = labelEventName.Text + "\n\n" + labelEventLocation.Text + "\n\n" + labelDateTime.Text;
            
            if (checkBoxExtra1.Checked)
            {
                showTicketInfo += "\n\n" + checkBoxExtra1.Text;
            }

            if (checkBoxExtra2.Checked)
            {
                showTicketInfo += "\n\n" + checkBoxExtra2.Text;
            }

            if (labelEventName.Text == "The Book of Mormon" || labelEventName.Text == "Cannibal")
            {
                showTicketInfo += "\n\nSeat: " + listBoxSeatSelection.SelectedItem;
            }

            showTicketInfo += "\n\nTotal: " + (ticketTotal + extraPrice).ToString("C");

            MessageBox.Show(showTicketInfo);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
