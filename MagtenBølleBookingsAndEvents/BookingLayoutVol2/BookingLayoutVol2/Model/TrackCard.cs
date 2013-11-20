using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLayoutVol2
{
    public class TrackCard
    {
        #region Fields

        private int _quantity;
        private int _dcuQuantity;

        #endregion

        #region Constructors

        public TrackCard(int quantity, int dcuQuantity)
        {
            this.Quantity = quantity;
            this.DcuQuantity = dcuQuantity;
        }

        public TrackCard()
        {
            this.Quantity = 0;
            this.DcuQuantity = 0;
        } 

        #endregion

        #region Properties

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public int DcuQuantity
        {
            get { return _dcuQuantity; }
            set { _dcuQuantity = value; }
        }
        
        #endregion

        public override string ToString()
        {
            return "Banekort" + "|" + Quantity + "|" + "DCU medlemmer" + "|" + DcuQuantity;
        }
    }
}
