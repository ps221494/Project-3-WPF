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
        private readonly toevoegen _Toevoegen;
        VerkiezingDB _verkiezingDB = new VerkiezingDB();
        public MainWindow(toevoegen toeVoegen)
        {
            _Toevoegen = toeVoegen;
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
                BtnPartij.Content = "Partij";
            }
            else
            {
                Todelete.Text = "A1";
                BtnPartij.Content = "voeg Partij toe";
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
                BtnThema.Content = "Thema";
            }
            else
            {
                Todelete.Text = "A2";
                BtnThema.Content = "voeg Thema toe";
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
                Todelete.Text = "A3";
                BtnStandpunt.Content = "voeg Standpunt toe";
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
                Todelete.Text = "A4";
                BtnVerkiezingssoort.Content = "voeg verkiezingssoort toe";
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
                Todelete.Text = "A5";
                BtnVerkiezingen.Content = "voeg verkiezingen toe";
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
                Todelete.Text = "A6";
                BtnVerkiezingsPartijen.Content = "voeg VerkiezingsPartij toe";
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
            }

            FillDGScherm();


        }

        private void VoegToe()
        {
          
            toevoegen add = new toevoegen();

            switch (Todelete.Text)
            {
                case "A1":
                    _Toevoegen.SetTextBoxValue("A1");
                    add.Show();
                    
                    break;
            }
            

            FillDGScherm();
        }
    }
}
