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
            var path = e.NewValue as string;
            var combo = d as ComboBox;
            if (path != null && combo != null)
            {
                var paramHolder = combo.DataContext as ReportParameterHolder;
                if (paramHolder != null)
                {
                    paramHolder.ItemsView = new CollectionViewSource
                    {
                        Source = GetRefDataItems(path, combo)
                    };
                }
            }
        }

        static object GetRefDataItems(string path, ComboBox combo)
        {
            var binding = new Binding { Path = new PropertyPath(path), Source = RefSources.Instance };
            BindingOperations.SetBinding(combo, FrameworkElement.TagProperty, binding);
            return combo.GetValue(FrameworkElement.TagProperty);
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

    public class RefSources
    {
        public static readonly RefSources Instance = new RefSources();

        public List<ComboItem> Source1 { get; set; }  = new List<ComboItem>
                                                        {
                                                            new ComboItem
                                                            {
                                                                Key = 1,
                                                                Name = "S"
                                                            },
                                                            new ComboItem
                                                            {
                                                                Key = 2,
                                                                Name = "b"
                                                            },
                                                        };

        public List<ComboItem> Source2 { get; set; } = new List<ComboItem>
                                         {
                                             new ComboItem
                                             {
                                                 Key = 1,
                                                 Name = "S2"
                                             },
                                             new ComboItem
                                             {
                                                 Key = 2,
                                                 Name = "b2"
                                             },
                                         };
    }

}
