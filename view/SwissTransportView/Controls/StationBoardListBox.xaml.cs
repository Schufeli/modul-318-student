using SwissTransportView.ViewModels;
using System.Windows.Controls;

namespace SwissTransportView.Controls
{
    /// <summary>
    /// Interaction logic for StationBoardListBox.xaml
    /// </summary>
    public partial class StationBoardListBox : UserControl
    {
        StationBoardListBoxViewModel vm = new StationBoardListBoxViewModel();
        public StationBoardListBox()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
