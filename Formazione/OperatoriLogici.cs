using System;
using System.Collections.Generic;
using System.Text;

namespace Formazione
{
    //& | ^ ! ~ && || true false

    internal class OperatoriLogici
    {
        /// <summary>
        /// Condizione di verifica operatore &&
        /// </summary>
        /// <param name="one">bool</param>
        /// <param name="two">bool</param>
        /// <returns>true/fale</returns>
        public bool VerificaCondizioneInAnd(bool one, bool two) => (one && two);

        public bool VerificaCondizioneInOr(bool one, bool two) => (one || two);
        public bool VerificaCondizioneInOr(int one, int two) => (one >= two);
    }
}
