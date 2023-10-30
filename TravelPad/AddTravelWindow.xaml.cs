using System;
using System.Windows;
using System.Windows.Controls;

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
            cbxAllInclusive.Visibility = Visibility.Hidden;
            lbWorkDetails.Visibility = Visibility.Hidden;


            //if ((string)cbTravelType.SelectedItem == "Work")
            //{
            //    lbWorkDetails.Visibility = Visibility.Visible;
            //}

        }

        //OM work är valt visas "Work details" eller om vacation är valt visas "All inclusive" 
        private void cbTravelType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (string)cbTravelType.SelectedItem;
            if (selectedItem == "Work")
            {
                lbWorkDetails.Visibility = Visibility.Visible;
                cbxAllInclusive.Visibility = Visibility.Hidden;
            }
            if (selectedItem == "Vacation")
            {
                cbxAllInclusive.Visibility = Visibility.Visible;
                lbWorkDetails.Visibility = Visibility.Hidden;
            }

        }

        private void btSaveTravel_Click(object sender, RoutedEventArgs e)
        {

            // TODO: If travelers are letters, wrong message
            // TODO: If ayn of the feilds are not input, show wrong message
            if (cbTravelType.SelectedItem != null && txtCity.Text != null && cbCountry.SelectedItem != null && txtTravelers.Text != null)
            {
                if ((string)cbTravelType.SelectedItem == "Work")
                {
                    WorkTrip workTrip = TravelManager.AddWorkTrip(TravelManager.ParseEnum(cbCountry.Text), txtCity.Text, int.Parse(txtTravelers.Text), txtMeetingDetails.Text);
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Tag = workTrip;
                    listViewItem.Content = workTrip;
                    //lvTravel.Items.Add(listViewItem);
                    MessageBox.Show($"Travel saved. Go back to get a better overview of your travels");
                    TravelManager.allTravels.Add(workTrip);

                    // LUCAS KOD 
                    //User user = UserManager.signedInUser as User;
                    //user.allTravels.Add(workTrip);


                }
                if ((string)cbTravelType.SelectedItem == "Vacation")
                {

                    Vacation vacation = TravelManager.AddVacation(TravelManager.ParseEnum(cbCountry.Text), txtCity.Text, int.Parse(txtTravelers.Text), true);
                    ListViewItem listViewItemVacation = new ListViewItem();
                    listViewItemVacation.Tag = vacation;
                    listViewItemVacation.Content = vacation;
                    //lvTravel.Items.Add(listViewItemVacation);
                    MessageBox.Show($"Travel saved. Go back to get a better overview of your travels");
                    TravelManager.allTravels.Add(vacation);


                    //ListViewItem lvitem = new(); 
                    //lvitem.Tag= vacation;
                    //lvitem.Content = vacation;
                    //return lvitem; 
                }

            }


        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            //ListViewItem listViewItem = (ListViewItem)lvTravel.SelectedItems;
            //Travel travel = (Travel)listViewItem.Tag;
            TravelsWindow travelsWindow = new TravelsWindow();
            travelsWindow.Show();
            Close();

        }

        //private void cbTravelType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //        if (cbTravelType.SelectedItem == "Work")
        //    {
        //        lbWorkDetails.Visibility = Visibility.Visible;
        //    }
        //}
    }
}






