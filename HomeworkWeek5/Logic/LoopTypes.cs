using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkWeek5.Logic
{
    public class LoopTypes
    {

        public int[] ReSort(int num1, int num2, int num3, int num4, int num5, int indice)
        {
            int[] array1 = { num1, num2, num3, num4, num5 };
            int[] array2 = new int[array1.Length];


            if (indice > array1.Length)
            {
                indice = indice % array1.Length != 0 ? indice % array1.Length : 0;
                indice = (indice % array1.Length) == 0 ? 5 : indice;
                indice = indice - 1;
            }
            else
            {
                indice = indice - 1;
            }

            int temp = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (indice == array1.Length)
                {
                    indice = 0;
                }

                if (indice == -1)
                {
                    indice++;
                }

                if (indice < 0)
                {
                    indice = 0;
                }

                temp = array1[i];
                array2[i] = array1[indice];

                indice++;

            }




            return array2;
        }

    }   

}
