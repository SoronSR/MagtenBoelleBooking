using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLayoutVol2.Model
{
    class Cafe
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

        public Cafe(int quantity)
        {
            Quantity = quantity;
        }

        public Cafe()
        {
            this.Quantity = 0;
        }

        #endregion

        public override string ToString()
        {
            return "Cafe" + "|" + Quantity;
        }
    }
}
