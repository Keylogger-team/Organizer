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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<Page> list; //список хранящий страницы
        //int index;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new Uri("Page1.xaml" , UriKind.Relative));
        }

        private void ListViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }
    }
}
