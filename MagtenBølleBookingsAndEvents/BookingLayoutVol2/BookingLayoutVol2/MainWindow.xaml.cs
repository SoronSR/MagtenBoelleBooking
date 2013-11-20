
using BookingLayoutVol2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookingLayoutVol2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        
        // capacity support
        int trackCardCapacity = 200;
        int bedAndBreakFastRooms = 3;
        int cafeCapacity = 30;
        int tentCapacity = 50;

        // fields to access dynamic created textboxes
        TextBox antalTextBox;
        TextBox dcuAntalTextBox;
        TextBox bbAntalTextBox;
        TextBox cafeAntalTextBox;
        TextBox tentAntalTextBox;

        // data Access support
        DataAccessEvent dataAccess;
        List<Events> events = new List<Events>(); 

        // bookingList
        List<object> bookingList = new List<object>();

        List<DateTime> bookingDates = new List<DateTime>();

        public string order;

        #endregion 

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();

            // Load current events
            dataAccess = new DataAccessEvent();
            events = dataAccess.LoadEvent();
            eventListBox.ItemsSource = events;
        }

        #endregion

        #region Bookings
        private void banekortCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel childrenStackPanel1 = new StackPanel();
            StackPanel childrenStackPanel2 = new StackPanel();
            StackPanel childrenStackPanel3 = new StackPanel();

            Label antalLabel = new Label();
            Label dcuAntaLabel = new Label();
            Label ledigLabel = new Label();
            Label numLabel = new Label();

            antalTextBox = new TextBox();
            dcuAntalTextBox = new TextBox();

            antalTextBox.MinWidth = 30;
            dcuAntalTextBox.MinWidth = 30;

            childrenStackPanel1.Orientation = Orientation.Horizontal;
            childrenStackPanel2.Orientation = Orientation.Horizontal;
            childrenStackPanel3.Orientation = Orientation.Horizontal;

            antalLabel.Width = 140;
            dcuAntaLabel.Width = 140;

            antalLabel.Content = "Antal banekort:";
            dcuAntaLabel.Content = "Antal DCU medlemmer:";
            ledigLabel.Content = "Ledige pladser: ";
            numLabel.Content = trackCardCapacity;
            
            banekortStackPanel.Margin = new Thickness(0, 0, 0, 0);

            childrenStackPanel1.Children.Add(antalLabel);
            childrenStackPanel1.Children.Add(antalTextBox);

            childrenStackPanel2.Children.Add(dcuAntaLabel);
            childrenStackPanel2.Children.Add(dcuAntalTextBox);

            childrenStackPanel3.Children.Add(ledigLabel);
            childrenStackPanel3.Children.Add(numLabel);

            childrenStackPanel1.Margin = new Thickness(40, 0, 0, 0);
            childrenStackPanel2.Margin = new Thickness(40, 0, 0, 0);
            childrenStackPanel3.Margin = new Thickness(40, 0, 0, 0);

            banekortStackPanel.Children.Add(childrenStackPanel1);
            banekortStackPanel.Children.Add(childrenStackPanel2);
            banekortStackPanel.Children.Add(childrenStackPanel3);
        }

        private void banekortCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            banekortStackPanel.Children.Clear();
        }

        private void cafeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel childrenStackPanel1 = new StackPanel();
            Label antalLabel = new Label();
            cafeAntalTextBox = new TextBox();
            antalLabel.Width = 140;
            cafeAntalTextBox.MinWidth = 30;

            childrenStackPanel1.Orientation = Orientation.Horizontal;

            antalLabel.Content = "Antal Cafepladser:";
            antalLabel.Margin = new Thickness(40, 0, 0, 0);

            childrenStackPanel1.Children.Add(antalLabel);
            childrenStackPanel1.Children.Add(cafeAntalTextBox);

            StackPanel childrenStackPanel2 = new StackPanel();
            Label ledigLabel = new Label();
            Label numLabel = new Label();

            childrenStackPanel2.Orientation = Orientation.Horizontal;
            ledigLabel.Content = "Ledige pladser: ";
            numLabel.Content = cafeCapacity;
            childrenStackPanel2.Margin = new Thickness(40, 0, 0, 0);

            childrenStackPanel2.Children.Add(ledigLabel);
            childrenStackPanel2.Children.Add(numLabel);


            cafeStackPanel.Margin = new Thickness(0, 0, 0, 0);
            cafeStackPanel.Children.Add(childrenStackPanel1);
            cafeStackPanel.Children.Add(childrenStackPanel2);
        }

        private void cafeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            cafeStackPanel.Children.Clear();
        }

        private void tentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel childrenStackPanel1 = new StackPanel();
            Label antalLabel = new Label();
            antalLabel.Width = 140;
            tentAntalTextBox = new TextBox();

            tentAntalTextBox.MinWidth = 30;

            childrenStackPanel1.Orientation = Orientation.Horizontal;

            antalLabel.Content = "Antal Teltpladser:";

            antalLabel.Margin = new Thickness(40, 0, 0, 0);

            tentStackPanel.Margin = new Thickness(0, 0, 0, 0);

            childrenStackPanel1.Children.Add(antalLabel);
            childrenStackPanel1.Children.Add(tentAntalTextBox);

            StackPanel childrenStackPanel2 = new StackPanel();
            Label ledigLabel = new Label();
            Label numLabel = new Label();

            childrenStackPanel2.Orientation = Orientation.Horizontal;
            ledigLabel.Content = "Ledige pladser: ";
            numLabel.Content = tentCapacity;
            childrenStackPanel2.Margin = new Thickness(40, 0, 0, 0);

            childrenStackPanel2.Children.Add(ledigLabel);
            childrenStackPanel2.Children.Add(numLabel);

            tentStackPanel.Children.Add(childrenStackPanel1);
            tentStackPanel.Children.Add(childrenStackPanel2);
        }

        private void tentCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            tentStackPanel.Children.Clear();
        }

        private void bbCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel childrenStackPanel1 = new StackPanel();
            Label antalLabel = new Label();
            antalLabel.Width = 140;
            bbAntalTextBox = new TextBox();

            bbAntalTextBox.MinWidth = 30;

            childrenStackPanel1.Orientation = Orientation.Horizontal;

            antalLabel.Content = "Antal Værelser:";

            antalLabel.Margin = new Thickness(40, 0, 0, 0);

            bandbStackPanel.Margin = new Thickness(0, 0, 0, 0);

            childrenStackPanel1.Children.Add(antalLabel);
            childrenStackPanel1.Children.Add(bbAntalTextBox);

            StackPanel childrenStackPanel2 = new StackPanel();
            Label ledigLabel = new Label();
            Label numLabel = new Label();

            childrenStackPanel2.Orientation = Orientation.Horizontal;
            ledigLabel.Content = "Ledige værelser: ";
            numLabel.Content = bedAndBreakFastRooms;
            childrenStackPanel2.Margin = new Thickness(40, 0, 0, 0);

            childrenStackPanel2.Children.Add(ledigLabel);
            childrenStackPanel2.Children.Add(numLabel);

            bandbStackPanel.Children.Add(childrenStackPanel1);
            bandbStackPanel.Children.Add(childrenStackPanel2);
        }

        private void bbCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            bandbStackPanel.Children.Clear();
        } 
        #endregion

        #region Events

        private void bestilButton_Click(object sender, RoutedEventArgs e)
        {
            // building the bookingList
            addBookingToList(banekortCheckBox, antalTextBox, dcuAntalTextBox);
            addBookingToList(cafeCheckBox, cafeAntalTextBox, null);
            addBookingToList(bbCheckBox, bbAntalTextBox, null);
            addBookingToList(tentCheckBox, tentAntalTextBox, null);

            // creating a booking object with the bookingList
            Booking booking = new Booking(bookingList);


            ConfirmOrderWindow confirmOrder = new ConfirmOrderWindow();
            confirmOrder.ParentWindow = this;

            // setting textboxes in ConfirmOrderWindow Window
            setConfirmOrderInformation(confirmOrder, booking);
            confirmOrder.Show();
            
            Customer newC = new Customer(fullNameTextBox.Text, addressTextBox.Text, cityTextBox.Text,
                int.Parse(phoneNumberTextBox.Text), emailTextBox.Text,
                new Booking(bookingList, fromDateTextBox.Text, toDateTextBox.Text, int.Parse(antalBilerTextBox.Text)));

            order = newC.ToString();

            

            bookingDates = dateChecker(fromDateTextBox.Text, toDateTextBox.Text);
        }
        
        #endregion

        #region Private Methods

        private List<DateTime> dateChecker(string startDate1, string endDate1)
        {
            List<DateTime> myNewBookingDateList = new List<DateTime>();
           
            string[] splitter = startDate1.Split('-');
            DateTime startDate = new DateTime(int.Parse(splitter[2]), int.Parse(splitter[1]),
               int.Parse(splitter[0]));

            string[] splitter2 = endDate1.Split('-');
            DateTime endDate = new DateTime(int.Parse(splitter2[2]), int.Parse(splitter2[1]),
               int.Parse(splitter2[0]));
            

            while (startDate != endDate)
            {
                myNewBookingDateList.Add(startDate);
                startDate = startDate.AddDays(1);

            }
            myNewBookingDateList.Add(endDate);
            return myNewBookingDateList;
        }


        private void setConfirmOrderInformation(ConfirmOrderWindow confirmOrder, Booking booking)
        {
            confirmOrder.confirmFromDateTextBox.Text = fromDateTextBox.Text;
            confirmOrder.confirmToDateTextBox.Text = toDateTextBox.Text;
            confirmOrder.confirmFullNameTextBox.Text = fullNameTextBox.Text;
            confirmOrder.confirmAddressTextBox.Text = addressTextBox.Text;
            confirmOrder.confirmCityTextBox.Text = cityTextBox.Text;
            confirmOrder.confirmEmailTextBox.Text = emailTextBox.Text;
            confirmOrder.confirmPhoneNumberTextBox.Text = phoneNumberTextBox.Text;
            confirmOrder.reservationsTextBlock.Text = booking.printReservations();
        }

        //private void addBookingToList(CheckBox bookingCheckBox, TextBox quantityTextBox)
        //{
        //    if (bookingCheckBox.Content.Equals("Cafe"))
        //    {
        //        if (bookingCheckBox.IsChecked == true)
        //        {
        //            Cafe cafe = new Cafe(int.Parse(quantityTextBox.Text));
        //            bookingList.Add(cafe);
        //        }
        //        else
        //        {
        //            Cafe cafe = new Cafe();
        //            bookingList.Add(cafe);
        //        }
        //    }
        //    else if (bookingCheckBox.Content.Equals("Bed & Breakfast"))
        //    {
        //        if (bookingCheckBox.IsChecked == true)
        //        {
        //            BedAndBreakfast bb = new BedAndBreakfast(int.Parse(quantityTextBox.Text));
        //            bookingList.Add(bb);
        //        }
        //        else
        //        {
        //            BedAndBreakfast bb = new BedAndBreakfast();
        //            bookingList.Add(bb);
        //        }
        //    }
        //    else if (bookingCheckBox.Content.Equals("Telt"))
        //    {
        //        if (bookingCheckBox.IsChecked == true)
        //        {
        //            Tent tent = new Tent(int.Parse(quantityTextBox.Text));
        //            bookingList.Add(tent);
        //        }
        //        else
        //        {
        //            Tent tent = new Tent();
        //            bookingList.Add(tent);
        //        }
        //    }
        //    else if (bookingCheckBox.Content.Equals("Banekort"))
        //    {
        //        if (bookingCheckBox.IsChecked == true)
        //        {
        //            TrackCard trackCard = new TrackCard(int.Parse(quantityTextBox.Text), int.Parse(textBox.Text));
        //            bookingList.Add(trackCard);
        //        }
        //        else
        //        {
        //            TrackCard trackCard = new TrackCard();
        //            bookingList.Add(trackCard);
        //        }
        //    }
        //}

        private void addBookingToList(CheckBox bookingCheckBox, TextBox quantityTextBox, TextBox textBox)
        {
            if (bookingCheckBox.Content.Equals("Cafe"))
            {
                if (bookingCheckBox.IsChecked == true)
                {
                    Cafe cafe = new Cafe(int.Parse(quantityTextBox.Text));
                    bookingList.Add(cafe);
                }
                else
                {
                    Cafe cafe = new Cafe();
                    bookingList.Add(cafe);
                }
            }
            else if (bookingCheckBox.Content.Equals("Bed & Breakfast"))
            {
                if (bookingCheckBox.IsChecked == true)
                {
                    BedAndBreakfast bb = new BedAndBreakfast(int.Parse(quantityTextBox.Text));
                    bookingList.Add(bb);
                }
                else
                {
                    BedAndBreakfast bb = new BedAndBreakfast();
                    bookingList.Add(bb);
                }
            }
            else if (bookingCheckBox.Content.Equals("Telt"))
            {
                if (bookingCheckBox.IsChecked == true)
                {
                    Tent tent = new Tent(int.Parse(quantityTextBox.Text));
                    bookingList.Add(tent);
                }
                else
                {
                    Tent tent = new Tent();
                    bookingList.Add(tent);
                }
            }
            else if (bookingCheckBox.Content.Equals("Banekort"))
            {
                if (bookingCheckBox.IsChecked == true)
                {
                    TrackCard trackCard = new TrackCard(int.Parse(quantityTextBox.Text), int.Parse(textBox.Text));
                    bookingList.Add(trackCard);
                }
                else
                {
                    TrackCard trackCard = new TrackCard();
                    bookingList.Add(trackCard);
                }
            }
        }

        #endregion
    }
}
