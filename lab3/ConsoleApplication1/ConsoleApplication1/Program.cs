using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        
        //задания 77 / 97 / 117
        public static void Main(string[] args)
        {
          //  lab77 lab = new lab77();
          //  lab97 lab = new lab97();
          //  lab117 lab = new lab117();
          
        }
    }
    
    
    /*
     * Дан массив размера N. Возвести в квадрат все его локальные минимумы (то есть числа, меньшие своих соседей)
     */
    public class lab77
    {
        public lab77()
        {
            int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9 }; // пример исходного массива
            int[] squaredArray = SquareLocalMinima(array);
        
            foreach (var num in squaredArray)
            {
                Console.Write(num + " ");
            }
        }

        int[] SquareLocalMinima(int[] array)
        {
            int[] result = new int[array.Length];
            result[0] = array[0];
            result[array.Length-1] = array[array.Length-1];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    result[i] = array[i] * array[i];
                }
                else
                {
                    result[i] = array[i];
                }
            }
            return result;
        }
    }

    
    /*
     * Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы, оставив их последние вхождения
     */
    public class lab97
    {
        public lab97()
        {
            int[] array = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 8, 1 };
            foreach (var item in RemoveDuplicateElements(array))
            {
                Console.Write(item + " ");
            }
        }

         int[] RemoveDuplicateElements(int[] array)
        {
            Dictionary<int, int> lastIndexMap = new Dictionary<int, int>();
            List<int> result = new List<int>();
            for (int i = array.Length-1; i>=1; i--)
            {
                if (lastIndexMap.ContainsKey(array[i]))
                {
                }
                else
                {
                    result.Add(array[i]);
                    lastIndexMap.Add(array[i], 123);
                }
            }

            result.Reverse();
            return result.ToArray();
        }
    }

    
    
    /*
     *Array117. Дан целочисленный массив размера N. Вставить перед каждой его
        серией элемент с нулевым значением (определение серии дано в задании
        Array116).

     * Array116
     * Дан целочисленный массив A размера N. Назовем серией группу
     * подряд идущих одинаковых элементов, а длиной серии — количество этих
     * элементов (длина серии может быть равна 1). Сформировать два новых
     * целочисленных массива B и C одинакового размера, записав в массив B
     * длины всех серий исходного массива, а в массив C — значения элементов,
     * образующих эти серии.
     */
    
    public class lab117
    {
       public lab117()
            {
                int[] array = { 1, 2, 2, 3, 4, 4, 4, 5, 6, 6, 7 };
        
                int[] result = InsertZeroes(array);
        
                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }
            }
        
       static int[] InsertZeroes(int[] array)
       {
           List<int> result = new List<int>();
            result.Add(0);
           for (int i = 0; i < array.Length-1; i++)
           {
               if (array[i] == array[i + 1])
               {
                   result.Add(array[i]);
               }
               else
               {
                   result.Add(array[i]);
                   result.Add(0);
               }
           }

           return result.ToArray();
       }
    }
}