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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public event EventHandler<ClassArgs> DodanieKlasy;
        public Window2(ListBox Szkoly)
        {
            InitializeComponent();
            refillSzkl(ComboSzkl, Szkoly);
        }
        public void refillSzkl(ComboBox tak, ListBox lista)
        {
            tak.Items.Clear();

            foreach (string szkl in lista.Items)
            {
                tak.Items.Add(szkl);
            }
            tak.SelectedIndex = 0;
        }

        private void addKlas(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(nKl.Text))
            {
                EventHandler<ClassArgs> handler = DodanieKlasy;
                ClassArgs Args = new ClassArgs(nKl.Text, ComboSzkl.SelectedIndex);
                handler(this, Args);
                

            }
        }

    }
    public struct ClassArgs
    {
        public ClassArgs(string nazwa, int index)
        {
            Nazwa = nazwa;
            indexKlasy = index;
        }

        public string Nazwa { get; set; }
        public int indexKlasy { get; set; }

    }
}
