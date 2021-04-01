using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using SwissTransport.Core;
using SwissTransportView.ViewModels;

namespace SwissTransportView
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ITransport transport = new Transport();
        MainWindowViewModel vm = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;

            // Initialize DepartureDate and DepartureTime with current Device data
            vm.DepartureDate = DateTime.Now;
            vm.DepartureTime = DateTime.Now.ToString("HH:mm");
        }

        /// <summary>
        /// Fill StationBoardListBox on OpenStationBoardButton OnClick event
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event parameter</param>
        private void OpenStationBoardOnClick(object sender, RoutedEventArgs e)
        {
            // TODO: Validation if string is empty and FilteredStation = null opens both MessageBoxes
            if (string.IsNullOrEmpty(StationBoardSearchBox.StationSearchComboBox.Text))
            {
                MessageBox.Show("Please select a Station");
            }
            var stationSearchBox = StationBoardSearchBox.DataContext as StationSearchBoxViewModel;
            if (stationSearchBox.FilteredStations == null)
            {
                MessageBox.Show("Please select a valid Station");
            }
            else
            {
                var station = stationSearchBox.FilteredStations[0];
                var stationBoard = StationBoardListBox.DataContext as StationBoardListBoxViewModel;

                stationBoard.StationBoards = transport.GetStationBoard(station.Name, station.Id).Entries;
            }
        }

        /// <summary>
        /// Fill ConnectionListBox on ConnectionSearchButton OnClick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenConnectionListOnClick(object sender, RoutedEventArgs e)
        {
            var startStationSearchBox = StartStationSearchBox.DataContext as StationSearchBoxViewModel;
            var endStationSearchBox = EndStationSearchBox.DataContext as StationSearchBoxViewModel;
            var departureDate = DateTime.Parse(DepartureDateDatePicker.SelectedDate.ToString());
            var connectionListBox = ConnectionListBox.DataContext as ConnectionListBoxViewModel;

            // Validate UserInput before loading data from API
            TimeFormatValidator(DepartureTimeTextBox.Text);
            if (startStationSearchBox.FilteredStations == null)
            {
                MessageBox.Show("Please select your Departure");
            }
            if (endStationSearchBox.FilteredStations == null)
            {
                MessageBox.Show("Please select your Destination");
            }

            if (startStationSearchBox.FilteredStations != null && endStationSearchBox.FilteredStations != null)
            {
                connectionListBox.Connections = transport.GetConnections(
                startStationSearchBox.FilteredStations[0].Name,
                endStationSearchBox.FilteredStations[0].Name,
                departureDate.ToString("yyyy-MM-dd"),
                DepartureTimeTextBox.Text).ConnectionList;
            } else
            {
                MessageBox.Show("yeet");
            }
        }

        /// <summary>
        /// Validate DepartureDataPicker OnDateVlalidationError
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event parameter</param>
        private void DepartureDateDatePickerOnDateValidationError(object sender, DatePickerDateValidationErrorEventArgs e)
        {
            MessageBox.Show("Invalid Date format");
        }

        /// <summary>
        /// DepartureTimeTextBox Validation with Regex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartureTimeTextBoxValidation(object sender, TextChangedEventArgs e)
        {
            string input = (sender as TextBox).Text;
            TimeFormatValidator(input);
        }

        /// <summary>
        /// Validated the DepartureTimeTextBox input through Regex
        /// </summary>
        /// <param name="input">String to validate</param>
        /// <returns></returns>
        private bool TimeFormatValidator(string input)
        {
            if (input.Length > 4)
            {
                if (!Regex.IsMatch(input, @"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$"))
                {
                    MessageBox.Show("Plese use the hh:mm Timeformat");
                    return true;
                }
            }
            return false;
        }
    }
}
