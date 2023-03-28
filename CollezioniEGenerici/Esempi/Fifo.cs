using System;
using System.Collections.Generic;
using System.Text;

namespace CollezioniEGenerici.Esempi
{
    internal class Fifo
    {
        public void Queue() 
        {
            Queue<string> myQueue = new Queue<string>();

            // Aggiungere elementi alla coda
            myQueue.Enqueue("Primo elemento");
            myQueue.Enqueue("Secondo elemento");
            myQueue.Enqueue("Terzo elemento");

            // Visualizzare il numero di elementi nella coda
            Console.WriteLine("Numero di elementi nella coda: {0}", myQueue.Count);

            // Leggere il primo elemento senza rimuoverlo dalla coda
            Console.WriteLine("Primo elemento nella coda: {0}", myQueue.Peek());

            // Rimuovere e visualizzare gli elementi dalla coda in ordine FIFO (First-In-First-Out)
            while (myQueue.Count > 0)
            {
                string item = myQueue.Dequeue();
                Console.WriteLine("Elemento rimosso dalla coda: {0}", item);
            }

            // Visualizzare il numero di elementi nella coda dopo averli rimossi tutti
            Console.WriteLine("Numero di elementi nella coda: {0}", myQueue.Count);
        }
    }
}
