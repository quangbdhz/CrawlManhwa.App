using System;
using System.Globalization;
using System.Windows.Data;

namespace CrawManhwa.MyConverter
{
    public class EmailConfirmedUserConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                bool isConfirmed = (bool)value;

                if (isConfirmed)
                    return "Confirmed";
                return "UnConfimred";
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
