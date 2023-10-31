using System.Windows;

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
            if (UserManager.signedInUser is User)
            {
                User u = UserManager.signedInUser as User;
                lvTravelDetails.ItemsSource = u.AllTravels;
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
