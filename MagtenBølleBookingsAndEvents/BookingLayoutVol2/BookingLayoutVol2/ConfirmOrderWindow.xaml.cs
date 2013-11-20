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
using System.Windows.Shapes;

namespace BookingLayoutVol2
{
    /// <summary>
    /// Interaction logic for ConfirmOrderWindow.xaml
    /// </summary>
    public partial class ConfirmOrderWindow : Window
    {
        public ConfirmOrderWindow()
        {
            InitializeComponent();
        }

        public MainWindow ParentWindow { get; set; }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            confirmOrder();
        }

        private void confirmOrder()
        {
            StreamWriter writerUserPass = new StreamWriter(FilePaths.bookingPath, true);
            writerUserPass.WriteLine(ParentWindow.order, Environment.NewLine);
            writerUserPass.Close();

            MessageBox.Show("Tak for din bestilling!");
            this.Close();
            resetMainWindow();
        }

        private void resetMainWindow()
        {
            ParentWindow.fullNameTextBox.Text = "Fulde Navn";
            ParentWindow.addressTextBox.Text = "Adresse";
            ParentWindow.cityTextBox.Text = "By";
            ParentWindow.phoneNumberTextBox.Text = "Tlf. Nummer";
            ParentWindow.emailTextBox.Text = "Email";
            ParentWindow.verifiedEmailTextBox.Text = "Bekræft Email";
            ParentWindow.commentTextBox.Text = "";
            ParentWindow.fromDateTextBox.Text = "";
            ParentWindow.toDateTextBox.Text = "";
            ParentWindow.antalBilerTextBox.Text = "0";
            ParentWindow.banekortCheckBox.IsChecked = false;
            ParentWindow.tentCheckBox.IsChecked = false;
            ParentWindow.bbCheckBox.IsChecked = false;
            ParentWindow.cafeCheckBox.IsChecked = false;
        }

        private void cancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            resetMainWindow();

            this.Close();
        }

        
    }
}
