using System.Windows;
using System.Windows.Controls;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {
        private object selectedItem;

        public TravelDetailsWindow(ListViewItem lvItem)
        {
            InitializeComponent();

        }

        public TravelDetailsWindow(object selectedItem)
        {
            this.selectedItem = selectedItem;
            InitializeComponent();
            lvTravelDetails.ItemsSource = (System.Collections.IEnumerable)selectedItem;
        }
    }
}
