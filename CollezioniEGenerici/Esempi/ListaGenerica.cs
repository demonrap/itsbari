using System;
using System.Collections.Generic;

namespace CollezioniEGenerici.Esempi
{
    public class ListaGenerica<T>
    {
        private List<T> elementi = new List<T>();

        public void Aggiungi(T elemento)
        {
            elementi.Add(elemento);
        }

        public IEnumerator<T> GetEnumerator()
        {

            HashSet<string> nomi = new HashSet<string>();

            nomi.Add("Mario");
            nomi.Add("Luigi");
            nomi.Add("Paolo");
            nomi.Add("Mario"); // questo elemento viene ignorato perché già presente

            Console.WriteLine($"Il numero di elementi in 'nomi' è {nomi.Count}");

            return elementi.GetEnumerator();
        }
    }    
}
