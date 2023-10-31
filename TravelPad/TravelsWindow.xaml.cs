using System.Windows;

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


            //lvTravelPlans.ItemsSource = TravelManager.allTravels;
            //lvTravelPlans.ItemsSource = User.allTravels;
            if (UserManager.signedInUser is User user)
            {

                //User u = UserManager.signedInUser as User;
                lvTravelPlans.ItemsSource = user.AllTravels;
            }
            if (UserManager.signedInUser is Admin admin)
            {

            }
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
            MessageBox.Show("Welcome to our Travel app where you can add travels, overview them, edit them and get more details on them. To add a new travel, press : Add New Travel. ");
        }

        private void btAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindon = new AddTravelWindow();
            addTravelWindon.Show();
            Close();
        }

        private void btRemoveTravel_Click(object sender, RoutedEventArgs e)
        {


            //var selectedItem = lvTravelPlans.SelectedItem;
            //TravelManager.allTravels.Remove((TravelClasses.Travel)selectedItem);
            //lvTravelPlans.UpdateLayout();


            if (UserManager.signedInUser is User user)
            {
                user.AllTravels.Remove((TravelClasses.Travel)lvTravelPlans.SelectedItem);
                lvTravelPlans.Items.Remove(lvTravelPlans.SelectedItem);
                lvTravelPlans.UpdateLayout();
            }




            //TODO: Fixa den här skiten
            //ListViewItem? selectedItem = lvTravelPlans.SelectedItem as ListViewItem;
            //if (lvTravelPlans.SelectedItem == null)
            //{
            //    MessageBox.Show($"Please select a travel you want to remove");
            //}


            //var selectedItemone = lvTravelPlans.SelectedItem;
            //else
            //{


            //    Travel travelToRemove = (Travel?)selectedItem.Tag;
            //    TravelManager.RemoveTravel(travelToRemove);

            //}


            //}
            //TravelManager.allTravels.Remove(lvTravelPlans.ItemsSource);
            //lvTravelPlans.ItemsSource.(lvTravelPlans.SelectedItem);
            //lvTravelPlans.UpdateLayout();
            //lvTravelPlans.Items.Remove(ItemsControl.ItemsSourceProperty((lvTravelPlans.SelectedItem));

        }


        // TODO: FÅ DENNA ATT FUNKA 
        private void btShowDetails_Click(object sender, RoutedEventArgs e)
        {

            //ListViewItem lvItem = new ListViewItem();
            //if (lvItem != null)
            //    lvItem.Tag = lvItem.ToString();
            //lvItem.Content = lvItem.ToString();
            //TravelDetailsWindow detailsWindow = new TravelDetailsWindow(lvItem);
            //detailsWindow.Show();
            //Close();

            //ListViewItem selectedItem = (ListViewItem)lvTravelPlans.SelectedItem;
            //Travel travel = (Travel)selectedItem.Tag;
            TravelDetailsWindow detailsWindow = new TravelDetailsWindow();
            detailsWindow.Show();
            Close();
        }

    }
}


