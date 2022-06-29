using System;
using System.Globalization;
using System.Windows.Data;

namespace CrawManhwa.MyConverter
{
    public class ForegroundEmailConfirmUserConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                bool isConfirmed = (bool)value;

                if (isConfirmed)
                    return "#05c46b";
                return "Red";
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
