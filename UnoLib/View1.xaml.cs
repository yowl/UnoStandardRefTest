using System.Collections.Generic;
using Windows.UI.Xaml.Data;

namespace UnoLib
{
    [Bindable]
    public partial class View1
    {
        public View1()
        {
            Reports = new List<ReportEntity>
                      {
                          new ReportEntity
                          {
                              Name="aa",
                              Value = 1
                          },
                          new ReportEntity
                          {
                              Name="bb",
                          Value = 2,
                      }

                      };
            DataContext = this;
            InitializeComponent();
        }

        IEnumerable<ReportEntity> reports;

        public IEnumerable<ReportEntity> Reports
        {
            get => reports;
            set
            {
                if (reports != value)
                {
                    reports = value;
                }
            }
        }
    }

    [Bindable]
    public class ReportEntity
    {
        public string Name { get; set; }
        public int Value { get; set; }
        //        public List<string> ItemsView { get; set; }
    }
}