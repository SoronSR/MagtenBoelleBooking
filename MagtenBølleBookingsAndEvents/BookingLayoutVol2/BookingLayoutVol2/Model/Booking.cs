using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLayoutVol2
{
    class Booking
    {
        #region Fields

        List<object> _bookingType;
        string _arrivalDate;
        string _departureDate;
        int _needParking;
        private List<object> bookingList;

        #endregion

        #region Constructors

        public Booking(List<object> bookingType, string arrivalDate, string departureDate, int needParking)
        {
            BookingType = bookingType;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            NeedParking = needParking;
        }

        public Booking(List<object> bookingList)
        {
            
            this.BookingType = bookingList;
        }

        #endregion

        #region Properties

        public List<object> BookingType
        {
            get { return _bookingType; }
            set { _bookingType = value; }
        }

        public string ArrivalDate
        {
            get { return _arrivalDate; }
            set { _arrivalDate = value; }
        }

        public string DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }

        public int NeedParking
        {
            get { return _needParking; }
            set { _needParking = value; }
        }

        #endregion

        public override string ToString()
        {
            return ArrivalDate + "|" + DepartureDate + "|" + NeedParking + getBookings(BookingType);
        }

        public string printReservations()
        {
            string output = "";
            foreach (object booking in BookingType)
            {
                output += booking.ToString() + 
                    "|";
            }

            string[] splitter = output.Split('|');

            return "Antal banekort: " + splitter[1] + "\nAntal DCU medlemmer: " + splitter[3] + "\nAntal B&B rum: " + splitter[7] + "\nAntal pladser i café: " + splitter[5] + "\nAntal teltpladser: " + splitter[9];
        }

        private string getBookings(List<object> BookingType)
        {
            string output = "";
            
            for (int i = 0; i < BookingType.Count; i++)
            {
                output += "|" + BookingType[i].ToString();
            }
            return output;
        }

        
    }
}
