using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusEvents2
{
    //Class to be inherited for on-campus event classes
    abstract class Tickets
    {
        //Variables
        private double price;
        private string date;
        private string time;
        private string location;
        private string seat;

        //No-argument constructor
        public Tickets()
        {
        }

        //All-argument constructor
        public Tickets(double prc, string dte, string tme, string lctn, string st)
        {
            price = prc;
            date = dte;
            time = tme;
            location = lctn;
            seat = st;
        }

        //Partial-argument constructor
        public Tickets(double prc, string dte, string tme, string lctn)
        {
            price = prc;
            date = dte;
            time = tme;
            location = lctn;
        }

        //Properties
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
