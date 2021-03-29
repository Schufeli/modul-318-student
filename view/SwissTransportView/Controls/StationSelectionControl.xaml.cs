using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SwissTransport.Models;
using SwissTransport.Core;

namespace SwissTransportView.Controls
{
    /// <summary>
    /// Interaction logic for StationSelectionControl.xaml
    /// </summary>
    public partial class StationSelectionControl : UserControl
    {
        private Transport api = new Transport();
        private List<Station> stations = new List<Station>();

        public StationSelectionControl()
        {
            InitializeComponent();
        }

        public void GetStationsOnTextChanged(object sender, TextChangedEventArgs e)
        { 
            stations = MockData.GetStations(); // TODO: remove after development only mock data
            string query = (sender as TextBox).Text;
            var border = (StationsStack.Parent as ScrollViewer).Parent as Border;
            bool found = false;

            if (query.Length == 0)
            {
                // Clear 
                StationsStack.Children.Clear();
                border.Visibility = Visibility.Collapsed;
            } 
            else
            {
                border.Visibility = Visibility.Visible;
            }

            StationsStack.Children.Clear();

            foreach(var station in stations)
            {
                if (station.Name.ToLower().StartsWith(query.ToLower()))
                {
                    AddItemToStationsStack(station);
                    found = true;
                }
            }
        }

        private void AddItemToStationsStack(Station station)
        {
            TextBlock block = new TextBlock();
            var border = (StationsStack.Parent as ScrollViewer).Parent as Border;
            block.Text = station.Name;

            // A little style...
            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;

            // Mouse events
            block.MouseLeftButtonUp += (sender, e) =>
            {
                StationSearchTextBox.Text = (sender as TextBlock).Text;
                border.Visibility = Visibility.Collapsed;
            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.PeachPuff;
            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;
            };

            // Add to the panel
            StationsStack.Children.Add(block);
        }

        public void OpenMapWithStationLocation(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Map with location of the Station");
        }

    }
}
