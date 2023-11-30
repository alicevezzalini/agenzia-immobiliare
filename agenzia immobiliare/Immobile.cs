using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenzia_immobiliare
{
    internal class Immobile
    {
        public string Codice { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public int Superficie { get; set; }

        public Immobile() { }   //COSTRUTTORE SENZA PARAMETRI

        public Immobile(string codice, string indirizzo, string cap, string citta, int superficie) {    //COSTRUTTORE CON PARAMETRI
            this.Codice = codice;
            this.Indirizzo = indirizzo;
            this.Cap = cap; 
            this.Citta = citta;
            this.Superficie = superficie;
        }

        public override string ToString()
        {
            return string.Format("Codice: {0}, Indirizzo: {1}, Cap: {2}, Città: {3}, Superficie: {4}", Codice, Indirizzo, Cap, Citta, Superficie);
        }
    }
}
