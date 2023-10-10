# rubricaWPF

### All'inizio si trovano 3 attributi privati chiamati: "numero", nome "nome", "cognome". Poi incapsuliamo facendo tasto destro sui 3 attributi.

  
    {
        private int numero;
        private string nome;
        private string cognome;

        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
    }

### Adesso si crea una istanza in cui testiamo la nostra classe

        public MainWindow()
        {
        
            InitializeComponent();
            Contatto c = new Contatto();
            c.Numero = 1;
            c.Nome = "Davide";
            c.Cognome = "Bernardi";

            Contatto[] Contatti = new Contatto[100];
            Contatti[0] = c;

            Contatti[0].Nome = "Riccardo";
            Contatti[0].Cognome = "Bianchi";
        }
    


