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
using System.Windows.Navigation;
using System.Windows.Shapes;
public enum Plec
{
    kobieta = 0,
    mezczyzna = 1
}
namespace Klasy
{
public class Uczen
{

    public string imie;
    public string nazwisko;
    public Plec plec;
    public int inteligencja;
    public int sila;
    public string id;
    public int nrDziennik;


    public Uczen(string imie, string nazwisko, Plec plec, int inteligencja, int sila)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.plec = plec;
        this.inteligencja = inteligencja;
        this.sila = sila;
        Random rnd = new Random();
        id = rnd.Next(1, 100).ToString();
    }

    public void Wyswietl()
    {
        Console.WriteLine("------------ Uczen " + this.imie + " " + this.nazwisko + " [id: " + this.id + "] i jego supermoce: ------------");
        Console.WriteLine(" ----- Inteligencja: " + this.inteligencja);
        Console.WriteLine(" ----- Sila: " + this.sila);
        Console.WriteLine(" ----- Plec: " + this.plec);
    }
}
public class Klasa
{
    // private Uczen[] klasa;
    public List<Uczen> klasa = new List<Uczen>();
    public Uczen[] tablica = new Uczen[30];
    public double srednia_inteligencja;
    public double srednia_sila;
    public double procent_m;
    public double procent_k;
    public int liczba_uczniow;
    public int liczba_k;
    public int liczba_m;
    public string id;
    private int l;
    public void AddUczen(Uczen uczen)
    {
        l++;
        klasa.Add(uczen);
        //Dodawanie oznaczenia klasy do id znajdujacych sie w niej uczniow
        uczen.id = this.id + l;
        uczen.nrDziennik =  l;

        Procent_k();
        Procent_m();
        SredniaInteligencja();
        SredniaSila();
        this.liczba_uczniow = klasa.Count;
    }

    public Klasa(string id)
    {
        this.id = id;
        this.l = 0;
        this.liczba_k = 0;
        this.liczba_m = 0;
    }

    public void Wyswietl()
    {
        Console.WriteLine("===================================================== Klasa  " + this.id + " ============================================================= ");
        Console.WriteLine("liczba uczniow: " + this.liczba_uczniow + "  ||  mezczyzni:  " + this.procent_m + "%  ||  kobiety:  " + this.procent_k + "%  ||  srednia inteligencja:  " + this.srednia_inteligencja + "  ||  srednia sila:  " + this.srednia_sila + " ");
        Console.WriteLine("============================================================================================================================= ");
        foreach (var uczen in klasa)
        {
            uczen.Wyswietl();
        }
        Console.WriteLine("");

    }

    public double Procent_m()
    {
        double n = 0;
        liczba_m = 0;
        foreach (var uczen in klasa)
        {
            if (uczen.plec == Plec.mezczyzna)
            {
                n++;
                liczba_m++;
            }
        }
        n = Math.Round((n / klasa.Count) * 100, 2);
        this.procent_m = n;
        return n;
    }
    public double Procent_k()
    {
        double n = 0;
        liczba_k = 0;
        foreach (var uczen in klasa)
        {
             
            if (uczen.plec == Plec.kobieta)
            {
                liczba_k++;
                n++;
            }
        }
        n = Math.Round((n / klasa.Count) * 100, 2);
        this.procent_k = n;
        return n;
    }
    public double SredniaInteligencja()
    {
        double srednia = 0;
        foreach (var uczen in klasa)
        {
            srednia += uczen.inteligencja;
        }
        srednia /= klasa.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_inteligencja = srednia;
        return srednia;
    }
    public double SredniaSila()
    {
        double srednia = 0;
        foreach (var uczen in klasa)
        {
            srednia += uczen.sila;
        }
        srednia /= klasa.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_sila = srednia;
        return srednia;
    }
}
public class Szkola
{
    public List<Klasa> szkola = new List<Klasa>();
    public int ilosc_klas;
    public int liczba_uczniow;
    public string nazwa;
    public string id;
    public double srednia_inteligencja;
    public double srednia_sila;
    public double procent_m;
    public double procent_k;

