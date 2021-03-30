using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransportView.Mock;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

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
            Stations stations = MockData.GetStations(); // TODO: Remove after development and fetch real time data

            FilteredStations = stations.StationList.Where(
                s => s.Name.ToLower().StartsWith(query.ToLower()))
                    .ToList();


            //Stations stations = transport.GetStations(query);
            //FilteredStations = stations.StationList;
        }
    }
}
