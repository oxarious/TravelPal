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
        public TravelDetailsWindow(Travel travel)
        {
            InitializeComponent();
            if (UserManager.signedInUser is User)
            {
                lvTravelDetails.Items.Add(travel);
                //User u = UserManager.signedInUser as User;
                //lvTravelDetails.ItemsSource = u.AllTravels;
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
