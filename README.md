# rubricaWPF

##MainWindow.xaml.cs
```c#
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
                    if (idx < MAX)
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

##Contatto.cs
```c#

internal class Contatto
    {
        private int _numero;
        private string _cognome;

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (!(value >= 0) && !(value < 100))
                    throw new ArgumentOutOfRangeException();

                _numero = value;
            }
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Citta { get; set; }
        public string CAP { get; set; }
        public string Cognome { get => _cognome; set => _cognome = value; }

        public Contatto()
        {

        }

        public Contatto(string riga)
        {
            string[] campi = riga.Split(';');
            if (campi.Length >= 5)
            {
                int pk = 0;
                int.TryParse(campi[0], out pk);

                    
                    this.Nome = campi[1];
                    this.Cognome = campi[2];
                    this.Telefono = campi[3];
                this.Email = campi[4];
                    
                int.TryParse(campi[0], out pk);
                this.Numero = pk;

            }
        }
        public Contatto(int numero, string nome, string cognome)
        {
            Numero = numero;
            Nome = nome;
            Cognome = cognome;
        }
        }
  



