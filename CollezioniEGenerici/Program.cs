using CollezioniEGenerici.Esempi;
using System;


namespace CollezioniEGenerici
{
    internal class Program
    {
        private static readonly MembriCollection collection = new MembriCollection();
        static void Main()
        {
            Console.WriteLine("Inizio programma");

            int? numero = null;

            
            var diz = new Dizionari();
            diz.UnionIntersectExpectWith();
            Console.WriteLine();
            Console.WriteLine("Fine programma");
        }

        #region private method

        private static void Clona()
        {
            CollectionClonable obj1 = new CollectionClonable { Value = 10 };
            CollectionClonable obj2 = (CollectionClonable)obj1.Clone();

            Console.WriteLine("obj1.Value: {0}", obj1.Value); 
            Console.WriteLine("obj2.Value: {0}", obj2.Value);

            Console.WriteLine("---------------");

            obj1.Value = 20;

            Console.WriteLine("obj1.Value: {0}", obj1.Value); 
            Console.WriteLine("obj2.Value: {0}", obj2.Value); 
        }

        private static void ListaGenerica() 
        {
            ListaGenerica<int> lista1 = new ListaGenerica<int>();

            lista1.Aggiungi(1);
            lista1.Aggiungi(2);
            lista1.Aggiungi(3);

            foreach (int n in lista1)
            {
                Console.WriteLine(n);
            }

            // Crea una lista di stringhe
            ListaGenerica<string> lista2 = new ListaGenerica<string>();

            lista2.Aggiungi("Ciao");
            lista2.Aggiungi("Mondo");

            foreach (string s in lista2)
            {
                Console.WriteLine(s);
            }
        }

        private static void ControVarianza() => new ControVarianza().Esegui();

       

        #endregion
    }
}
