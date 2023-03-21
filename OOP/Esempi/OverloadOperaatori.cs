using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Esempi
{
    /// <summary>
    /// Esempio sovraccarico dell'operatore > di e < di
    /// </summary>
    public class Studente
    {
        public string Nome { get; set; }
        public int Voto { get; set; }

        public Studente(string nome, int voto)
        {
            Nome = nome;
            Voto = voto;
        }

        public static bool operator <(Studente studente1, Studente studente2) => studente1.Voto < studente2.Voto;

        public static bool operator >(Studente studente1, Studente studente2)
        {
            return studente1.Voto > studente2.Voto;
        }
        
    }

    /// <summary>
    /// Esmpio di sovraccarico dell'operatore + calcolo di un punto cartesiano
    /// </summary>
    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
            
        }

        public static Punto operator +(Punto punto1, Punto punto2) => new Punto(punto1.X + punto2.X, punto1.Y + punto2.Y);
    }
}
