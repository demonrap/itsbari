using System;

namespace OOP
{
    internal class Persona
    {
        // Campi privati
        private string nome;
        private int eta;

        // Proprietà
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }

        // Metodi
        public void Saluta()
        {
            Console.WriteLine("Ciao, mi chiamo " + Nome + " e ho " + Eta + " anni.");
        }
        

        // Costruttore
        public Persona(string nome, int eta)
        {
            this.nome = nome;
            this.eta = eta;
        }

        // Distruttore
        ~Persona()
        {
            this.nome = null;
            // Codice per deallocare eventuali risorse
        }
    }
}
