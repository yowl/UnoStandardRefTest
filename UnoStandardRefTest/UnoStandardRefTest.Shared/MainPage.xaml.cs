using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoStandardRefTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            try
            {
//                XamlReader.Load(@"<ResourceDictionary
//    xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" 
//    xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
//    
//    <Style TargetType=""TextBlock"" x:Key=""DefaultColumnStyle"">
//    </Style>
//    
//</ResourceDictionary>
//");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public List<string> Items { get; set; }
    }
}
