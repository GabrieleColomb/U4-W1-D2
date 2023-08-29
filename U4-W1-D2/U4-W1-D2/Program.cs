using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scegli l'esercizio da eseguire:");
            Console.WriteLine("1. Esercizio Persona");
            Console.WriteLine("2. Esercizio Prodotto");
            int scelta = Convert.ToInt32(Console.ReadLine());

            if (scelta == 1)
            {
                EseguiEsercizioPersona();
            }
            else if (scelta == 2)
            {
                EseguiEsercizioProdotto();
            }
            else
            {
                Console.WriteLine("Scelta non valida.");
            }
            Console.ReadKey();
        }

        static void EseguiEsercizioPersona()
        {
            Console.Write("inserisci il nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome: ");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci l'età: ");
            int eta = Convert.ToInt32(Console.ReadLine());

            Persona persona = new Persona(nome, cognome, eta);

            Console.WriteLine("\nDettagli della persona: ");
            Console.WriteLine(persona. GetDettagli());
        }

        static void EseguiEsercizioProdotto()
        {
            Prodotto prodotto = new Prodotto();

            Console.WriteLine("Inserisci il nome del prodotto: ");
            prodotto.NomeProdotto = Console.ReadLine();

            Console.WriteLine("Inserisci il prezzo del prodotto: ");
            prodotto.Prezzo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Inserisci la quantità del prodotto: ");
            prodotto.Quantita = Convert.ToInt32(Console.ReadLine());

            prodotto.CalcolaTotale();
        }
    }
}
