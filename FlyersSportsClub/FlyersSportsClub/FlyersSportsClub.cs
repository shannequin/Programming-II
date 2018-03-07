using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyersSportsClub
{
    public partial class FlyersSportsClub : Form
    {
        public FlyersSportsClub()
        {
            InitializeComponent();
        }

        double total = 0;

        RentalItems memberRentalSkis = new RentalItems("Skis",40, 20);
        RentalItems memberRentalPoles = new RentalItems("Poles", 30, 15);
        RentalItems memberRentalBoots = new RentalItems("Boots", 20, 10);
        RentalItems memberRentalGoggles = new RentalItems("Goggles", 10, 5);
        RentalItems memberRentalGloves = new RentalItems("Gloves", 6, 3);
        RentalItems memberRentalEarmuffs = new RentalItems("Earmuffs", 2, 1);

        private void AddToListbox_CheckedChanged(object sender, EventArgs e)
        {
            listBoxItemize.Items.Clear();

            if (checkBoxSkis.Checked)
            {
                total += memberRentalSkis.MemberPrice;
                listBoxItemize.Items.Add(checkBoxSkis.Text + " " + memberRentalSkis.MemberPrice.ToString("C"));
            }

            if (checkBoxPoles.Checked)
            {
                total += memberRentalPoles.MemberPrice;
                listBoxItemize.Items.Add(checkBoxPoles.Text + " " + memberRentalPoles.MemberPrice.ToString("C"));
            }

            if (checkBoxBoots.Checked)
            {
                total += memberRentalBoots.MemberPrice;
                listBoxItemize.Items.Add(checkBoxBoots.Text + " " + memberRentalBoots.MemberPrice.ToString("C"));
            }

            if (checkBoxGoggles.Checked)
            {
                total += memberRentalGoggles.MemberPrice;
                listBoxItemize.Items.Add(checkBoxGoggles.Text + " " + memberRentalGoggles.MemberPrice.ToString("C"));
            }

            if (checkBoxGloves.Checked)
            {
                total += memberRentalGloves.MemberPrice;
                listBoxItemize.Items.Add(checkBoxGloves.Text + " " + memberRentalGloves.MemberPrice.ToString("C"));
            }

            if (checkBoxEarmuffs.Checked)
            {
                total += memberRentalEarmuffs.MemberPrice;
                listBoxItemize.Items.Add(checkBoxEarmuffs.Text + " " + memberRentalEarmuffs.MemberPrice.ToString("C"));
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool valid = false;
            valid = ValidateInput();

            if (valid)
            {
                string items = "";
                foreach (string i in listBoxItemize.Items)
                {
                    items += i + " \n";
                }

                MessageBox.Show("Total due: " + total.ToString("C") + " \n\n" + items);
            }
            else
            {
                MessageBox.Show("Please provide information for all fields.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            checkBoxSkis.Checked = false;
            checkBoxPoles.Checked = false;
            checkBoxBoots.Checked = false;
            checkBoxGoggles.Checked = false;
            checkBoxGloves.Checked = false;
            checkBoxEarmuffs.Checked = false;
            listBoxItemize.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FAQ\n\n1. How do I skii?\n     - Pizza / French Fry\n\n2. Why do people skii?\n     -Fun?\n\n3. What if there is a bear?\n     - Skii faster!");
        }

        public bool ValidateInput()
        {
            bool valid = false;

            if (textBoxFirstName.Text != "")
            {
                labelFirstName.Font = new Font(labelFirstName.Font, FontStyle.Regular);

                if (textBoxLastName.Text != "")
                {
                    labelLastName.Font = new Font(labelLastName.Font, FontStyle.Regular);

                    if (textBoxPhone.Text != "" || textBoxPhone.Text.Length == 10)
                    {
                        labelPhone.Font = new Font(labelPhone.Font, FontStyle.Regular);

                        if (textBoxMemberNo.Text != "")
                        {
                            labelMemberNo.Font = new Font(labelMemberNo.Font, FontStyle.Regular);

                            valid = true;
                        }
                        else
                        {
                            labelMemberNo.Font = new Font(labelMemberNo.Font, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelPhone.Font = new Font(labelPhone.Font, FontStyle.Bold);
                    }
                }
                else
                {
                    labelLastName.Font = new Font(labelLastName.Font, FontStyle.Bold);
                }
            }
            else
            {
                labelFirstName.Font = new Font(labelFirstName.Font, FontStyle.Bold);
            }

            return valid;
        }
     }
}
