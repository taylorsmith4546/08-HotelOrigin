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
    /// Interaction logic for RoomListWindow.xaml
    /// </summary>
    public partial class RoomListWindow : Window
    {
        private Room currentlySelectedRoom = null;

        public RoomListWindow()

        {
            InitializeComponent();
            dataGrid.ItemsSource = RoomRepository.GetAll();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentlySelectedRoom = (Room)dataGrid.SelectedItem;
        }

        private void button_AddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room
            {
               RoomNumber = 123,
               NumberOfBeds = 2,
               HasTv = true

            };
            RoomRepository.Add(room);
        }
    }
}
