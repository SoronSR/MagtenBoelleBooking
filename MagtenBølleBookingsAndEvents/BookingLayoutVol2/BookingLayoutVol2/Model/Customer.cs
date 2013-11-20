using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLayoutVol2.Model
{
    public class Customer
    {
        #region Fields

        int _id;
        string _fullName;
        string _address;
        string _city;
        int _phoneNumber;
        string _email;
        object _booking;

        #endregion

        #region Constructors

        public Customer(string fullname, string address, string city, 
            int phoneNumber, string email, object booking)
        {
            Id = createId();
            FullName = fullname;
            Address = address;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
            Booking = booking;
        }

        #endregion

        #region Proporties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public object Booking
        {
            get { return _booking; }
            set { _booking = value; }
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return Id + "|" +  FullName + "|" + Address + "|" + City + "|" + PhoneNumber + "|" + Email + "|" + Booking;
        }

        #endregion

        #region Private Methods
        
        public int createId()
        {
            int tempUserId = 0;
            List<string> userID = new List<string>();
            string temp = FilePaths.bookingPath;
            userID = new List<string>(File.ReadAllLines(temp));
            tempUserId = userID.Count;
            return tempUserId + 1001;
        }

        #endregion
    }
}
