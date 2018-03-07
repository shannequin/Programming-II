using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
            ClearInfo();
        }

        BodyMassIndexCalculator bodyMassIndex = new BodyMassIndexCalculator();

        public void ClearInfo()
        {
            radioButtonImperial.Focus();
            textBoxWeight.Text = "0";
            textBoxHeight.Text = "0";
        }

        public void getWeightInput()
        {
            double w = 0;

            if (radioButtonImperial.Checked)
            {
                if (Double.TryParse(textBoxWeight.Text, out w))
                {
                    bodyMassIndex.Pounds = w;
                }
                else
                {
                    textBoxWeight.Text = "0";
                    MessageBox.Show("Weight must be a number.");
                }
            }

            if (radioButtonMetric.Checked)
            {
                if(double.TryParse(textBoxWeight.Text, out w))
                {
                    bodyMassIndex.Kilograms = w;
                }
                else
                {
                    textBoxWeight.Text = "0";
                    MessageBox.Show("Weight must be a number.");
                }
            }
        }

        public void getHeightInput()
        {
            double h = 0;

            if (radioButtonImperial.Checked)
            {
                if (Double.TryParse(textBoxHeight.Text, out h))
                {
                    bodyMassIndex.Inches = h;
                }
                else
                {
                    textBoxHeight.Text = "0";
                    MessageBox.Show("Height must be a number.");
                }
            }

            if (radioButtonMetric.Checked)
            {
                if (double.TryParse(textBoxHeight.Text, out h))
                {
                    bodyMassIndex.Meters = h;
                }
                else
                {
                    textBoxHeight.Text = "0";
                    MessageBox.Show("Height must be a number.");
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            getWeightInput();
            getHeightInput();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonImperial.Checked)
            {
                labelWeightUnits.Text = "Pounds";
                labelHeightUnits.Text = "Inches";
            }

            if (radioButtonMetric.Checked)
            {
                labelWeightUnits.Text = "Kilograms";
                labelHeightUnits.Text = "Meters";
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonImperial.Checked)
                {
                    bodyMassIndex.CalculateBMIImperial();
                }

                if (radioButtonMetric.Checked)
                {
                    bodyMassIndex.CalculateBMIMetric();
                }

                string msg = "BMI: " + Math.Round(bodyMassIndex.BMI, 2) + "\n\n" + bodyMassIndex.idealBMI();
                MessageBox.Show(msg);
            }
            catch
            {
                MessageBox.Show("An error occured - Cannot calculate BMI.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }   
}
