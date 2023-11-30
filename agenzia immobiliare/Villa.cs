using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenzia_immobiliare
{
    internal class Villa : Appartamento
    {
        public int Giardino { get; set; }

        public Villa() { }

        public Villa(string codice, string indirizzo, string cap, string citta, int superficie, int numerovani, int numerobagni, int giardino) : base(codice, indirizzo, cap, citta, superficie, numerovani, numerobagni)
        {
            this.Giardino = giardino;
        }

        public override string ToString()
        {
            return string.Format("Codice: {0}, Indirizzo: {1}, Cap: {2}, Città: {3}, Superficie: {4}, NumeroVani: {5}, NumeroBagni: {6}, Giardino: {7}", Codice, Indirizzo, Cap, Citta, Superficie, NumeroVani, NumeroBagni, Giardino);
        }
    }
}
