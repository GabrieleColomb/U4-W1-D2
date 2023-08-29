using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D2
{
    internal class Prodotto
    {
        public string NomeProdotto { get; set; }
        public decimal Prezzo { get; set; }
        public int Quantita { get; set; }

        public void CalcolaTotale()
        {
            decimal costoTotale = Prezzo * Quantita;
            Console.WriteLine($"Il costo totale del prodotto {NomeProdotto} è: {costoTotale}");
        }
    }
}
