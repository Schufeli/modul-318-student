using SwissTransport.Models;
using System.Collections.Generic;

namespace SwissTransportView.ViewModels
{
    public class ConnectionListBoxViewModel : ViewModelBase
    {
        private List<Connection> connections;
        
        public List<Connection> Connections
        {
            get { return connections; }
            set { connections = value; OnPropertyChanged("Connections"); }
        }
    }
}
