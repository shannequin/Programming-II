using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusEvents2
{
    class FootballGames : Tickets
    {
        //Variables
        private string teams;
        private double parking = 5.0;
        private double concsessions = 5.0;

        //No-argument constructor
        public FootballGames()
            :base()
        {
        }

        //All-argument constructor
        public FootballGames(double prc, string dte, string tme, string lctn, string st, string tms, double prkng, double cns)
            :base(prc, dte, tme,lctn, st)
        {
            teams = tms;
            parking = prkng;
            concsessions = cns;
        }

        //Partial-argument constructor
        public FootballGames(double prc, string dte, string tme, string lctn, string tms)
            :base(prc, dte, tme, lctn)
        {
            teams = tms;
        }

        //Properies
        public string Teams
        {
            get { return teams; }
            set { teams = value; }
        }

        public double Parking
        {
            get { return parking; }
            set { parking = value; }
        }

        public double Consessions
        {
            get { return concsessions; }
            set { concsessions = value; }
        }
    }
}
