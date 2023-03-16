using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Formazione
{
    internal class Esempi
    {
        public string EsempioStringArray() {
            string[] x = new string[3];
            x[0] = "Hello";
            x[1] = "World";
            x[2] = $"{x[0]} {x[1]}";

            string[] names = { "Saverio", "Giovanni", "" };            
            names[2] = $"{names[0]} {names[1]}";

            return names[2];

        }

        public int EsempioIntArray()
        {
            int[] x = { 1, 2, 3, 4 };
            return x[2];
        }

        public void Somma(int x, int y, ref int result) 
        {
            result = x + y;
        }

        public string ValutaIf(string? text = null) {
            if (text == null) return "";
            else if (text.Contains("bella")) return "Bella";
            else return text;
        }

        public string ValutaSwitch(Giorni giorno)
        {

            return giorno switch
            {
                Giorni.Lunedi => "Lunedi",
                Giorni.Martedi => "Martedi",
                _ => "Altri giorni della settimana",
            };
        }

        public string NullCondizionale(Customer model) 
        {
            string result = model?.Name;
            return result;
        }

        public int EsempioWhile(int[] array) 
        {
            var somma = 0;
            var indice = 0;
            while (indice < array.Length) 
            {
                somma += array[indice];
                indice++;
            }
            return somma;
        }

        public int EsempioDoWhile(int[] array)
        {
            var somma = 0;
            var indice = 0;
            do
            {
                somma += array[indice];
                indice++;
            }
            while (indice < array.Length);
            return somma;
        }

        public int EsempioFor(int[] array) {
            var somma = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                somma += array[i];
            }
            return somma;
        }

        public int EsempioForEach(int[] array) 
        {
            var somma = 0;
            foreach(var item in array) somma += item;
            return somma;
        }

        public int EsempioContinue(int[] array) 
        {
            var somma = 0;
            foreach(var item in array) 
            {
                if (item % 2 == 0) continue;
                somma += item; 
            }
            return somma;
        }
    }
}
