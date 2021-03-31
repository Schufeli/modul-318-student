using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportView.ViewModels
{
    public class EmailShareWindowViewModel : ViewModelBase
    {
        private List<string> emailAdresses { get; set; }
        public List<string> EmailAdresses
        {
            get { return emailAdresses; }
            set { emailAdresses = value; OnPropertyChanged("EmailAdresses"); }
        }
    }
}
