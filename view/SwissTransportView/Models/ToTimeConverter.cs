using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SwissTransportView.Models
{
    class ToTimeConverter : IValueConverter 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Input value</param>
        /// <param name="targetType">Target type</param>
        /// <param name="parameter">Object parameter</param>
        /// <param name="culture">Cultureinfo parameter</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime time = DateTime.Parse(value.ToString());
            return time.ToString("HH:mm");
        }

        /// <summary>
        /// Auto Implementd Intervace
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
