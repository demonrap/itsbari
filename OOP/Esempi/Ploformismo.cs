using System;
using System.Numerics;

namespace OOP.Esempi
{
    public class Animale
    {
        public virtual void EmettereVerso() => Console.WriteLine("L'animale emette un suono generico");
    }

    public class Cane : Animale 
    {
        public override void EmettereVerso() => Console.WriteLine("Il cana abbaia");
    }

    public class Gatto : Animale 
    {
        public override void EmettereVerso() => Console.WriteLine("Il gatto miagola");
    }

    public class GliAnimali 
    {
        public void EmettereVersi()
        {
            var animale = new Animale();
            var cane = new Cane();
            var gatto = new Gatto();
            
            animale.EmettereVerso();
            cane.EmettereVerso();
            gatto.EmettereVerso();

            Animale animale2 = new Cane();
            animale2.EmettereVerso();
            Animale animale3 = new Gatto();
            animale3.EmettereVerso();

        }
    }

   
}
