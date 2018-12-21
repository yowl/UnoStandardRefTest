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
        ViewModel vm = new ViewModel();
        public View1()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            vm.Reports = new List<ReportEntity>
                         {
                             new ReportEntity
                             {
                                 Key = 1, Name="a"
                             },
                             new ReportEntity
                             {
                             Key = 2, Name="b"
                         }
                         };
        }
    }
}