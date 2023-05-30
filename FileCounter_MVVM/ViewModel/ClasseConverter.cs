using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace FileCounter_MVVM.ViewModel
{
    public class ClasseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string stringValue = value as string;
            string parameterValue = parameter as string;

            if (!string.IsNullOrEmpty(stringValue) && !string.IsNullOrEmpty(parameterValue))
            {
                if (stringValue.Equals(parameterValue, StringComparison.OrdinalIgnoreCase))
                {
                    return new SolidColorBrush(Colors.Green);
                }
            }

            return new SolidColorBrush(Colors.Red);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
