using SendGrid;
using SendGrid.Helpers.Mail;
using SwissTransport.Models;
using SwissTransportView.Models;
using SwissTransportView.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace SwissTransportView.Views
{
    /// <summary>
    /// Interaction logic for EmailShareWindow.xaml
    /// </summary>
    public partial class EmailShareWindow : Window
    {
        EmailShareWindowViewModel vm = new EmailShareWindowViewModel();
        public Connection Connection { get; set; }
        public EmailShareWindow(Connection connection)
        {
            InitializeComponent();
            this.DataContext = vm;
            vm.EmailAdresses = new ObservableCollection<CustomEmailAddress>();
            Connection = connection;
        }

        /// <summary>
        /// Add EmailAddressTextBox.Text to List when AddToListButton on OnClick
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void AddToListButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(EmailAddressTextBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                var emailAddress = new CustomEmailAddress()
                {
                    Email = EmailAddressTextBox.Text
                };

                vm.Add(emailAddress);
            }
            else
            {
                MessageBox.Show("Please use a valid Email format");
            }
        }

        /// <summary>
        /// Remove DataContext element from List OnClick
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void RemoveEmailAddressFromList(object sender, RoutedEventArgs e)
        {
            var item = (sender as Button).DataContext as CustomEmailAddress;
            vm.EmailAdresses.Remove(item);
            EmailAddressTextBox.Clear();
        }

        /// <summary>
        /// Send Email when SendEmailButton on OnClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendEmailButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (vm.EmailAdresses.Count <= 0)
            {
                MessageBox.Show("Please insert at least one Email Address");
            }
            else
            {
                var departureTime = DateTime.Parse(Connection.From.Departure.ToString()).ToString("HH:mm");
                var arrivalTime = DateTime.Parse(Connection.To.Arrival.ToString()).ToString("HH:mm");

                var receipents = new List<EmailAddress>();

                foreach (var email in vm.EmailAdresses)
                {
                    var result = new EmailAddress(email.Email, email.Email);
                    receipents.Add(result);
                }

                var client = new SendGridClient("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");
                var msg = new SendGridMessage()
                {
                    From = new EmailAddress("info@schufi.codes", "Schufi"),
                    Subject = "Your SwissTransport connection",
                    PlainTextContent = $"From {Connection.From.Station.Name} " +
                                        $"To: {Connection.To.Station.Name} " +
                                        $"From: {departureTime} " +
                                        $"Until: {arrivalTime} " +
                                        $"Duration: {Connection.Duration} " +
                                        $"Departure Platform: {Connection.From.Platform}",
                    HtmlContent = $"<strong>From { Connection.From.Station.Name } " +
                                        $"To: {Connection.To.Station.Name} " +
                                        $"From: {departureTime} " +
                                        $"Until: {arrivalTime} " +
                                        $"Duration: {Connection.Duration} " +
                                        $"Departure Platform: {Connection.From.Platform}",
                    Personalizations = new List<Personalization>
                    {
                        new Personalization
                        {
                            Tos = receipents
                        }
                    }
                };

                client.SendEmailAsync(msg);
                this.Close();
            }
        }

        /// <summary>
        /// Close Window when CloseWindowButton on OnClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseWindowButtonOnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
