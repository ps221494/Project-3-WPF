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



        private void FillDGScherm()
        {
            switch (Todelete.Text)
            {
                case "1":
                    DataTable TablePartijen = _verkiezingDB.SelectPartijen();
                    if (TablePartijen != null)
                    {
                        DGShow.ItemsSource = TablePartijen.DefaultView;
                    }
                    break;

                case "2":
                    DataTable TableThema = _verkiezingDB.SelectThema();
                    if (TableThema != null)
                    {
                        DGShow.ItemsSource = TableThema.DefaultView;
                    }
                    break;

                case "3":

                    break;
            }
          
        }

        private void BtnPartij_Click(object sender, RoutedEventArgs e)
        {
            Todelete.Text = "1";
            FillDGScherm();
            DGShow.Visibility = Visibility.Visible;
        }

        private void BtnThema_Click(object sender, RoutedEventArgs e)
        {

            Todelete.Text = "2";
            FillDGScherm();
            DGShow.Visibility = Visibility.Visible;
        }

        private void BtnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedrow = DGShow.SelectedItem as DataRowView;

            switch (Todelete.Text)
            {
                case "1":
                    if (_verkiezingDB.DeletePartij(selectedrow["PartijId"].ToString()))
                    {
                        MessageBox.Show("verwijderd");
                    }
                    break;
                case "2":
                    if (_verkiezingDB.DeleteThema(selectedrow["ThemaId"].ToString()))
                    {
                        MessageBox.Show("verwijderd");
                    }
                    break;
            }

            FillDGScherm();


        }
    }
}
