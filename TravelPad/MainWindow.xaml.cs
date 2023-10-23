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

            if (txtUsername.Text == null && txtPassword.Text == null)
            {
                MessageBox.Show("Input fields were empty");
                return;
            }

            if (!UserManager.CheckLogIn(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Username or Password was not correct");
                return;
            }

            //Log in user & send to travelwindow
            MessageBox.Show("logged in");






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
    }
}
