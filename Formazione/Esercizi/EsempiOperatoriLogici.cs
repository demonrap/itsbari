namespace Formazione
{

    internal class EsempiOperatoriLogici
    {
        /// <summary>
        /// Condizione di verifica operatore &&
        /// </summary>
        /// <param name="one">bool</param>
        /// <param name="two">bool</param>
        /// <returns>true/fale</returns>
        public bool VerificaCondizioneInAnd(bool one, bool two) => (one && two);
        /// <summary>
        /// Verifica la condizione in or
        /// </summary>
        /// <param name="one">bool</param>
        /// <param name="two">bool</param>
        /// <returns></returns>
        public bool VerificaCondizioneInOr(bool one, bool two) => (one || two);
        /// <summary>
        /// Verifica la condizione in confrono
        /// </summary>
        /// <param name="one">bool</param>
        /// <param name="two">bool</param>
        /// <returns></returns>
        public bool VerificaCondizioneConfronto(int one, int two) => (one >= two);
    }
}
