using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Event
    {
        #region Fields

        private int _quantity;
        private double _price;
        private const double EVENT_PRICE = 100;

        #endregion

        #region Constructors

        public Event(int quantity, int dcuQuantity)
        {
            this.Quantity = quantity;
            _price = EVENT_PRICE;
        } 

        #endregion

        #region Properties

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        
        public double Price
        {
            get { return _price; }
        } 

        #endregion
    }
}
