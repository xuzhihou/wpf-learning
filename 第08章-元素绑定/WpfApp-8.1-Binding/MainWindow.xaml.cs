using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_8._1_Binding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmd_SetSmall(object sender, RoutedEventArgs e)
        {
            SliderFontSize.Value = 8;
        }

        private void cmd_SetNormal(object sender, RoutedEventArgs e)
        {
            SliderFontSize.Value = 12;
        }

        private void cmd_SetLarge(object sender, RoutedEventArgs e)
        {
            SliderFontSize.Value = 36;
        }

    }
}
