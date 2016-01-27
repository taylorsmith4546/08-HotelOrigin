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
using System.Windows.Shapes;
using HotelOrigin.Core.Domain;
using HotelOrigin.Core.Repository;

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for ReservationListWindow.xaml
    /// </summary>
    public partial class ReservationListWindow : Window
    {
        private Reservation currentlySelectedReservation = null;

        public ReservationListWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = ReservationRepository.GetAll();

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_AddReservation_Click(object sender, RoutedEventArgs e)
        {
            Reservation reservation = new Reservation
            {
                Customer = "First Name Last Name",
                Room = "Room Number",
                CheckInDate = DateTime.Now,
                CheckOutDate = DateTime.Now

            };
            ReservationRepository.Add(reservation);
        }

        private void comboBox_Reservation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox_Reservation = sender as ComboBox;

            string value = comboBox_Reservation.SelectedItem as string;
            this.Title = "Selected: " + value;
        }

        private void comboBox_Customer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox_Customer = sender as ComboBox;

            string value = comboBox_Customer.SelectedItem as string;
            this.Title = "Selected: " + value;

        }

        private void comboBox_Customer_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Customer 1");
            data.Add("Customer 2");
            data.Add("Customer 3");
            data.Add("Customer 4");
            data.Add("Customer 5");

            var comboBox = sender as ComboBox;

            comboBox.ItemsSource = data;

            comboBox.SelectedIndex = 0;
        }

        private void comboBox_Reservation_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Reservation 1");
            data.Add("Reservation 2");
            data.Add("Reservation 3");
            data.Add("Reservation 4");
            data.Add("Reservation 5");
            

            var comboBox = sender as ComboBox;

            comboBox.ItemsSource = data;

            comboBox.SelectedIndex = 0;
        }

        private void button_ClearReservation_Click(object sender, RoutedEventArgs e)
        {
            ReservationRepository.Delete(currentlySelectedReservation);
        }
    }
}
