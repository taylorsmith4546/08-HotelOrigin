using HotelOrigin.Core.Domain;
using HotelOrigin.Core.Repository;
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

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for CustomerListWindow.xaml
    /// </summary>
    public partial class CustomerListWindow : Window
    { 

        private Customer currentlySelectedCustomer = null;

        public CustomerListWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = CustomerRepository.GetAll();
             
        }

        private void buttonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "John@Doe.com",
                TelephoneNumber = "123456789"
                
                 
            };

            CustomerRepository.Add(customer);

        }


        private void buttonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerRepository.Delete(currentlySelectedCustomer);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentlySelectedCustomer = (Customer)dataGrid.SelectedItem;

        }
    }
}
