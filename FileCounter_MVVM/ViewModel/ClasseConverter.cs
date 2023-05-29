using System;
using System.Globalization;
using System.Windows.Data;
using System.IO;
using System.Windows.Media;

namespace BindConversion
{
    public class ClasseConverter : IValueConverter
    {
        public object Convert(object o, Type type,
            object parameter, CultureInfo culture)
        {
            string FolderPath = o as string;
            bool isValid = (bool)o;
            return isValid? new SolidColorBrush(Colors.Green) :
                new SolidColorBrush(Colors.Red) ;
        }

        public object ConvertBack(object o, Type type,
            object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}