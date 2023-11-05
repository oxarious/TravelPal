using System.Windows;
using TravelPal.TravelClasses;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {


        public TravelDetailsWindow(Travel travel)
        {
            InitializeComponent();
            if (UserManager.signedInUser is User)
            {
                lvTravelDetails.Items.Add(travel);

            }


        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow detailsWindow = new();
            detailsWindow.Show();
            Close();
        }
    }
}