    public void AddKlasa(Klasa dodawana)
    {
        //Dodawanie oznaczenia szkoly do id znajdujacych sie w niej uczniow
        foreach (var uczen in dodawana.klasa)
        {
            uczen.id = "zsl" + uczen.id;
        }

        szkola.Add(dodawana);
        Procent_k();
        Procent_m();
        SredniaInteligencja();
        SredniaSila();
        LiczbaUczniow();

        this.ilosc_klas = szkola.Count;

    }
    public Szkola(string nazwa, string id)
    {
        this.nazwa = id;
        this.nazwa = nazwa;
    }
    public void Wyswietl()
    {
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("=================================================       " + this.nazwa + "       ========================================================");
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("ilosc klas: " + this.ilosc_klas + "  ||  liczba uczniow: " + this.liczba_uczniow + "  ||  mezczyzni:  " + this.procent_m + "%  ||  kobiety:  " + this.procent_k + "%  ||  srednia inteligencja:  " + this.srednia_inteligencja + "  ||  srednia sila:  " + this.srednia_sila);
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("");
        foreach (var klasa in szkola)
        {
            klasa.Wyswietl();
        }

        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

    }
    public double Procent_m()
    {
        double n = 0;
        foreach (var klasa in szkola)
        {
            n += klasa.procent_m;
        }
        n /= szkola.Count;
        n = Math.Round(n, 2);
        this.procent_m = n;
        return n;
    }
    public double Procent_k()
    {
        double n = 0;
        foreach (var klasa in szkola)
        {
            n += klasa.procent_k;
        }
        n /= szkola.Count;
        n = Math.Round(n, 2);
        this.procent_k = n;
        return n;
    }
    public double SredniaInteligencja()
    {
        double srednia = 0;
        foreach (var klasa in szkola)
        {
            srednia += klasa.srednia_inteligencja;
        }
        srednia /= szkola.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_inteligencja = srednia;
        return srednia;
    }
    public double SredniaSila()
    {
        double srednia = 0;
        foreach (var klasa in szkola)
        {
            srednia += klasa.srednia_sila;
        }
        srednia /= szkola.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_sila = srednia;
        return srednia;
    }
    public int LiczbaUczniow()
    {
        int n = 0;
        foreach (var klasa in szkola)
        {
            n += klasa.liczba_uczniow;
        }
        this.liczba_uczniow = n;
        return n;
    }
}


    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*public event EventHandler<ClassArgs> ZmianaKlasy;
        public event EventHandler<ClassArgs> ZmianaSzkoły;*/
        public int aktSzkl, aktKl, aktUczn;
        Random rnd = new Random();
        Window1 win1; //Szkoły
        Window2 win2; //Klasy
        Window3 win3; //Uczen

        void genUczn(Szkola sk)
        {
            string[] mimiona = { "Belzebub", "Ignacy", "Bozydar", "Korniszon", "Waclaw", "Jerzy", "Misiek", "Bronislaw" };
            string[] kimiona = { "Konstancja", "Izyda", "Genowefa", "Kunegunda", "Oksana", "Jagoda", "Kamila", "Julita" };
            string[] nazwiska = { "Wieczorek", "Kielbasa", "Ryszard", "Nowak", "Podloga", "Ozorek", "Sosna", "Bagienko", "Przystan", "Michalek", "Olej", "Kowal" };

            foreach (Klasa k in sk.szkola)
            {

                for (int i = 0; i <= 30; i++)
                {
                    Uczen u1 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], (Plec)rnd.Next(0, 2), rnd.Next(0, 99), rnd.Next(0, 99));
                    k.AddUczen(u1);
                }
            }

        }
        void GenKlasy(Szkola sk)
        {
            for (int i = 1; i <= 5; i++)
            {
                Klasa k1 = new Klasa(i + "a");
                Klasa k2 = new Klasa(i + "b");
                Klasa k3 = new Klasa(i + "c");
                Klasa k4 = new Klasa(i + "d");
                sk.AddKlasa(k1);
                sk.AddKlasa(k2);
                sk.AddKlasa(k3);
                sk.AddKlasa(k4);
            }
        }
       
        Szkola ZSL = new Szkola("Zespół Szkół Łączności", "ZSŁ");
        Szkola EG = new Szkola("Zespół Szkół Energetycznych", "EG");
        Szkola PSR = new Szkola("Pomorskie Szkoły Rzemiosł", "PSR");
        public List<Szkola> Szkoly = new List<Szkola>();
    
        public MainWindow()
        {
            Szkoly.Add(ZSL);
            Szkoly.Add(EG);
            Szkoly.Add(PSR);
            InitializeComponent();
            GenKlasy(Szkoly.ElementAt(0));
            GenKlasy(Szkoly.ElementAt(1));
            GenKlasy(Szkoly.ElementAt(2));
            shol.Items.Add(Szkoly.ElementAt(0).nazwa);

            shol.Items.Add(Szkoly.ElementAt(1).nazwa);

            shol.Items.Add(Szkoly.ElementAt(2).nazwa);
            genUczn(ZSL);
            genUczn(EG);
            genUczn(PSR);
            //refillSzkl(ComboSzkl);
            //refillSzkl(ComboSzklUczn);
            //refillKlasy(ComboKllUczn, ComboSzklUczn.SelectedIndex);
            aktSzkl = -1;

        }





        void clearWindows() 
        {
            if(win1 != null) { win1.Close(); }
            if (win2 != null) { win2.Close(); }
            if (win3 != null) { win3.Close(); }
        }
        public void addSzkl(object sender, string Name)
        {
            Console.WriteLine(Name);
            Szkola szkl = new Szkola(Name, Name);
            Szkoly.Add(szkl);
            shol.Items.Add(Szkoly.ElementAt(Szkoly.Count - 1).nazwa);
            //refillSzkl(ComboSzkl);
            //refillSzkl(ComboSzklUczn);

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //refillKlasy(ComboKllUczn, ComboSzklUczn.SelectedIndex);
        }
        private void shol_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            Console.WriteLine("Zmiana Szkoły");
            int ID = shol.SelectedIndex;
            foreach(Klasa k in Szkoly.ElementAt(ID).szkola)
            {
                klas.Items.Add(k.id);
            }
            //refillKlasy(ComboKllUczn, ComboSzklUczn.SelectedIndex);
        }

        private void addKlas(object sender, ClassArgs e)
        {
            Klasa kl = new Klasa(e.Nazwa);
            int id = e.indexKlasy;
            Szkoly.ElementAt(id).AddKlasa(kl);
            if (id == aktSzkl)
            {
                klas.Items.Add(kl.id);
            }
           /* if (id == ComboSzklUczn.SelectedIndex)
            {
                refillKlasy(ComboKllUczn, id);
            }*/

        }

        private void addUczn(object sender, UcznArgs e)
        {
            Uczen u = new Uczen(e.Imie, e.Nazwisko, e.PlecUczn, rnd.Next(0, 99), rnd.Next(0, 99));
            Szkoly.ElementAt(e.indexSzkoly).szkola.ElementAt(e.indexKlasy).AddUczen(u);
            if(shol.SelectedIndex == e.indexSzkoly && klas.SelectedIndex == e.indexKlasy) { uczen.Items.Add(u.nazwisko); }
        }

        private void nSzkola_Click()
        {
            clearWindows();
            win1 = new Window1();
            win1.Show();
            win1.DodanieSzkoly += addSzkl;
        }

        private void shol_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            aktSzkl = shol.SelectedIndex;
            aktKl = -1;
            aktUczn = -1;
            klas.Items.Clear();
            uczen.Items.Clear();
            info.Items.Clear();
            if (aktSzkl < 0) { return; }
            Szkola szk = (Szkola)Szkoly.ElementAt(aktSzkl);
            foreach (Klasa k in szk.szkola)
            {
                klas.Items.Add(k.id);
            }
            if (aktSzkl != -1)
            {
                info.Items.Add("Nazwa Szkoły: " + szk.nazwa);
                info.Items.Add("Ilość klas: " + szk.ilosc_klas);
                
                info.Items.Add("Liczba Uczniów: " + szk.LiczbaUczniow());
                if(Double.IsNaN(szk.SredniaInteligencja())) { return; }
                info.Items.Add("Średnia Inteligencja: " + szk.SredniaInteligencja());
                
                info.Items.Add("Średnia Siła: " + szk.SredniaSila());
                info.Items.Add("Procent kobiet w szkole: " + szk.Procent_k() + "%");
                info.Items.Add("Procent mężczyzn w szkole: " + szk.Procent_m() + "%");
            }
        }

        private void nKlasa_Click()
        {
            clearWindows();
            win2 = new Window2(shol);
            win2.Show();
            win2.DodanieKlasy += addKlas;

        }

        private void nUczen_Click()
        {
            clearWindows();
            win3 = new Window3(Szkoly);
            win3.Show();
            win3.DodanieUcznia += addUczn;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            string content = wToAddSel.Text;
            switch (content)
            {
                case "Szkołę":
                    nSzkola_Click();
                    break;
                case "Klasę":
                    nKlasa_Click();
                    break;
                case "Ucznia":
                    nUczen_Click();
                    break;
                default:
                    break;
            }
        }
        private void delSzkola(int index) { 
            if(index < 0 || index > Szkoly.Count - 1) 
            {
                MessageBox.Show("Proszę wybrać poprawną Szkołę", "Wystąpił błąd w usuwaniu");
                
                return;
            }
            string message = "Jesteś pewien, że chcesz usunąć " + Szkoly.ElementAt(index).nazwa + "?";
            if (MessageBox.Show(message, "Uwwaga", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            shol.Items.RemoveAt(index);
            Szkoly.RemoveAt(index);


        }
        private void delKlasa(int index) {
            if (index < 0 || index > Szkoly.ElementAt(aktSzkl).szkola.Count - 1)
            {
                MessageBox.Show("Proszę wybrać Klasę, którą chcesz usunąć", "Wystąpił błąd w usuwaniu");

                return;
            }
            string message = "Jesteś pewien, że chcesz usunąć Klasę " + Szkoly.ElementAt(aktSzkl).szkola.ElementAt(index).id + "?";
            if (MessageBox.Show(message, "Uwwaga", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }

            klas.Items.RemoveAt(index);
            Szkoly.ElementAt(aktSzkl).szkola.RemoveAt(index); 
            
        }
        private void delUczen(int index) 
        {
            if (index < 0 || index > Szkoly.ElementAt(aktSzkl).szkola.ElementAt(aktKl).klasa.Count - 1)
            {
                MessageBox.Show("Proszę wybrać Ucznia, którego chcesz usunąć", "Wystąpił błąd w usuwaniu");

                return;
            }
            Uczen u = Szkoly.ElementAt(aktSzkl).szkola.ElementAt(aktKl).klasa.ElementAt(index);
            string message = "Jesteś pewien, że chcesz usunąć Ucznia " + u.imie + " " + u.nazwisko + "?"; 
            if (MessageBox.Show(message, "Uwwaga", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            uczen.Items.RemoveAt(index);
            Szkoly.ElementAt(aktSzkl).szkola.ElementAt(aktKl).klasa.RemoveAt(index);
        }
        private void del_Click(object sender, RoutedEventArgs e)
        {
            string content = wToAddSel.Text;
            switch (content)
            {
                case "Szkołę":
                    delSzkola(shol.SelectedIndex);
                    break;
                case "Klasę":
                    delKlasa(klas.SelectedIndex);
                    break;
                case "Ucznia":
                    delUczen(uczen.SelectedIndex);
                    break;
                default:
                    break;
            }
        }


        private void klas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            aktKl = klas.SelectedIndex;
            aktUczn = 0;
            uczen.Items.Clear();
            info.Items.Clear();
            if (aktKl < 0) { return; }
            Klasa k = Szkoly.ElementAt(aktSzkl).szkola.ElementAt(aktKl);
            foreach (Uczen u in k.klasa)
            {
                uczen.Items.Add(u.nazwisko);
            }
            if(k != null) 
            {
                info.Items.Add("Nazwa Klasy: " + k.id);
                info.Items.Add("Liczba Uczniów: " + k.liczba_uczniow);
                info.Items.Add("Średnia Inteligencja: " + k.srednia_inteligencja);
                info.Items.Add("Średnia Siła: " + k.srednia_sila);
                info.Items.Add("Liczba kobiet w klasie: " + k.liczba_k);
                info.Items.Add("Liczba mężczyzn w klasie: " + k.liczba_m);
            }
        }

        private void uczen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            aktUczn = uczen.SelectedIndex;
            
            if (aktKl < 0) { return; }
            if (aktUczn < 0) { return; }
            Console.WriteLine("Akt Szkoła: " + aktSzkl + " akt Klasa: " + aktKl + " akt Uczen: " + aktUczn);
            Uczen u = (Uczen)Szkoly.ElementAt(aktSzkl).szkola.ElementAt(aktKl).klasa.ElementAt(aktUczn);
            info.Items.Clear();
            if (u != null)
            {
                info.Items.Add("Numer w dzienniku: " + u.nrDziennik);
                info.Items.Add("Imię: " + u.imie);
                info.Items.Add("Nazwisko: " + u.nazwisko);
                info.Items.Add("Płeć: " + u.plec);
                info.Items.Add("Inteligencja: " + u.inteligencja);
                info.Items.Add("Siła: " + u.sila);
                info.Items.Add("");
                info.Items.Add("Na tle klasy: ");
                info.Items.Add("Średnia inteligencja w jego klasie: " + Szkoly.ElementAt(aktSzkl).szkola.ElementAt(aktKl).srednia_inteligencja);
                info.Items.Add("Średnia siła w jego klasie: " + Szkoly.ElementAt(aktSzkl).szkola.ElementAt(aktKl).srednia_sila);
                info.Items.Add("");
                info.Items.Add("Na tle Szkoły: ");
                info.Items.Add("Średnia inteligencja w jego Szkole: " + Szkoly.ElementAt(aktSzkl).SredniaInteligencja());
                info.Items.Add("Średnia siła w jego szkole: " + Szkoly.ElementAt(aktSzkl).SredniaSila());
            }


        }
    }
}
