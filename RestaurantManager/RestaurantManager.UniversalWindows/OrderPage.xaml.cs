using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Resources;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        public OrderPage()
        {
            this.InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            if (null != AvailableItems.SelectedItem)
            {
                Models.DataManager dataManager = (SelectedItems.DataContext as Models.DataManager);
                dataManager.CurrentlySelectedMenuItems.Add(AvailableItems.SelectedItem.ToString());
            }
        }

        private void SubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            if (0 < SelectedItems.Items.Count)
            {
                Models.DataManager dataManager = (SelectedItems.DataContext as Models.DataManager);
                dataManager.OrderItems.Add(string.Join(", ", SelectedItems.Items));
                dataManager.CurrentlySelectedMenuItems.Clear();
            }
        }
    }
}