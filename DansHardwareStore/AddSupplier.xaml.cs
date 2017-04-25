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
    /// Interaction logic for AddSupplier.xaml
    /// </summary>
    public partial class AddSupplier : Window
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void saveSupplier_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[9];

            int nbrinput = 0;

            strinput[0] = txtSupID.Text;

            strinput[1] = txtCompany.Text;

            strinput[2] = txtEmail.Text;

            strinput[3] = txtPhone1.Text;

            strinput[4] = txtAddress.Text;

            strinput[5] = txtCity.Text;

            strinput[6] = txtState.Text;

            strinput[7] = txtZip.Text;

            strinput[8] = txtCreated.Text;

            nbrinput = 9;



            retval = datamgmt.showData(strinput, nbrinput);
        }
    }
}
