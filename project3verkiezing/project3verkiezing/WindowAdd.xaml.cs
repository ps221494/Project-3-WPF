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

            switch (TBtoAdd.Text)
            {
                case "a1":
                    TBBanner.Text = "Voeg partij toe";
                    TBX1.Text = "Partij Naam";
                    TBX2.Text = "Adres";
                    TBX3.Text = "Postcode";
                    TBX4.Text = "Gemeente";
                    TBX5.Text = "Email adres";
                    TBX6.Text = "telefoonnummer";
                    break;
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            VerkiezingDB _verkiezingDB = new VerkiezingDB();
            if (_verkiezingDB.VoegPartij(TXT1.Text, TXT2.Text, TXT3.Text, TXT4.Text, TXT5.Text, TXT6.Text))
            {
                MessageBox.Show($"Student aangemaakt");
                _verkiezingDB.SelectPartijen();
            }
            else
            {
                MessageBox.Show($"Aanmaken mislukt");
            }
            this.Close();
        }


    }
}
