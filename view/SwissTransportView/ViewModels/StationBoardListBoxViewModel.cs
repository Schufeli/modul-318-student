using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportView.ViewModels
{
    class StationBoardListBoxViewModel : ViewModelBase
    {
        private List<StationBoard> stationBoards;
        public List<StationBoard> StationBoards
        {
            get { return stationBoards; }
            set { stationBoards = value; OnPropertyChanged("StationBoards"); }
        }
    }
}
