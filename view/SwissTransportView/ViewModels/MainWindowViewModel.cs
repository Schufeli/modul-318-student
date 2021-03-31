using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportView.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private DateTime departureDate;
        private string departureTime;

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; OnPropertyChanged("DepartureDate"); }
        }

        public string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; OnPropertyChanged("DepartureTime"); }
        }

    }
}
