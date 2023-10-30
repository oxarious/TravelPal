using System.Windows;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {

        //TODO: FÅ DENNA ATT FUNKA
        public TravelDetailsWindow()
        {
            InitializeComponent();



        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow detailsWindow = new();
            detailsWindow.Show();
            Close();
        }
    }
}
