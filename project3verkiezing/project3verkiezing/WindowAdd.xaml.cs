using project3verkiezing.Classes;
using System.Data;
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

namespace project3verkiezing
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        string value;
        public WindowAdd(string _value)
        {
            InitializeComponent();
            value = _value;
            Windows2_Load();
        }

        private void Windows2_Load()
        {
            //use the value here:
            
            string value2 = value;
            TBtoAdd.Text = value2;
        }


    }
}
