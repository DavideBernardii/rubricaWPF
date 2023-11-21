using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bernardi.davide._4i.rubricaWPF
{
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
                if (!(value > 0) && !(value > 100))
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
}