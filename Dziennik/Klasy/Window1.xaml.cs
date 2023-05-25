using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public event EventHandler<string> DodanieSzkoly;
        
        public Window1()
        {
            InitializeComponent();
            
        }

        void addSzkl(object sender, RoutedEventArgs e)
        {
            
            if (!string.IsNullOrEmpty(nSzkl.Text))
            {
                EventHandler<string> handler = DodanieSzkoly;
                //Console.WriteLine("To jest tekst z okienka " + nSzkl.Text);
                handler(this, nSzkl.Text);
            }

        }
    }
    
}
