using SwissTransport.Core;
using SwissTransport.Models;
using System.Collections.Generic;

namespace SwissTransportView.ViewModels
{
    public class StationSearchBoxViewModel : ViewModelBase
    {
        private ITransport transport = new Transport();
        private List<Station> foundStations;

        public List<Station> FilteredStations
        {
            get { return foundStations; }
            set { foundStations = value; OnPropertyChanged("FilteredStations"); }
        }

        public void FilterStations(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                Stations stations = transport.GetStations(query);
                FilteredStations = stations.StationList;
            }
        }
    }
}
