using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace UnoLib
{
    public partial class View1
    {
        public View1()
        {
            Reports = new List<ReportEntity>
                      {
                          new ReportEntity
                          {
                              ItemsView =  new List<string> {"a", "b"}
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

    public class ReportEntity
    {
        public List<string> ItemsView { get; set; }
    }
}