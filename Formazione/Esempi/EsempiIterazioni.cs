﻿using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Formazione.Esempi
{
    internal class EsempiIterazioni
    {  
        /// <summary>
        /// While
        /// </summary>
        /// <param name="array">array interi</param>
        /// <returns>torna la somma</returns>
        public int While(int[] array) 
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

        /// <summary>
        /// Do while
        /// <param name="array">array interi</param>
        /// <returns>torna la somma</returns>
        public int DoWhile(int[] array)
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

        /// <summary>
        /// For
        /// </summary>
        /// <param name="array">array interi</param>
        /// <returns>torna la somma</returns>
        public int For(int[] array) {
            var somma = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                somma += array[i];
            }
            return somma;
        }

        /// <summary>
        /// Foreach
        /// </summary>
        /// <param name="array">array interi</param>
        /// <returns>torna la somma</returns>
        public int ForEach(int[] array) 
        {
            var somma = 0;
            foreach(var item in array) somma += item;
            return somma;
        }

        /// <summary>
        /// Continue
        /// </summary>
        /// <param name="array">array interi</param>
        /// <returns>torna la somma</returns>
        public int Continue(int[] array) 
        {
            var somma = 0;
            foreach(var item in array) 
            {
                if (item % 2 == 0) continue;
                somma += item; 
            }
            return somma;
        }

        /// <summary>
        /// Break
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Break(int[] array)
        {
            var somma = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0) break;
                somma += item;
            }
            return somma;
        }
    }
}
