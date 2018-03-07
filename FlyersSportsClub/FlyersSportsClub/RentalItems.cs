using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyersSportsClub
{
    class RentalItems
    {
        private string rentalItem;
        private double regularPrice;
        private double memberPrice;

        public RentalItems(string item, double regPrice, double memPrice)
        {
            rentalItem = item;
            regularPrice = regPrice;
            memberPrice = memPrice;
        }

        public string RentalItem
        {
            get { return rentalItem; }
            set { rentalItem = value; }
        }

        public double RegularPrice
        {
            get { return regularPrice; }
            set { regularPrice = value; }
        }

        public double MemberPrice
        {
            get { return memberPrice; }
            set { memberPrice = value; }
        }
    }
}
