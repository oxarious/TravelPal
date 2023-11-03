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
            UserManager.InitializeUserManager();




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




            TravelsWindow travelsWindow = new TravelsWindow();
            travelsWindow.Show();
            Close();

        }

        private void btRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }
    }
}
