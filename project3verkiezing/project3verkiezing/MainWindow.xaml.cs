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
                    DataTable TableStandPunt = _verkiezingDB.SelectStandpunt();
                    if (TableStandPunt != null)
                    {
                        DGShow.ItemsSource = TableStandPunt.DefaultView;
                    }
                    break;

                case "4":
                    DataTable TableVerkiezingssoort = _verkiezingDB.SelectVerkiezingSoort();
                    if (TableVerkiezingssoort != null)
                    {
                        DGShow.ItemsSource = TableVerkiezingssoort.DefaultView;
                    }
                    break;

                case "5":
                    DataTable TableVerkiezingen = _verkiezingDB.SelectVerkiezing();
                    if (TableVerkiezingen != null)
                    {
                        DGShow.ItemsSource = TableVerkiezingen.DefaultView;
                    }
                    break;

                case "6":
                    DataTable TableVerkiezingPartijen = _verkiezingDB.SelectVerkiezingPartij();
                    if (TableVerkiezingPartijen != null)
                    {
                        DGShow.ItemsSource = TableVerkiezingPartijen.DefaultView;
                    }
                    break;

            }
          
        }

        private void BtnPartij_Click(object sender, RoutedEventArgs e)
        {
            BtnThema.Content = "Thema";
            BtnStandpunt.Content = "Standpunten";
            BtnVerkiezingssoort.Content = "Verkiezingssoort";
            BtnVerkiezingen.Content = "verkiezingen";
            BtnVerkiezingsPartijen.Content = "VerkiezingsPartijen";

            if (Todelete.Text != "1")
            {
                Todelete.Text = "1";
                BtnPartij.Content = "voeg Partij toe";
              
            }
            else
            {
                Todelete.Text = "a1";
                BtnPartij.Content = "Partij";
                VoegToe();

            }
            
            FillDGScherm();
            DGShow.Visibility = Visibility.Visible;
 
        }

        private void BtnThema_Click(object sender, RoutedEventArgs e)
        {
            BtnPartij.Content = "Partij";
            BtnStandpunt.Content = "Standpunten";
            BtnVerkiezingssoort.Content = "Verkiezingssoort";
            BtnVerkiezingen.Content = "verkiezingen";
            BtnVerkiezingsPartijen.Content = "VerkiezingsPartijen";

            if (Todelete.Text != "2")
            {
                Todelete.Text = "2";
                BtnThema.Content = "voeg Thema toe";
             
            }
            else
            {
                Todelete.Text = "a2";
                BtnThema.Content = "Thema";
                VoegToe();
            }
            FillDGScherm();
            DGShow.Visibility = Visibility.Visible;

        }

        private void BtnStandpunt_Click(object sender, RoutedEventArgs e)
        {
            BtnPartij.Content = "Partij";
            BtnThema.Content = "Thema";
            BtnVerkiezingssoort.Content = "Verkiezingssoort";
            BtnVerkiezingen.Content = "verkiezingen";
            BtnVerkiezingsPartijen.Content = "VerkiezingsPartijen";

            if (Todelete.Text != "3")
            {
                Todelete.Text = "3";
                BtnStandpunt.Content = "Standpunten";
            }
            else
            {
                Todelete.Text = "a3";
                BtnStandpunt.Content = "voeg Standpunt toe";
                VoegToe();
            }
            FillDGScherm();
            DGShow.Visibility = Visibility.Visible;
        }

        private void BtnVerkiezingssoort_Click(object sender, RoutedEventArgs e)
        {
            BtnPartij.Content = "Partij";
            BtnThema.Content = "Thema";
            BtnStandpunt.Content = "Standpunten";
            BtnVerkiezingen.Content = "verkiezingen";
            BtnVerkiezingsPartijen.Content = "VerkiezingsPartijen";

            if (Todelete.Text != "4")
            {
                Todelete.Text = "4";
                BtnVerkiezingssoort.Content = "Verkiezingssoort";
            }
            else
            {
                Todelete.Text = "a4";
                BtnVerkiezingssoort.Content = "voeg verkiezingssoort toe";
                VoegToe();
            }
            FillDGScherm();
            DGShow.Visibility = Visibility.Visible;

        }

        private void BtnVerkiezingen_Click(object sender, RoutedEventArgs e)
        {
            BtnPartij.Content = "Partij";
            BtnThema.Content = "Thema";
            BtnStandpunt.Content = "Standpunten";
            BtnVerkiezingssoort.Content = "Verkiezingssoort";
            BtnVerkiezingsPartijen.Content = "VerkiezingsPartijen";

            if (Todelete.Text != "5")
            {
                Todelete.Text = "5";
                BtnVerkiezingen.Content = "verkiezingen";
            }
            else
            {
                Todelete.Text = "a5";
                BtnVerkiezingen.Content = "voeg verkiezingen toe";
                VoegToe();
            }
            FillDGScherm();
            DGShow.Visibility = Visibility.Visible;
 
        }

        private void BtnVerkiezingsPartijen_Click(object sender, RoutedEventArgs e)
        {
            BtnPartij.Content = "Partij";
            BtnThema.Content = "Thema";
            BtnStandpunt.Content = "Standpunten";
            BtnVerkiezingssoort.Content = "Verkiezingssoort";
            BtnVerkiezingen.Content = "verkiezingen";
          

            if (Todelete.Text != "6")
            {
                Todelete.Text = "6";
                BtnVerkiezingsPartijen.Content = "VerkiezingsPartijen";
            }
            else
            {
                Todelete.Text = "a6";
                BtnVerkiezingsPartijen.Content = "voeg Verkiezingspartij toe";
                VoegToe();
            }
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
                case "3":
                    if (_verkiezingDB.DeleteStandpunt(selectedrow["StandpuntId"].ToString()))
                    {
                        MessageBox.Show("verwijderd");
                    }
                    break;
                case "4":
                    if (_verkiezingDB.DeleteVerkiezingsoort(selectedrow["SoortId"].ToString()))
                    {
                        MessageBox.Show("verwijderd");
                    }
                    break;
                case "5":
                    if (_verkiezingDB.DeleteVerkiezing(selectedrow["VerkiezingId"].ToString()))
                    {
                        MessageBox.Show("verwijderd");
                    }
                    break;
                case "6":
                    if (_verkiezingDB.DeleteVerkiezingpartij(selectedrow["Id"].ToString()))
                    {
                        MessageBox.Show("verwijderd");
                    }
                    break;
            }

            FillDGScherm();


        }

        private void VoegToe()
        {
            string value = Todelete.Text;
            WindowAdd windowadd = new WindowAdd(value);
           
            switch (value)
            {
                case "a1":
                    windowadd.Show();
                    
                    break;
                case "a2":
                    value = "a2";
                    windowadd.Show();

                    break;
                case "a3":
                    value = "a3";
                    windowadd.Show();

                    break;
                case "a4":
                    value = "a4";
                    windowadd.Show();

                    break;
                case "a5":
                    value = "a5";
                    windowadd.Show();

                    break;
                case "a6":
                    value = "a6";
                    windowadd.Show();

                    break;
            }
            

            FillDGScherm();
        }
    }
}
