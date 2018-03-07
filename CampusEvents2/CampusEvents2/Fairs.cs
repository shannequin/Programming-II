using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusEvents2
{
    class Fairs : Tickets
    {
        //Variables
        private string holiday;
        private double guests = 5.0;
        private double mealVoucher = 5.0;

        //No-argument constructor
        public Fairs()
            :base()
        {
        }

        //All-argument constructor
        public Fairs(double prc, string dte, string tme, string lctn, string st, string hldy, double gst, double mlvchr)
            :base(prc, dte, tme, lctn, st)
        {
            holiday = hldy;
            guests = gst;
            mealVoucher = mlvchr;
        }

        //Partial-argument constructor
        public Fairs(double prc, string dte, string tme, string lctn, string hldy)
            :base(prc, dte, tme, lctn)
        {
            holiday = hldy;
        }

        //Properies
        public string Holiday
        {
            get { return holiday; }
            set { holiday = value; }
        }
        public double Guests
        {
            get { return guests; }
            set { guests = value; }
        }

        public double MealVoucher
        {
            get { return mealVoucher; }
            set { mealVoucher = value; }
        }
    }
}
