using System;
using System.Collections.Generic;
using System.Text;

namespace Formazione
{
    internal static class CocncatenamentoStringhe
    {
        internal static string Concatena(string text1, string text2)
        {
            //return string.Format("{0} {1}", text1, text2);
            return $"{text1} {text2}, oggi {DateTime.Now}";
        }
    }
}
