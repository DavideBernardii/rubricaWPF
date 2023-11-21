using System;
using System.Collections.Generic;
using System.IO;
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

namespace bernardi.davide._4i.rubricaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                const int MAX = 100;
                StreamReader fin = new StreamReader("dati.csv");
                
                Contatto[] Contatti = new Contatto[MAX];

               int idx = 0;



                while (!fin.EndOfStream)
                {
                    if (idx++ < MAX)
                    {
                        string riga = fin.ReadLine();
                        Contatto c = new Contatto(riga);
                        Contatti[idx++] = c;

                    }
                    else
                        break;
                }
                for(; idx < MAX; idx++)
                {
                    Contatti[idx] = new Contatto();
                }
                dgDati.ItemsSource = Contatti;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No No!!\n\n{ex.Message}");
            }

            /*
             try
             {

                 c.Numero = 1;
                 c.Nome = "Davide";
                 c.Cognome = "Bernardi";
                 c.Email = "davide.bernardi@studenti.ittsrimini.edu.it";
                 c.Telefono = "3802020571";
                 c.CAP = "47922";

                 Contatti[0] = c;

                 Contatto c1 = new Contatto { Numero = 2, Nome = "Riccardo", Cognome = "Bianchi" };
                 Contatti[1] = c1;
                 Contatto c2 = new Contatto { 2, Nome = "", Cognome = "" };
                 Contatti[2] = c2;


             }
             catch (Exception err)
             {
                 MessageBox.Show("No no!!\n" + err.Message);
             }
             */
        }

        private void dgdati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Contatto c = e.Row.Item as Contatto;
            if (c != null) {
            if(c.Numero == 0)
                {
                    e.Row.Background = Brushes.Red;
                    e.Row.Foreground = Brushes.White;
                }
                    }
        }
    }
}