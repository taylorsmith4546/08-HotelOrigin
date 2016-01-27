﻿using System;
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

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCustomerManagement_Click(object sender, RoutedEventArgs e)
        {
            CustomerListWindow listWindow = new CustomerListWindow();

            listWindow.ShowDialog(); 
        }

        private void buttonReservationManagement_Click(object sender, RoutedEventArgs e)
        {
            ReservationListWindow listWindow = new ReservationListWindow();

            listWindow.ShowDialog();
        }

        private void buttonRoomManagement_Click(object sender, RoutedEventArgs e)
        {
            RoomListWindow listWindow = new RoomListWindow();

            listWindow.ShowDialog();
        }
    }
}
