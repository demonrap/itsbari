namespace Formazione.Esempi
{
    internal class EsempiCondizionali
    {
        /// <summary>
        /// Valuta la condizione in if
        /// </summary>
        /// <param name="text"><see cref="string"/></param>
        /// <returns>ritorna string vuota o valorizzata</returns>
        public string ValutaIf(string? text = null)
        {
            if (text == null) return "";
            else if (text.Contains("bella")) return "Bella";
            else return text;
        }

        /// <summary>
        /// Valuta switch
        /// </summary>
        /// <param name="giorno">enumeratore giorno</param>
        /// <returns><see cref="string"/></returns>
        public string ValutaSwitch(Giorni giorno)
        {
            return giorno switch
            {
                Giorni.Lunedi => "Lunedi",
                Giorni.Martedi => "Martedi",
                _ => "Altri giorni della settimana",
            };
        }

        /// <summary>
        /// Ritorna la stringa se l'oggetto di rifermento non è null
        /// </summary>
        /// <param name="model"><see cref="Customer"/></param>
        /// <returns><see cref="string"/></returns>
        public string NullCondizionale(Customer model)
        {
            string result = model?.Name;
            return result;
        }
    }
}
