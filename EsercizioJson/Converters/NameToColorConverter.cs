using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace EsercizioJson.Converters
{
    public class NameToColorConverter : IValueConverter
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

            return Brushes.Black; // Colore predefinito se il valore non è una stringa
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
