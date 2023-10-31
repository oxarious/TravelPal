using System.Collections.Generic;
using System.Windows;
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

            //lvTravelPlans.ItemsSource = TravelManager.allTravels;
            //lvTravelPlans.ItemsSource = User.allTravels;
            //if (UserManager.signedInUser is User u)
            //{

            //    //User u = UserManager.signedInUser as User;

            //    lvTravelPlans.ItemsSource = u.AllTravels;
            //}
            //if (UserManager.signedInUser is Admin)
            //{
            //    List<Travel> allUserTravels = new();
            //    foreach (IUser user in UserManager.allUsers)
            //    {
            //        if (user is User)
            //        {
            //            User castedUser = (User)user;
            //            allUserTravels.AddRange(castedUser.AllTravels);
            //        }

            //    }
            //    lvTravelPlans.ItemsSource = allUserTravels;
            //}
        }

        // Adds usertravels to the listview. If you're logged in as admin it draws all travels from all users.
        private void UpdateListView()
        {
            lvTravelPlans.Items.Clear();
            if (UserManager.signedInUser is User u)
            {
                foreach (Travel travel in u.AllTravels)
                {

                    lvTravelPlans.Items.Add(travel);

                }
            }
            else if (UserManager.signedInUser is Admin a)
            {
                List<Travel> allUserTravels = new();
                foreach (IUser user in UserManager.allUsers)
                {
                    if (user is User)
                    {
                        User castedUser = (User)user;
                        allUserTravels.AddRange(castedUser.AllTravels);
                    }

                }
                foreach (Travel t in allUserTravels)
                {
                    lvTravelPlans.Items.Add(t);
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








            if (UserManager.signedInUser is User u)
            {
                var selectedItem = lvTravelPlans.SelectedIndex;
                u.AllTravels.RemoveAt(selectedItem);
            }
            if (UserManager.signedInUser is Admin a)
            {
                var adminSelectedItem = lvTravelPlans.SelectedItem;
                foreach (IUser user in UserManager.allUsers)
                {
                    if (user is User)
                    {
                        User castedUser = (User)user;
                        castedUser.AllTravels.Remove((Travel)adminSelectedItem);

                    }

                }
            }
            UpdateListView();





            //}


            //lvTravelPlans.UpdateLayout();


            //if (UserManager.signedInUser is User user)
            //{
            //    user.AllTravels.Remove((TravelClasses.Travel)lvTravelPlans.SelectedItem);

            //    lvTravelPlans.UpdateLayout();
            //}




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


