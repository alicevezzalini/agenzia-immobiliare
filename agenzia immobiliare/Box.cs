using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenzia_immobiliare
{
    internal class Box : Immobile
    {
        public int PostiAuto { get; set; }

        public Box() { }

        public Box(string codice, string indirizzo, string cap, string citta, int superficie, int postiauto) : base(codice, indirizzo, cap, citta, superficie) {
            this.PostiAuto = postiauto;
        }

        public override string ToString()
        {
            return string.Format("Codice: {0}, Indirizzo: {1}, Cap: {2}, Città: {3}, Superficie: {4}, PostiAuto: {5}", Codice, Indirizzo, Cap, Citta, Superficie, PostiAuto);
        }
    }
}
