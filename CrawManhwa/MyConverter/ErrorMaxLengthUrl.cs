using System;
using System.Globalization;
using System.Windows.Data;

namespace CrawManhwa.MyConverter
{
    public class ErrorMaxLengthUrl : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string number = value.ToString();
            int length = Int32.Parse(number);

            if (length > 7500)
                return "Red";
            return "Black";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
