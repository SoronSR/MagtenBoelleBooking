using System;
using System.Collections.Generic;
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

namespace AdministrationUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataAccessEvent dataAccess;
        List<CreateEvent> events = new List<CreateEvent>();

        public MainWindow()
        {
            InitializeComponent();

            dataAccess = new DataAccessEvent();
            events = dataAccess.LoadEvent();
            eventsListBox.ItemsSource = events; 
        }

        private void createEventButton_Click(object sender, RoutedEventArgs e)
        {
            createEvent();
        }

        private void createEvent()
        {
            CreateEvent eventer = new CreateEvent(dateTimeTextBox.Text, titelTextBox.Text, decimal.Parse(priceTextBox.Text), descriptionTextBox.Text);
            events.Add(eventer);
            eventsListBox.Items.Refresh();

            dataAccess.SaveEvent(events);
        }

    }
}
