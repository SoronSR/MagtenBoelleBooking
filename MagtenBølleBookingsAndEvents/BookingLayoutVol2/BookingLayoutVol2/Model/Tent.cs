using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLayoutVol2
{
    class Tent
    {
        #region Fields

        int _tentPricePrDay = 50;
        int _tentAmount; 

        #endregion

        #region Constructors

        public Tent(int tentAmount)
        {

            TentAmount = tentAmount;
        }

        public Tent()
        {
            this.TentAmount = 0;
        }

        #endregion

        #region Properties

        public int TentPricePrDay
        {
            get { return _tentPricePrDay; }
            set { _tentPricePrDay = value; }
        }

        public int TentAmount
        {
            get { return _tentAmount; }
            set { _tentAmount = value; }
        }
        
        #endregion

        public override string ToString()
        {
            return "Teltpladser" + "|" + TentAmount;
        }
    }
}
