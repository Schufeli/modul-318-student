using SwissTransport.Models;
using SwissTransportView.ViewModels;
using SwissTransportView.Views;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace SwissTransportView.Controls
{
    /// <summary>
    /// Interaction logic for ConnectionListBox.xaml
    /// </summary>
    public partial class ConnectionListBox : UserControl
    {
        ConnectionListBoxViewModel vm = new ConnectionListBoxViewModel();
        public ConnectionListBox()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        /// <summary>
        /// Create FlowDocument and open PrintDialog() on ConnectionPrintButton OnClick event
        /// </summary>
        /// <param name="sender">Sender parametser</param>
        /// <param name="e">Event parameter</param>
        private void ConnectionPrintButtonOnClick(object sender, RoutedEventArgs e)
        {
            var connection = (sender as Button).DataContext as Connection;

            PrintDialog printDialog = new PrintDialog();

            // Convert Time format of connection
            var departureTime = DateTime.Parse(connection.From.Departure.ToString()).ToString("HH:mm");
            var arrivalTime = DateTime.Parse(connection.To.Arrival.ToString()).ToString("HH:mm");

            // Create dynamic FlowDocument
            FlowDocument doc = new FlowDocument(
                new Paragraph(
                    new Run(
                        $"From {connection.From.Station.Name} " +
                        $"To: {connection.To.Station.Name} " +
                        $"From: {departureTime} " +
                        $"Until: {arrivalTime} " +
                        $"Duration: {connection.Duration} " +
                        $"Departure Platform: {connection.From.Platform}")));

            doc.Name = "Connection";

            // Create IDocumentPaginatorSource from FlowDocument 
            IDocumentPaginatorSource idpSource = doc;

            // Open PrintDialog and print document on OK result
            Nullable<Boolean> print = printDialog.ShowDialog();
            if (print == true)
            {
                printDialog.PrintDocument(idpSource.DocumentPaginator, "My Connection");
            }
        }

        /// <summary>
        /// Open EmailShareWindow when ConnectionShareButton OnClick event
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event parameter</param>
        private void ConnectionShareButtonOnClick(object sender, RoutedEventArgs e)
        {
            EmailShareWindow emailShareWindow = new EmailShareWindow();

            Nullable<Boolean> shared = emailShareWindow.ShowDialog();
            if (shared == true)
            {
                // TODO: Add send Email functionality via sendgrid
            }
        }
    }
}
