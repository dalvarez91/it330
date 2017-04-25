using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DansHardwareStore
{
    class Datamgmt
    {
        public int showData(string[] stringargs, int intargs)
        {

            string msgtxt = " ";

            for (int i = 0; i <= stringargs.GetUpperBound(0); i++)
            { msgtxt = msgtxt + " " + stringargs[i].ToString() + "\n"; };


            MessageBox.Show(msgtxt);
            return 0;
        }
    }
}
