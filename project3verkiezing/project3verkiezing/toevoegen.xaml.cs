using project3verkiezing.Classes;
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
    /// Interaction logic for toevoegen.xaml
    /// </summary>
    public partial class toevoegen : Window
    {
     
        public toevoegen()
        {
            InitializeComponent();
        }

        public void SetTextBoxValue(string value)
        {
            TBtoAdd.Text = value;
        }
    }
}
