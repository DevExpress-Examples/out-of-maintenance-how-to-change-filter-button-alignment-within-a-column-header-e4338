using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication6
{
    public class MyColumnHeaderDockPanel : ColumnHeaderDockPanel
    {
        bool IsDocked(UIElement element)
        {
            return element == HeaderPresenter || element == HeaderCustomizationArea || element == FilterPresenter || element == SortIndicator;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            double left = ContentMargin.Left;
            double right = ContentMargin.Right;
            double height = Math.Max(0, finalSize.Height - (ContentMargin.Top + ContentMargin.Bottom));
            foreach (UIElement child in Children)
            {
                if (!IsDocked(child))
                    child.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
            }
            if (SortIndicator != null)
                right = ArrangeRight(SortIndicator, right + 10, finalSize.Width, height);
            if (HeaderCustomizationArea != null)
                right = ArrangeRight(HeaderCustomizationArea, right, finalSize.Width, height);
            switch (ContainerAlignment)
            {
                case System.Windows.HorizontalAlignment.Left:
                    if (HeaderPresenter != null)
                        left = ArrangeLeft(HeaderPresenter, left, height);
                    if (FilterPresenter != null)
                        left = ArrangeLeft(FilterPresenter, finalSize.Width - FilterPresenter.DesiredSize.Width, height);
                    break;
                case System.Windows.HorizontalAlignment.Right:
                    if (FilterPresenter != null)
                        right = ArrangeRight(FilterPresenter, right, finalSize.Width, height);
                    if (HeaderPresenter != null)
                        right = ArrangeRight(HeaderPresenter, right, finalSize.Width, height);
                    break;
                case System.Windows.HorizontalAlignment.Stretch:
                    if (FilterPresenter != null)
                        right = ArrangeRight(FilterPresenter, right, finalSize.Width, height);
                    if (HeaderPresenter != null)
                        left = ArrangeStretch(HeaderPresenter, left, right, finalSize.Width, height);
                    break;
                case System.Windows.HorizontalAlignment.Center:
                    if (HeaderPresenter != null)
                    {
                        double total = (HeaderPresenter.DesiredSize.Width + (FilterPresenter != null ? FilterPresenter.DesiredSize.Width : 0d));
                        double indent = Math.Max(0, left + (finalSize.Width - left - right - total) / 2);
                        left = ArrangeCenter(HeaderPresenter, height, indent);
                    }
                    if (FilterPresenter != null)
                        left = ArrangeLeft(FilterPresenter, left, height);
                    break;
            }
            return finalSize;
        }
        //double ArrangeLeft(UIElement element, double left, double height)
        //{
        //    if (element.GetType() == typeof(TextBlock))
        //    {
        //        element.Arrange(new Rect(18, ContentMargin.Top, element.DesiredSize.Width, height));
        //    }
        //    else if (element.GetType() == typeof(ComboBoxEdit))
        //    {
        //        element.Arrange(new Rect(2, ContentMargin.Top, element.DesiredSize.Width, height));
        //    }
        //    else element.Arrange(new Rect(left, ContentMargin.Top, element.DesiredSize.Width, height));
        //    return left + element.DesiredSize.Width;
        //}
        double ArrangeLeft(UIElement element, double left, double height)
        {
            element.Arrange(new Rect(left, ContentMargin.Top, element.DesiredSize.Width, height));
            return left + element.DesiredSize.Width;
        }

        double ArrangeRight(UIElement element, double right, double width, double height)
        {
            element.Arrange(new Rect(Math.Max(0, width - right - element.DesiredSize.Width), ContentMargin.Top, element.DesiredSize.Width, height));
            return right + element.DesiredSize.Width;
        }
        double ArrangeStretch(UIElement element, double left, double right, double width, double height)
        {
            element.Arrange(new Rect(left, ContentMargin.Top, Math.Max(0, width - (left + right)), height));
            return width - right;
        }
        double ArrangeCenter(UIElement element, double height, double indent)
        {
            element.Arrange(new Rect(indent, ContentMargin.Top, element.DesiredSize.Width, height));
            return indent + element.DesiredSize.Width;
        }
    }
}
