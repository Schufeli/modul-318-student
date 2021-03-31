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
using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransportView.ViewModels;

namespace SwissTransportView
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ITransport transport = new Transport();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenStationBoardOnClick(object sender, RoutedEventArgs e)
        {
            // TODO: this is the validation clean up tomorrow and refactor 
            if (string.IsNullOrEmpty(StationBoardSearchBox.StationSearchComboBox.Text))
            {
                MessageBox.Show("Please select a Station");
            }
            var stationSearchBox = StationBoardSearchBox.DataContext as StationSearchBoxViewModel;
            if (stationSearchBox.FilteredStations.Count < 1)
            {
                MessageBox.Show("Please select a valid Station");
            }
            else
            {
                var station = stationSearchBox.FilteredStations[0];
                var stationBoard = StationBoardListBox.DataContext as StationBoardListBoxViewModel;

                //if (stationBoard.StationBoards.Count > 1)
                //{
                //    stationBoard.StationBoards.Clear();
                //}

                stationBoard.StationBoards = transport.GetStationBoard(station.Name, station.Id).Entries;
            }
        }
    }
}
