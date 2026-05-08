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

namespace WpfApp_10._1_Resources
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //因为brush类继承自Freezable类，Freezable类有一个基本的变化跟踪特性。所以，无论何时改变画刷，所有使用该画刷的控件都会跟着改变
            ImageBrush brush = this.Resources["MyImageBrush"] as ImageBrush;
            brush.Viewport=new Rect(0, 0, 5, 5);
            Console.WriteLine("Button Clicked");
        }
    }
}
