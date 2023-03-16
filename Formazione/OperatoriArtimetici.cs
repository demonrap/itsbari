// artimetici + - * /

namespace Formazione
{
    internal static class OperatoriArtimetici
    {
        /// <summary>
        /// Questa funzione ritorna la somma
        /// </summary>
        /// <param name="x"><see cref="int"/></param>
        /// <param name="y">variabile y tipo intero</param>
        /// <returns>x+y</returns>
        public static int Somma(int x, int y = 0) => x + y;
        /// <summary>
        /// Moltiplicazoine
        /// </summary>
        /// <param name="x">Primo valore</param>
        /// <param name="y">Secondo valore</param>
        /// <returns>Prodotto x*y</returns>
        public static double Moltiplicazione(double x, double y) => x * y;
        /// <summary>
        /// Divisione
        /// </summary>
        /// <param name="x">Primo valore</param>
        /// <param name="y">Secondo valore</param>
        /// <returns>x/y</returns>
        public static double Divisione(double x, double y) => x / y;
    }
}
