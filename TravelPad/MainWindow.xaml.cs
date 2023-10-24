using System.Windows;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            UserManager.GenerateDefaultUsers();


        }

        private void btLogIn_Click(object sender, RoutedEventArgs e)
        {

            //Checks if input boxes are empty
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(pwPassword.Password))
            {
                MessageBox.Show("Input fields were empty");
                return;
            }
            //Checks if username is taken
            if (!UserManager.CheckLogIn(txtUsername.Text, pwPassword.Password))
            {
                MessageBox.Show("Username or Password was not correct");
                return;
            }

            //Log in user & send to travelwindow

            TravelsWindow travelsWindow = new TravelsWindow();
            travelsWindow.Show();
            Close();





            //if (txtUsername.Text != null && txtPassword.Text != null)
            //{
            //    bool isUsernameAvailable = UserManager.CheckLogIn(txtUsername.Text, txtPassword.Text);

            //    if (isUsernameAvailable == true)
            //    {
            //        //Log in user
            //        MessageBox.Show("logged in");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Username or Password was not correct");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Input fields were empty");
            //}
        }

        private void btRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }
    }
}
