using System;

namespace Formazione
{
    internal static class EsempiStringhe
    {
        /// <summary>
        /// interpolazione fra stringhe
        /// </summary>
        /// <param name="text1"><see cref="string"/></param>
        /// <param name="text2"><see cref="string"/></param>
        /// <returns>ritorna <see cref="string"/></returns>
        internal static string Interpolazione(string text1, string text2)
        {            
            return $"{text1} {text2}, oggi {DateTime.Now}, uso interpolazione";
        }

        /// <summary>
        /// concatena stringhe usando string.format
        /// </summary>
        /// <param name="text1"><see cref="string"/></param>
        /// <param name="text2"><see cref="string"/></param>
        /// <returns>ritorna <see cref="string"/></returns>
        internal static string Format(string text1, string text2)
        {
            return string.Format("{0} {1} oggi è {2}, uso il metodo string format", text1, text2, DateTime.Now);
        }        
    }
}
