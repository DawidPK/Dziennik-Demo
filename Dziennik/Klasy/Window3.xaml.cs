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

namespace Klasy
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public event EventHandler<UcznArgs> DodanieUcznia;
        List<Szkola> szkoly;
        public Window3(List<Szkola> Szkoly)
        {
            InitializeComponent();
            refillSzkl(ComboSzklUczn, Szkoly);
            refillKlasy(ComboKllUczn, Szkoly);
            szkoly = Szkoly;
        }
        public void refillSzkl(ComboBox tak, List<Szkola> Szkoly)
        {
            tak.Items.Clear();

            foreach (Szkola szkl in Szkoly)
            {
                tak.Items.Add(szkl.nazwa);
            }
            tak.SelectedIndex = 0;
            
        }
        void refillKlasy(ComboBox ComboKlas, List<Szkola> Szkoly)
        {
            ComboKlas.Items.Clear();
            Console.WriteLine(ComboSzklUczn.SelectedIndex);
            foreach (Klasa k in Szkoly.ElementAt(ComboSzklUczn.SelectedIndex).szkola)
            {
                ComboKlas.Items.Add(k.id);
            }
            ComboKlas.SelectedIndex = 0;
        }

        private void addUczn(object sender, RoutedEventArgs e)
        {
            UcznArgs ucznArgs = new UcznArgs(nUczName.Text, nUczSurN.Text, kobieta.IsChecked == true ? Plec.kobieta : Plec.mezczyzna, ComboSzklUczn.SelectedIndex, ComboKllUczn.SelectedIndex);
            EventHandler<UcznArgs> handler = DodanieUcznia;
            handler(this, ucznArgs);
        }

        private void shol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboSzklUczn.SelectedIndex == 0) { return; }
            refillKlasy(ComboKllUczn, szkoly);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    public struct UcznArgs
    {
        public UcznArgs(string imie, string nazwisko, Plec plec, int idSzkl, int idKlasy)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            PlecUczn = plec;
            indexSzkoly = idSzkl;
            indexKlasy = idKlasy;
        }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Plec PlecUczn { get; set; }
        public int indexSzkoly { get; set; }
        public int indexKlasy { get; set; }

    }
}
