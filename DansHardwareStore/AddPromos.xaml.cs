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
using System.Windows.Shapes;

namespace DansHardwareStore
{
    /// <summary>
    /// Interaction logic for AddPromos.xaml
    /// </summary>
    public partial class AddPromos : Window
    {
        public AddPromos()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtPromoID.Text;
            strinput[1] = txtPromoName.Text;
            strinput[2] = txtItemName.Text;
            strinput[3] = txtPromodate.Text;

            nbrinput = 4;

            retval = datamgmt.showData(strinput, nbrinput);
        }
    }
}
