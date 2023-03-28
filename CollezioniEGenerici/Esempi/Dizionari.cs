using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollezioniEGenerici.Esempi
{
    internal class Dizionari
    {
        public void UnionIntersectExpectWith()
        {
            var dizionario1 = new Dictionary<string, int> {
                { "uno", 1 },
                { "due", 2 },
                { "tre", 3 },
                { "quattro", 4 }
            };

            Dictionary<string, int> dizionario2 = new Dictionary<string, int>
            {
                { "tre", 3 },
                { "quattro", 4 },
                { "cinque", 5 },
                { "sei", 6 }
            };

            dizionario1.Add("otto", 8);


            // Unione tra i due dizionari
            foreach (var coppia in dizionario2)
            {
                if (!dizionario1.ContainsKey(coppia.Key))
                {
                    dizionario1.Add(coppia.Key, coppia.Value);
                }
            }

            Console.WriteLine("Unione tra i due dizionari:");
            foreach (var coppia in dizionario1)
            {
                Console.WriteLine($"{coppia.Key}: {coppia.Value}");
            }

            // Intersezione tra i due dizionari
            foreach (var coppia in dizionario1.ToList())
            {
                if (!dizionario2.ContainsKey(coppia.Key))
                {
                    dizionario1.Remove(coppia.Key);
                }
            }

            Console.WriteLine("Intersezione tra i due dizionari:");
            foreach (var coppia in dizionario1)
            {
                Console.WriteLine($"{coppia.Key}: {coppia.Value}");
            }

            // Differenza tra i due dizionari
            foreach (var coppia in dizionario2)
            {
                if (dizionario1.ContainsKey(coppia.Key))
                {
                    dizionario1.Remove(coppia.Key);
                }
            }

            Console.WriteLine("Differenza tra i due dizionari:");
            foreach (var coppia in dizionario1)
            {
                Console.WriteLine($"{coppia.Key}: {coppia.Value}");
            }
        }

        public void UnionIntersectExpectHash()
        {
            var nomi1 = new HashSet<string>();
            nomi1.Add("Mario");
            nomi1.Add("Giuseppe");

            var nomi2 = new HashSet<string>();
            nomi2.Add("Mario");
            nomi2.Add("Elena");
            nomi2.Add("Francesca");

            nomi1.UnionWith(nomi2);

            nomi2.Intersect(nomi1);

            nomi1.ExceptWith(nomi2);
        }
    }
}
