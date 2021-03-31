using SwissTransportView.ViewModels;
using System.Windows;

namespace SwissTransportView.Views
{
    /// <summary>
    /// Interaction logic for EmailShareWindow.xaml
    /// </summary>
    public partial class EmailShareWindow : Window
    {
        EmailShareWindowViewModel vm = new EmailShareWindowViewModel();
        public EmailShareWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        /// <summary>
        /// Add EmailAddressTextBox.Text to List when AddToListButton on OnClick
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void AddToListButtonOnClick(object sender, RoutedEventArgs e)
        {
            vm.Add(EmailAddressTextBox.Text);
        }

        /// <summary>
        /// Remove DataContext element from List OnClick
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void RemoveEmailAddressFromList(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Send Email when SendEmailButton on OnClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendEmailButtonOnClick(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Close Window when CloseWindowButton on OnClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseWindowButtonOnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
