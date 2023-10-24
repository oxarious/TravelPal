using System;
using System.Windows;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
        public AddTravelWindow()
        {
            InitializeComponent();
            cbCountry.ItemsSource = Enum.GetNames(typeof(Countries));
            cbTravelType.ItemsSource = Enum.GetNames(typeof(TravelType));
        }
    }
}
