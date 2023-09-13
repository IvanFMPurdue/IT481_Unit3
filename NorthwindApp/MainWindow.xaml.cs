﻿using System.Windows;

namespace NorthwindApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private BusinessLayer _bl;

        private void LoadCustomersBtn_Click(object sender, RoutedEventArgs e)
        {
            NumberOfCustomersTbx.Text = $"{_bl.GetNumberOfCustomers()}";
            CustomerNamesLbx.ItemsSource = _bl.GetCustomerLastName();
        }

        private void LoadEmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            NumberOfEmployeesTbx.Text = $"{_bl.GetNumberOfEmployees()}";
            EmployeeNamesLbx.ItemsSource = _bl.GetEmployeeLastName();
        }

        private void LoadOrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            NumberOfOrdersTbx.Text = $"{_bl.GetNumberOfOrders()}";
            OrderNamesLbx.ItemsSource = _bl.GetOrderName();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadDataBtn.IsEnabled = true;
            LoadEmployeesBtn.IsEnabled = true;
            LoadOrdersBtn.IsEnabled = true;

            _bl = new BusinessLayer(DatabaseTbx.Text, ServerTbx.Text, UserNameTbx.Text, PasswordTbx.Text);
        }
    }
}
