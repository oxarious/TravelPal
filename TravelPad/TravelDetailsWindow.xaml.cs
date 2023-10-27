using System.Windows;
using TravelPal.TravelClasses;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {

        //TODO: FÅ DENNA ATT FUNKA
        public TravelDetailsWindow()
        {
            InitializeComponent();



        }
        public TravelDetailsWindow(Travel travel)
        {
            InitializeComponent();
            lvTravelDetails.ItemsSource = new System.Collections.Generic.List<Travel>()
            {
                travel
            };
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow detailsWindow = new();
            detailsWindow.Show();
            Close();
        }
    }
}
