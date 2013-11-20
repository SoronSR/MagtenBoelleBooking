using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationUI
{
    public class CreateEvent
    {
        #region Fields
        string _dateTime;
        string _titel;
        decimal _price;
        string _description; 
        #endregion

        #region Constructor
        public CreateEvent(string dateTime, string titel, decimal price, string description)
        {
            DateTime = dateTime;
            Titel = titel;
            Price = price;
            Description = description;
        } 
        #endregion

        #region Properties
        public string DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        } 
        #endregion

        public override string ToString()
        {
            return DateTime + " - " + Titel + " - Pris: " + Price;
                //" - Beskrivelse: " + Description; 
        }
    }
}
