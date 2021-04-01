using SwissTransport.Models;
using SwissTransportView.Models;
using SwissTransportView.ViewModels;
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
        public EmailShareWindow(Connection connection, Window window)
        {
            InitializeComponent();
            this.DataContext = vm;
            vm.EmailAdresses = new ObservableCollection<EmailAddress>();
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
                var emailAddress = new EmailAddress()
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
            var item = (sender as Button).DataContext as EmailAddress;
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
