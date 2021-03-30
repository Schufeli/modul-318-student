using SwissTransportView.ViewModels;
using System.Windows.Controls;

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
    }
}
