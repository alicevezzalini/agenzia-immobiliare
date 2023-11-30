using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenzia_immobiliare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenzia agenzia = new Agenzia("Vezzalini");
            
            Box box = new Box("box1", "ciccio", "41014", "vignola", 100, 4);
            Appartamento appartamento = new Appartamento("app1", "CICCIO", "41014", "castelnuovo", 120, 5, 2);
            Villa villa = new Villa("villa1", "ciccia", "41056", "castelvetro", 250, 10, 3, 64);

            Console.WriteLine("{0} \n {1} \n {2}", box, appartamento, villa);
            Console.ReadLine();
        }
    }
}
