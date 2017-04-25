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
    /// Interaction logic for Services.xaml
    /// </summary>
    public partial class Services : Window
    {
        public Services()
        {
            InitializeComponent();
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
       
                int retval = 0;

                Datamgmt datamgmt = new Datamgmt();

                string[] strinput = new string[7];
                int nbrinput = 0;

                strinput[0] = txtServiceID.Text;
                strinput[1] = txtCustomerID.Text;
                strinput[2] = txtFirstName.Text;
                strinput[3] = txtLastName.Text;
                strinput[4] = txtServiceDesc.Text;
                strinput[5] = txtDate.Text;
                strinput[6] = txtServicePrice.Text;


                nbrinput = 7;

                retval = datamgmt.showData(strinput, nbrinput);
            
        }
    }
}
