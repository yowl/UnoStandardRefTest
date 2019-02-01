using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.ComponentModel;
using System.Linq;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Microsoft.Xaml.Interactivity;
//using Uno.Extensions.Specialized;

namespace UnoLib
{
    [Bindable]
    public class ReferenceBinding
    {
        public static DependencyProperty ReferencePathProperty = DependencyProperty.RegisterAttached("ReferencePath",
            typeof(string), typeof(ReferenceBinding), new PropertyMetadata(null, ReferencePathChanged));

        static void ReferencePathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("ReferencePathChanged " + $" old {e.OldValue} and new {e.NewValue}");
        }

        public static string GetReferencePath(ComboBox element)
        {
            return (string)element.GetValue(ReferencePathProperty);
        }

        public static void SetReferencePath(ComboBox element, string value)
        {
            element.SetValue(ReferencePathProperty, value);
        }

    }

}
