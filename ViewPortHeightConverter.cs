using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TiledImage
{
    public class ViewPortHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double h = 1 / (double)value;
            return new Rect(0, 0, 1, h);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
