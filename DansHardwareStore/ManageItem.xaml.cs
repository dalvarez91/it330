﻿using System;
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
    /// Interaction logic for ManageItem.xaml
    /// </summary>
    public partial class ManageItem : Window
    {
        public ManageItem()
        {
            InitializeComponent();
        }

        private void button4_click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtItemID.Text;
            strinput[1] = txtItemName.Text;
            strinput[2] = txtItemPrice.Text;
            strinput[3] = txtQuantity.Text;

            nbrinput = 4;

            retval = datamgmt.showData(strinput, nbrinput);
        }
    }
}
