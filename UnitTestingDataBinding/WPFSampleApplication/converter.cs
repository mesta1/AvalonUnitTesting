using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace WPFSampleApplication
{
    class AlarmsTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // il valore è l'enum AlarmType. La conversione è nel database
            return "converter";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }       
    }
}
