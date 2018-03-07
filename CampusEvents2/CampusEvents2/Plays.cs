using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusEvents2
{
    class Plays : Tickets
    {
        //Variables
        private string title;
        private double valet = 10.0;
        private double backstagePass = 10.0;
        private string[] availableSeats;
        private string[] mainAuditoriumSeating = new string[] { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
        private string[] outdoorAmpitheaterSeating = new string[] { "Table 1", "Table 2", "Talbe 3", "Table 4", "Table 5" };

        //No-argument constructor
        public Plays()
            :base()
        {
        }

        //All-argument constructor
        public Plays(double prc, string dte, string tme, string lctn, string st, string ttl, double vlt, double bckstgPss)
            :base(prc, dte, tme,lctn, st)
        {
            title = ttl;
            valet = vlt;
            backstagePass = bckstgPss;
        }

        //Partial-argument constructor
        public Plays(double prc, string dte, string tme, string lctn, string ttl)
            :base(prc, dte, tme, lctn)
        {
            title = ttl;
        }

        //Properies
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Valet
        {
            get { return valet; }
            set { valet = value; }
        }

        public double BackstagePass
        {
            get { return backstagePass; }
            set { backstagePass = value; }
        }

        public string[] MainAuditoriumSeating
        {
            get { return mainAuditoriumSeating; }
            set { mainAuditoriumSeating = value; }
        }

        public string[] OutdoorAmpitheaterSeating
        {
            get { return outdoorAmpitheaterSeating; }
            set { outdoorAmpitheaterSeating = value; }
        }
    }
}
