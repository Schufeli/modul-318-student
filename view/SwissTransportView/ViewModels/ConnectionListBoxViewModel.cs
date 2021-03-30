using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void LoadConnections(List<Connection> connections)
        {
            Connections = connections;
        }
    }
}
