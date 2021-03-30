using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SwissTransport.Models;
using SwissTransportView.Mock;
using SwissTransport.Core;

namespace SwissTransportView.Controls
{
    /// <summary>
    /// Interaction logic for StationSearchBox.xaml
    /// </summary>
    public partial class StationSearchBox : UserControl
    {
        public Stations Stations { get; set; }
        public StationSearchBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// StationSearchTextBox TextChanged method
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event parameter</param>
        public void GetStationsOnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((sender as TextBox).Text))
                {
                    this.CloseSuggestionPopup();
                    return;
                }
                this.Stations = MockData.GetStations(); // TODO: Remove after development fetches mock data
                this.OpenSuggestionPopup();

                this.StationList.ItemsSource = this.Stations.StationList.Where(
                    s => s.Name.ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.Write(ex);
            }
        }

        /// <summary>
        /// StationList SelectionChanged method
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event parameter</param>
        private void StationListOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (this.StationList.SelectedIndex <= -1)
                {
                    this.CloseSuggestionPopup();
                    return;
                }

                this.CloseSuggestionPopup();

                this.StationSearchTextBox.Text = ((Station)this.StationList.SelectedItem).Name;
                this.StationList.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.Write(ex);
            }
        }

        #region Suggestion Popup helper methods
        /// <summary>
        /// Open auto suggestion popup
        /// </summary>
        private void OpenSuggestionPopup()
        {
            try
            {
                this.StationListPopup.Visibility = Visibility.Visible;
                this.StationListPopup.IsOpen = true;
                this.StationList.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.Write(ex);
            }
        }
        /// <summary>
        /// Close auto suggestion popup
        /// </summary>
        private void CloseSuggestionPopup()
        {
            try
            {
                this.StationListPopup.Visibility = Visibility.Collapsed;
                this.StationListPopup.IsOpen = false;
                this.StationList.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.Write(ex);
            }
        }
        #endregion
    }
}
