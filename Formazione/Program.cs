using System;
using Formazione.Esempi;
using static System.Net.Mime.MediaTypeNames;

namespace Formazione
{
    internal class Program

    {

        private static readonly EsempiOperatoriLogici logici = new EsempiOperatoriLogici();
        private static readonly EsempiArray array = new EsempiArray();        
        private static readonly EsempiIterazioni iterazioni = new EsempiIterazioni();
        private static readonly EsempiCondizionali condizionali = new EsempiCondizionali();

        private static readonly int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /// <summary>
        /// Funzione principale
        /// </summary>
        /// <param name="args">accetta una arry di stringe</param>
        static void Main(string[] args)
        {

            Console.WriteLine("Inizio esempi artmetici");
            Console.WriteLine($"Il risultato della somma è {Somma(1, 2)}");
            var result = 0;
            Somma(5, 4, ref result);
            Console.WriteLine($"Il risultato della somma è {result}");            

            const decimal NUM1 = 10.5m; const decimal NUM2 = 3.25m;
            Moltiplicazione(NUM1, NUM2);
            Divisione(NUM1, NUM2);

            CicloEsempi("artmetici", "condizionali");

            VerificaCondizioneInOr(true, false);
            VerificaCondizioneInOr(true, true);
            VerificaCondizioneInOr(false, true);
            VerificaCondizioneInOr(false, false);


            VerificaCondizioneInAnd(true, false);
            VerificaCondizioneInAnd(true, true);
            VerificaCondizioneInAnd(false, true);
            VerificaCondizioneInAnd(false, false);

            VerificaCondizioneConfronto(5, 10);

            CicloEsempi("condizionali", "stringhe");

            Interpolazione("Luca", "Buono");
            Format("Mario", "Rossi");

            CicloEsempi("stringhe", "array");

            EsempioStringArray();
            EsempioIntArray();

            CicloEsempi("array", "iterazione");

            EsempioWhile(arrayInt);
            EsempioDoWhile(arrayInt);
            EsempioFor(arrayInt);
            EsempioForEach(arrayInt);
            EsempioContinue(arrayInt);
            EsempioBreak(arrayInt);

            CicloEsempi("iterazione", "condizionali"); ;

            ValutaIf();
            ValutaIf("Con valore");

            ValutaSwitch(Giorni.Lunedi);
            ValutaSwitch(Giorni.Martedi);
            ValutaSwitch(Giorni.Mercoledi);

            NullCondizionale(null);
            Customer customer = new Customer() { Name = "Mario" };
            NullCondizionale(customer);
            
            Console.WriteLine();
            Console.WriteLine("Fine esempi condizionali");
        }


        #region private method

        private static void CicloEsempi(string fine, string inizio)
        {
            Console.WriteLine();
            Console.WriteLine($"Fine esempi {fine}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Inizio esempi {inizio}");
            Console.WriteLine();
        }

        #region operatori artmetici
        private static int Somma(int x, int y) => x +y;
        private static void Somma(int x, int y, ref int result) => EsempiOperatoriArtimetici.Somma(x, y, ref result);
        private static void Moltiplicazione(decimal x, decimal y) => Console.WriteLine($"Il risultato del prodotto è {EsempiOperatoriArtimetici.Moltiplicazione(x, y)}");
        private static void Divisione(decimal x, decimal y) => Console.WriteLine($"Il risultato della divisione è {EsempiOperatoriArtimetici.Divisione(x, y)}");
        #endregion

        #region operatori logici
        private static void VerificaCondizioneInAnd(bool one, bool two)
        {   
            Console.WriteLine("Il risulatado della condizione in and è " + Convert.ToString(logici.VerificaCondizioneInAnd(one, two)));
        }
        private static void VerificaCondizioneInOr(bool one, bool two)
        {            
            var risultato = "Il risulatado della condizione in or è " + Convert.ToString(logici.VerificaCondizioneInOr(one, two));
            Console.WriteLine(risultato);
        }

        private static void VerificaCondizioneConfronto(int one, int two) => Console.WriteLine($"Il risulatado della condizione di confronte è {logici.VerificaCondizioneConfronto(one, two)}");
        #endregion

        #region esempi con stringhe
        private static void Interpolazione(string text1, string text2) => Console.WriteLine(EsempiStringhe.Interpolazione(text1, text2));
        private static void Format(string text1, string text2) => Console.WriteLine(EsempiStringhe.Format(text1, text2));
        #endregion

        #region esempi con array

        private static void EsempioStringArray() => Console.WriteLine($"Il risultato del string array è: ${array.EsempioStringArray()}");
        private static void EsempioIntArray() => Console.WriteLine($"Il risultato dell int array è : {array.EsempioIntArray()}");

        #endregion

        #region esempi iterazioni
        private static void EsempioWhile(int[] array) => Console.WriteLine($"la somma in while è: {iterazioni.EsempioWhile(array)}");
        private static void EsempioDoWhile(int[] array) => Console.WriteLine($"la somma in do while è: {iterazioni.EsempioDoWhile(array)}");
        private static void EsempioFor(int[] array) => Console.WriteLine($"la somma in for è: {iterazioni.EsempioFor(array)}");
        private static void EsempioForEach(int[] array) => Console.WriteLine($"la somma in foreach è: {iterazioni.EsempioForEach(array)}");
        private static void EsempioContinue(int[] array) => Console.WriteLine($"la somma in continue al verificarsi di una condizione salta è: {iterazioni.EsempioContinue(array)}");
        private static void EsempioBreak(int[] array) => Console.WriteLine($"la somma in continue al verificarsi di una condizione esce è: {iterazioni.EsempioBreak(array)}");

        #endregion

        #region condizionali
        #endregion
        private static void ValutaIf(string? text = null) {

            var condizione = string.IsNullOrEmpty(text) ? "vera" : "falsa";
            var risultato = string.IsNullOrEmpty(text) ? "stringa vuota" : "";
            Console.WriteLine($"Condizione {condizione} ritorna {risultato}: {condizionali.ValutaIf(text)} ");

        }

        private static void ValutaSwitch(Giorni giorno) => Console.WriteLine($"Il risultato della condizione switch è: {condizionali.ValutaSwitch(giorno)}");

        private static void NullCondizionale(Customer model) => Console.WriteLine($"Il risultato del null condizionale è: {condizionali.NullCondizionale(model)}");
        #endregion
    }
}
