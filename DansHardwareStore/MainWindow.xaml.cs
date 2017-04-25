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

namespace DansHardwareStore
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

        
        





        private void button_click (object sender, RoutedEventArgs e)
        {
            AdminUser adminuser = new AdminUser();
            adminuser.Show();
        }

        private void button1_click (object sender, RoutedEventArgs e)
        {
            AddEmployee addemployee = new AddEmployee();
            addemployee.Show();
        }

        private void button2_click (object sender, RoutedEventArgs e)
        {
            Services services = new Services();
            services.Show();
        }

        private void button3_click (object sender, RoutedEventArgs e)
        {
            AddPromos addpromos = new AddPromos();
            addpromos.Show();
        }

        private void button4_click (object sender, RoutedEventArgs e)
        {
            ManageItem additem = new ManageItem();
            additem.Show();
        }
    }
}
