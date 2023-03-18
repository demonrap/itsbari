
namespace Formazione.Esempi
{
    internal static class EsempiOperatoriArtimetici
    {       

        /// <summary>
        /// Somma con referenza
        /// </summary>
        /// <param name="x"><see cref="int"/></param>
        /// <param name="y"><see cref="int"/></param>
        /// <param name="result"></param>
        public static void Somma(int x, int y, ref int result) => result = x + y;

        /// <summary>
        /// Moltiplicazoine
        /// </summary>
        /// <param name="x">Primo valore</param>
        /// <param name="y">Secondo valore</param>
        /// <returns>Prodotto x*y</returns>
        public static decimal Moltiplicazione(decimal x, decimal y) => x * y;

        /// <summary>
        /// Divisione
        /// </summary>
        /// <param name="x">Primo valore</param>
        /// <param name="y">Secondo valore</param>
        /// <returns>x/y</returns>
        public static decimal Divisione(decimal x, decimal y) => x / y;
    }
}
