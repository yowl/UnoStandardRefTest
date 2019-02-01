using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UnoLib
{
    public partial class View1
    {
        public View1()
        {
            InitializeComponent();
        }
   }

    [Windows.UI.Xaml.Data.Bindable]
    public class ReportParameterHolder : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        CollectionViewSource itemsView;
        public CollectionViewSource ItemsView
        {
            get { return itemsView; }
            set { SetAndRaiseChanged(ref itemsView, value); }
        }
        public string DisplayMember { get; set; }
        public string ValueMember { get; set; }
        public string ItemsSource { get; set; }

        public void SetAndRaiseChanged<T>(ref T backingProperty, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (!AreEqual(backingProperty, newValue))
            {
                backingProperty = newValue;
                OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            }
        }

        public static bool AreEqual(object backingProperty, object newValue)
        {
            return backingProperty == newValue || (backingProperty == null && newValue == null);
        }
    }

    [Windows.UI.Xaml.Data.Bindable]
    public class ComboItem
    {
        public int Key { get; set; }
        public string Name { get; set; }
    }
}