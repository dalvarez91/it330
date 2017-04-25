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
      
          private void AddSupplier_Click(object sender, RoutedEventArgs e)
        {
            AddSupplier addsupplier = new AddSupplier();
            addsupplier.Show();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee addemployee = new AddEmployee();
            addemployee.Show();
        }

       

        private void btnAddService_Click(object sender, RoutedEventArgs e)
        {
            Services addservice = new Services();
            addservice.Show();
        }

        private void btnAddPromos_Click(object sender, RoutedEventArgs e)
        {
            AddPromos addpromos = new AddPromos();
            addpromos.Show();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            ManageItem additem = new ManageItem();
            additem.Show();
        }
    }
}
