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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));

            MessageBox.Show(button.Content.ToString(), "Changed Color", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button =sender as Button;
            Title=button.Content.ToString();

            
            foreach (var item in StackPanelAll.Children)
            {
                if(item is StackPanel stack)
                stack.Children.Remove(button);
            }


            MessageBox.Show("Deleted Button","",MessageBoxButton.OK, MessageBoxImage.Information);


            
            
        }
    }
}
