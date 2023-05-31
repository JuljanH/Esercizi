using System;
using System.Globalization;
using System.Windows.Data;
using System.IO;
using System.Windows.Media;

namespace FileCounter_MVVM.ViewModel
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string path)
            {
                if (Directory.Exists(path))
                {
                    return Brushes.Green;
                }
            }
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
