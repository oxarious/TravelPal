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
        }

        private void btLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btAboutus_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a fully made up company that has been giving students headaches for 2 weeks. Still a very good exercise to learn more about code");
        }
    }
}
