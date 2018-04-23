using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using DevExpress.Xpf.Grid;
using System.Windows.Controls;

namespace DxSample
{
    class FilterAlignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            GridColumn column = (value as GridColumnHeader).DataContext as GridColumn;
            return column.GetValue(FilterAlingment.FilterAlingmentProperty);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
