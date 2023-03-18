namespace Formazione.Esempi
{
    internal class EsempiArray
    {
        /// <summary>
        /// Esempio di string array
        /// </summary>
        /// <returns><see cref="string"/></returns>
        public string EsempioStringArray()
        {
            string[] x = new string[3];
            x[0] = "Hello";
            x[1] = "World";
            x[2] = $"{x[0]} {x[1]}";            

            return x[2];

        }

        /// <summary>
        /// Esempio di int array
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int EsempioIntArray()
        {
            int[] x = { 1, 2, 3, 4 };
            return x[2];
        }
    }
}
