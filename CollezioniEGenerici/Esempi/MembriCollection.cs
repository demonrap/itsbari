using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollezioniEGenerici.Esempi
{

    /*
     *  Count: restituisce il numero di elementi presenti nell'ArrayList.

        Add(object item): aggiunge un elemento all'ArrayList.

        Remove(object item): rimuove un elemento specifico dall'ArrayList.

        RemoveAt(int index): rimuove l'elemento all'indice specificato dall'ArrayList.

        Clear(): rimuove tutti gli elementi dall'ArrayList.

        Contains(object item): determina se l'elemento specificato è presente nell'ArrayList.

        IndexOf(object item): restituisce l'indice della prima occorrenza dell'elemento specificato nell'ArrayList.

        ToArray(): restituisce un array contenente tutti gli elementi dell'ArrayList.

     */

    internal class MembriCollection
    {
        public void Conta() 
        {
            var listaInt = new List<int>();
            listaInt.Add(0);
            listaInt.Add(1);
            listaInt.Add(2);
            listaInt.Add(3);

            listaInt.Remove(3);
            listaInt.RemoveAt(0);

            Console.WriteLine(listaInt.Count);
            
        }

        public void ContaStrutture() 
        {
            var strutture = new List<Strutture>();

            strutture.Add(new Strutture()
            {
                NomeStruttura = "Struttura1",
                NumeroGiocatori = 2,
                Giocatori = AddGiocatori()
            }) ;
            strutture.Add(new Strutture() { 
                NomeStruttura = "AStruttura2", 
                NumeroGiocatori = 4 
            });


            var filter = strutture
                .Where(struttura => struttura.NomeStruttura.Contains("St"))
                .ToList();
                //.ForEach(x => Console.WriteLine(x.NomeStruttura));

            foreach(var x in filter)
            {
                Console.WriteLine(x.NomeStruttura);
            }

            Console.WriteLine(strutture.Count);
            strutture.Clear();
            Console.WriteLine(strutture.Count);
        }

        private List<Giocatori> AddGiocatori()
        {
            var giocatori = new List<Giocatori>();
            giocatori.Add(new Giocatori()
            {
                Cognome = "Belviso",
                Nome = "Saverio"
            });

            return giocatori;
        }
    }

    internal class Strutture
    {
        public Strutture()
        {
            Giocatori = new List<Giocatori>();
        }

        public string NomeStruttura { get; set; }
        public int NumeroGiocatori { get; set; }
        public IList<Giocatori> Giocatori { get; set; }


    }

    internal class Giocatori 
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
    }
}
