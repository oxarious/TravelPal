using System.Windows;
using System.Windows.Controls;
using TravelPal.TravelClasses;

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
            if (UserManager.signedInUser is Admin)
            {
                btShowDetails.Visibility = Visibility.Hidden;
            }
            UpdateListView();

        }



        private void UpdateListView()
        {
            lvTravelPlans.Items.Clear();
            if (UserManager.signedInUser is User u)
            {
                foreach (Travel travel in u.AllTravels)
                {

                    lvTravelPlans.Items.Add(new ListViewItem()
                    {
                        Content = travel.Country,
                        Tag = travel
                    });
                }
            }
            else if (UserManager.signedInUser is Admin)
            {
                foreach (IUser iuser in UserManager.allUsers)
                {
                    if (iuser is User user)
                    {
                        foreach (Travel travel in user.AllTravels)
                        {
                            lvTravelPlans.Items.Add(new ListViewItem()
                            {
                                Content = travel.Country,
                                Tag = travel
                            });
                        }
                    }

                }


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
            MessageBox.Show("Welcome to our Travel app where you can add travels, overview them, edit them and get more details on them. To add a new travel, press : Add New Travel. ");
        }

        private void btAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindon = new AddTravelWindow();
            addTravelWindon.Show();
            Close();
        }


        // Should have method here for RemoveTravel() but have been struggling with this for some time so just doing it in here. 
        private void btRemoveTravel_Click(object sender, RoutedEventArgs e)
        {


            if (UserManager.signedInUser is User u)
            {
                var selectedItem = lvTravelPlans.SelectedIndex;
                if (selectedItem == -1)
                {
                    MessageBox.Show("Please select an item to remove.");
                    return;
                }


                u.AllTravels.RemoveAt(selectedItem);
            }
            if (UserManager.signedInUser is Admin)
            {
                if (lvTravelPlans.SelectedIndex == -1)
                {
                    MessageBox.Show("No Travels to Remove");
                }

                else if (lvTravelPlans.SelectedItem != null)
                {
                    var SelectedItem = (Travel)((ListViewItem)lvTravelPlans.SelectedItem).Tag;
                    foreach (IUser user in UserManager.allUsers)
                    {
                        if (user is User a)
                        {
                            //User castedUser = (User)user;
                            a.AllTravels.Remove(SelectedItem);

                        }

                    }
                }

            }

            UpdateListView();


        }



        private void btShowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (lvTravelPlans.SelectedItem != null)
            {

                var selectedItem = (Travel)((ListViewItem)lvTravelPlans.SelectedItem).Tag;


                TravelDetailsWindow detailsWindow = new TravelDetailsWindow(selectedItem);
                detailsWindow.Show();
                Close();
            }
        }

    }
}


