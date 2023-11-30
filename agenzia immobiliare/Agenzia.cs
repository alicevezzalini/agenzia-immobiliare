using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenzia_immobiliare
{
    internal class Agenzia
    {
        public string Nome { get; set; }

        public List<Immobile> Immobili { get; set; }
        
        public Agenzia(string nome)
        {
            this.Nome = nome;
            this.Immobili = Immobili;
        }

        public void AggiungiImmobile(Immobile immobile)
        {
            this.Immobili.Add(immobile);
        }

       

    }
}
