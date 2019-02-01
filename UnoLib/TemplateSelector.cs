using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnoLib
{
    public class ParameterTemplateSelector : DataTemplateSelector
    {
//        public static readonly DependencyProperty MultiSelectStandardComboHolderProperty = DependencyProperty.Register("MultiSelectStandardComboHolder", typeof(DataTemplate), typeof(ParameterTemplateSelector), new PropertyMetadata(default(DataTemplate)));

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var element = container as FrameworkElement;

            if (element != null && item != null && item is ReportEntity)
            {
                var holder = item as ReportEntity;
//                if (holder.MultiValue) return holder.ItemsSource != null && holder.ItemsSource.Contains("{") ? MultiSelectStandardComboHolder : MultiSelectComboHolder;
                return ComboHolder;
//                if (!string.IsNullOrEmpty(holder.ItemsSource))
//                {
//                    return holder.ItemsSource.Contains("{") ? ComboStandardHolder : ComboHolder;
//                }
//                if (holder.ParameterType == HseParameterType.Boolean) return BoolHolder;
//                if (holder.ParameterType == HseParameterType.Integer) return IntHolder;
//                if (holder.ParameterType == HseParameterType.DateTime) return DateHolder;
                return StringHolder;
            }

            return null;
        }

        public DataTemplate DateHolder { get; set; }
        public DataTemplate ComboHolder { get; set; }
        public DataTemplate ComboStandardHolder { get; set; }
        public DataTemplate MultiSelectComboHolder { get; set; }
        public DataTemplate BoolHolder { get; set; }
        public DataTemplate StringHolder { get; set; }
        public DataTemplate IntHolder { get; set; }
        public DataTemplate MultiSelectStandardComboHolder { get; set; }
    }
}
