using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using UnoLib.Annotations;

namespace UnoLib
{
    public class ViewModel : INotifyPropertyChanged
    {
        IEnumerable<ReportEntity> reports;

        public IEnumerable<ReportEntity> Reports
        {
            get => reports;
            set
            {
                if (reports != value)
                {
                    reports = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ReportEntity
    {
        public int Key { get; set; }
        public string Name { get; set; }
    }
}
