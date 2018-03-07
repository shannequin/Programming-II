using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class BodyMassIndexCalculator
    {
        private double pounds;
        private double inches;
        private double kilograms;
        private double meters;
        private double bmi;

        public BodyMassIndexCalculator()
        {
        }
        
        public double Pounds
        {
            get
            {
                return pounds;
            }
            set
            {
                pounds = value;
            }
        }

        public double Inches
        {
            get
            {
                return inches;
            }
            set
            {
                inches = value;
            }
        }

        public double Kilograms
        {
            get
            {
                return kilograms;
            }
            set
            {
                kilograms = value;
            }
        }

        public double Meters
        {
            get
            {
                return meters;
            }
            set
            {
                meters = value;
            }
        }

        public double BMI
        {
            get
            {
                return bmi;
            }
        }

        public void CalculateBMIImperial()
        {
            bmi = pounds / Math.Pow(inches, 2) * 703;
        }

        public void CalculateBMIMetric()
        {
            bmi = kilograms / Math.Pow(meters, 2);
        }

        public string idealBMI()
        {
            if(bmi < 18.5)
            {
                return "You are under your ideal weight for your height";
            }
            else if(bmi > 25)
            {
                return "You are over your ideal weight for your height.";
            }
            else
            {
                return "You are an ideal weight for your height.";
            }
        }
    }
}
