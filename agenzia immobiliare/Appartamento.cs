using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenzia_immobiliare
{
    internal class Appartamento : Immobile
    {
        public int NumeroVani { get; set; }
        public int NumeroBagni { get; set; }

        public Appartamento () { }

        public Appartamento(string codice, string indirizzo, string cap, string citta, int superficie, int numerovani, int numerobagni) : base(codice, indirizzo, cap, citta, superficie)
        {
            this.NumeroVani = numerovani;
            this.NumeroBagni = numerobagni;
        }

        public override string ToString()
        {
            return string.Format("Codice: {0}, Indirizzo: {1}, Cap: {2}, Città: {3}, Superficie: {4}, NumeroVani: {5}, NumeroBagni: {6}", Codice, Indirizzo, Cap, Citta, Superficie, NumeroVani, NumeroBagni);
        }
    }

    
}
