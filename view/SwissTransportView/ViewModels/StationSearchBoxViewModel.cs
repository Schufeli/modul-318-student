using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransportView.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportView.ViewModels
{
    public class StationSearchBoxViewModel : ViewModelBase
    {
        private ITransport transport = new Transport();
        private List<Station> foundStations;
        private Station selectedStation;
        public List<Station> FilteredStations
        {
            get { return foundStations; }
            set { foundStations = value; OnPropertyChanged("FilteredStations"); }
        }

        public Station SelectedStation
        {
            get { return selectedStation; }
            set { selectedStation = value; OnPropertyChanged("SelectedStation"); }
        }

        public void FilterStations(string query)
        {
            Stations stations = MockData.GetStations(); //TODO: Remove after development and fetch real time data

            FilteredStations = stations.StationList.Where(
                s => s.Name.ToLower().StartsWith(query.ToLower()))
                    .ToList();


            //Stations stations = transport.GetStations(query);
            //FilteredStations = stations.StationList;
        }
    }
}
