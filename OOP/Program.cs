using OOP.Esempi;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Inizio programma");
            EventoClick();
            Console.WriteLine();
            Console.WriteLine("Fine programma");
        }

        #region nome della region
        #endregion

        #region private method

        private static void Saluta()
        {
            var persona = new Persona("Saverio", 50);
            persona.Saluta();
        }

        #region poliformismo
        private static void Versi() => new GliAnimali().EmettereVersi();
        #endregion

        #region ereditarieta
        private static void EreditarietaStampaCliente()
        {
            Console.WriteLine("Inserisci il tuo nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci la tua email");
            string email = Console.ReadLine();
            
            //creo un istanza della classe clienti che eredita da anagrafica
            Clienti cliente = new Clienti();
            cliente.Nome = nome;
            cliente.Cognome = cognome;
            cliente.Email = email;

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            new AnagraficaCliente().StampaCliente(cliente);
        }

        private static void EreditarietaStampaValore() => new ClasseCheIstanza().StampaValore();
        #endregion

        #region overload dati
        private static void Overload() 
        {
            Studente studente1 = new Studente("Mario Rossi", 80);
            Studente studente2 = new Studente("Luigi Verdi", 90);


            if (studente1 < studente2)
            {
                Console.WriteLine(studente1.Nome + " ha un voto inferiore a " + studente2.Nome);
            }
            else if (studente1 > studente2)
            {
                Console.WriteLine(studente1.Nome + " ha un voto superiore a " + studente2.Nome);
            }
            else
            {
                Console.WriteLine(studente1.Nome + " e " + studente2.Nome + " hanno lo stesso voto");
            }
        }
        #endregion

        #region delegate e handler
        private static void EventoClick()
        {
            // Creazione di un oggetto Button
            Button myButton = new Button();

            // Associare il metodo handler al evento Click
            myButton.Click += myButton.MyButtonClickHandler;

            // Generazione dell'evento Click
            myButton.OnClick(EventArgs.Empty);
        }
        #endregion



        #endregion

    }
}
