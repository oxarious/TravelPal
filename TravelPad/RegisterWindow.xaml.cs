using System;
using System.Windows;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            cbCountries.ItemsSource = Enum.GetNames(typeof(Countries));
        }

        private void btRegisterUser_Click(object sender, RoutedEventArgs e)
        {
            if (!UserManager.CheckUsernameAvailability(txtRwUsername.Text))
            {
                MessageBox.Show("That username is already taken");
            }

            //TODO: Fix so it doesnt crash if you dont have any inputs
            User newUser = UserManager.CreateUser(txtRwUsername.Text, txtRwPassword.Text, UserManager.ParseEnum(cbCountries.SelectedItem.ToString()));
            UserManager.allUsers.Add(newUser);

            MessageBox.Show("User added succesfully");

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
