using SwissTransportView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportView.ViewModels
{
    public class EmailShareWindowViewModel : ViewModelBase
    {
        private ObservableCollection<CustomEmailAddress> emailAdresses { get; set; }
        public ObservableCollection<CustomEmailAddress> EmailAdresses
        {
            get { return emailAdresses; }
            set { emailAdresses = value; OnPropertyChanged("EmailAdresses"); }
        }

        public void Add(CustomEmailAddress emailAddress)
        {
            emailAdresses.Add(emailAddress);
        }
    }
}
