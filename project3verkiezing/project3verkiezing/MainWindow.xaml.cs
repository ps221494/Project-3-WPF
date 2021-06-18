using project3verkiezing.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace project3verkiezing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VerkiezingDB _verkiezingDB = new VerkiezingDB();
        public MainWindow()
        {
            InitializeComponent();
            
        }



        private void FillPartijscherm()
        {
            DataTable Table = _verkiezingDB.SelectPartijen();
            if (Table != null)
            {
                DGShow.ItemsSource = Table.DefaultView;
            }
        }

        private void BtnPartij_Click(object sender, RoutedEventArgs e)
        {
            FillPartijscherm();
            DGShow.Visibility = Visibility.Visible;
        }

        private void FillThemaScherm()
        {
            DataTable Table = _verkiezingDB.SelectThema();
            if (Table != null)
            {
                DGShow.ItemsSource = Table.DefaultView;
            }
        }
        private void BtnThema_Click(object sender, RoutedEventArgs e)
        {   
            FillThemaScherm();
            DGShow.Visibility = Visibility.Visible;
        }
    }
}
