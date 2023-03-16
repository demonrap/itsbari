using System;

namespace Formazione
{
    internal class Program

    {
        /// <summary>
        /// Funzione principale
        /// </summary>
        /// <param name="args">accetta una arry di stringe</param>
        static void Main(string[] args)
        {
            var esempi = new Esempi();
            int[] x = { 1, 2, 3, 4,5,6,7,8,9,10 };
            Console.WriteLine(esempi.EsempioContinue(x));
        }
        #region private method
        private static string Concatena(string text1, string text2) {
            return CocncatenamentoStringhe.Concatena(text1,text2);
        }

        private static bool OperatoriLogici()
        {
            bool o = false, t = true;
            var ol = new OperatoriLogici();
            return ol.VerificaCondizioneInOr(o, t);
        }

        private static void OperatoriArtmetici()
        {
            OperatoriArtimetici.Somma(1, 2);
        }
        #endregion
    }
}
