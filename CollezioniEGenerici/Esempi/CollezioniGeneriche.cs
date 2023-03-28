using System;
using System.Collections.Generic;
using System.Text;

namespace CollezioniEGenerici.Esempi
{
    public class Persona : IComparable<Persona>
    {
        public string Nome { get; set; }
        public int Età { get; set; }

        public int CompareTo(Persona other)
        {
            return this.Età.CompareTo(other.Età);
        }
    }

    public class ComparePersona
    {
        public void CompareTo() 
        {
            Persona p1 = new Persona { Nome = "Mario", Età = 30 };
            Persona p2 = new Persona { Nome = "Luigi", Età = 25 };

            int confronto = p1.CompareTo(p2);

            if (confronto > 0)
            {
                Console.WriteLine($"{p1.Nome} è più vecchio di {p2.Nome}");
            }
            else if (confronto == 0)
            {
                Console.WriteLine($"{p1.Nome} e {p2.Nome} hanno la stessa età");
            }
            else
            {
                Console.WriteLine($"{p1.Nome} è più giovane di {p2.Nome}");
            }
        }

        public void CompareEquality()
        {
            PersonaEquality p1 = new PersonaEquality { Nome = "Mario", Età = 30 };
            PersonaEquality p2 = new PersonaEquality { Nome = "mario", Età = 25 };

            ComparatorePerNome comparatore = new ComparatorePerNome();

            if (comparatore.Equals(p1, p2))
            {
                Console.WriteLine($"{p1.Nome} e {p2.Nome} sono considerati uguali");
            }
            else
            {
                Console.WriteLine($"{p1.Nome} e {p2.Nome} non sono considerati uguali");
            }
        }
    }

    public class PersonaEquality
    {
        public string Nome { get; set; }
        public int Età { get; set; }       
    }

    public class ComparatorePerNome : IEqualityComparer<PersonaEquality>
    {
        public bool Equals(PersonaEquality x, PersonaEquality y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.Nome.Equals(y.Nome, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(PersonaEquality obj)
        {
            return obj.Nome.ToUpper().GetHashCode();
        }
    }
}
