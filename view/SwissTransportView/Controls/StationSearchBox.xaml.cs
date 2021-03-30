using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SwissTransport.Models;
using SwissTransportView.Mock;
using SwissTransport.Core;
using SwissTransportView.ViewModels;

namespace SwissTransportView.Controls
{
    /// <summary>
    /// Interaction logic for StationSearchBox.xaml
    /// </summary>
    public partial class StationSearchBox : UserControl
    {
        StationSearchBoxViewModel vm = new StationSearchBoxViewModel();
        public StationSearchBox()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        /// <summary>
        /// StationSearchTextBox TextChanged method
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event parameter</param>
        public void GetStationsOnTextChanged(object sender, TextChangedEventArgs e)
        {
            string query = (sender as ComboBox).Text;
            vm.FilterStations(query);
            (sender as ComboBox).IsDropDownOpen = true;

            // Manipulate the TextBox inside of StationSearchComboBox to place cursor always at the end of the Text
            var textBox = (TextBox)StationSearchComboBox.Template.FindName("PART_EditableTextBox", StationSearchComboBox);
            textBox.CaretIndex = query.Length;
        }

        /// <summary>
        /// Focus StationSearchComboBox OnMouseDoubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationSearchComboBoxOnMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StationSearchComboBox.Focus();
        }
    }
}
