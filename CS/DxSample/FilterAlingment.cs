using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DxSample
{
    class FilterAlingment
    {
        public static readonly DependencyProperty FilterAlingmentProperty = DependencyProperty.RegisterAttached("FilterAlingment", typeof(HorizontalAlignment), typeof(FilterAlingment), new UIPropertyMetadata(null));

        public static HorizontalAlignment GetFilterAlingment(DependencyObject target)
        {
            return (HorizontalAlignment)target.GetValue(FilterAlingmentProperty);
        }

        public static void SetFilterAlingment(DependencyObject target, HorizontalAlignment value)
        {
            target.SetValue(FilterAlingmentProperty, value);
        }  
    }
}
