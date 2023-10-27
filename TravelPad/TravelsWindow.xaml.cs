using System.Windows;
using System.Windows.Controls;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {


        public TravelsWindow()
        {
            InitializeComponent();
            lbLoggedInUser.Content = UserManager.signedInUser.Username;
            lvTravelPlans.ItemsSource = TravelManager.allTravels;
        }



        private void btLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btAboutus_Click(object sender, RoutedEventArgs e)
        {
            //btShowDetails.Visibility = Visibility.Hidden;
            MessageBox.Show("This is a fully made up company that has been giving students headaches for 2 weeks. Still a very good exercise to learn more about code");
        }

        private void btAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindon = new AddTravelWindow();
            addTravelWindon.Show();
            Close();
        }

        private void btRemoveTravel_Click(object sender, RoutedEventArgs e)
        {
            if (lvTravelPlans.SelectedItem == null)
            {
                MessageBox.Show($"Please select a travel you want to remove");
            }

            //TravelManager.allTravels.Remove(lvTravelPlans.ItemsSource);
            //lvTravelPlans.ItemsSource.(lvTravelPlans.SelectedItem);
            //lvTravelPlans.UpdateLayout();
            //lvTravelPlans.Items.Remove(ItemsControl.ItemsSourceProperty((lvTravelPlans.SelectedItem));

        }

        private void btShowDetails_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem = lvTravelPlans.SelectedItem as ListViewItem;
            TravelDetailsWindow detailsWindow = new TravelDetailsWindow(lvTravelPlans.SelectedItem);
            detailsWindow.Show();
            Close();
        }
    }
}
