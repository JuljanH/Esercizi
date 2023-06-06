using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace EsercizioJson.Converters
{
    public class NomeColoreConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string nome)
            {
                if (nome.Length > 5)
                {
                    return Brushes.Red;
                }
                else
                {
                    return Brushes.Green;
                }
            }

            return Brushes.Black; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
