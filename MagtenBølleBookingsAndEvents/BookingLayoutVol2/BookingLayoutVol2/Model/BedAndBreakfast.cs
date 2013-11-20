using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLayoutVol2.Model
{
    class BedAndBreakfast
    {
        #region Fields

        private int _quantity;

        #endregion

        #region Properties

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        
        #endregion

        #region Constructor



        public BedAndBreakfast(int quantity)
        {
            Quantity = quantity;
        }

        public BedAndBreakfast()
        {
            this.Quantity = 0;
        }

        #endregion

        public string Print()
        {
            return "Bed and Breakfast: " + Quantity + " Værelser";
        }
        
        public override string ToString()
        {
            return "Bed and Breakfast" + "|" + Quantity;
        }
    }
}
