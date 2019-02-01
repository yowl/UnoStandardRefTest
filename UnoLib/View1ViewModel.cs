using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UnoLib
{
    [Windows.UI.Xaml.Data.Bindable]
    public class View1ViewModel : INotifyPropertyChanged
    {
        public View1ViewModel()
        {
            CreateItemSourceItems();
        }

        public ReportParameterHolder FirstItem => ReportParameters[0];

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public void CreateItemSourceItems()
        {
            ReportParameters = new List<ReportParameterHolder>
                      {
                          new ReportParameterHolder
                          {
                              DisplayMember = "Name",
                              ValueMember = "Key",
                              ItemsSource="Source1",
                          },
                      };
        }

        List<ReportParameterHolder> reportParameters;
        public List<ReportParameterHolder> ReportParameters
        {
            get { return reportParameters; }
            set { SetAndRaiseChanged(ref reportParameters, value); }
        }

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
}
