using System;
using System.IO;

namespace lab7
{
    internal class Program
    {
        // 7 / 35 / 53
        public static void Main(string[] args)
        {
           // lab7 lab = new lab7();
           // lab35 lab = new lab35();
           // lab53 lab = new lab53(); // путь к файлам bin/Debug
        }
    }


  //Описать процедуру Smooth3(A, N), выполняющую сглаживание вещественного массива A размера N следующим образом: каждый элемент
  //массива заменяется на его среднее арифметическое с соседними элементами (при вычислении среднего арифметического используются исходные
  //значения соседних элементов). Массив A является входным и выходным
  //параметром. С помощью этой процедуры выполнить пятикратное сглаживание д
    public class lab7
    {
        public lab7()
        {
            float[] array = { 1, 2, 5, 8, 16, 24, 39, 8, 9, 10 };
        
            for (int i = 0; i < 5; i++)
            {
                array = Smooth3(array);
                foreach (var VARIABLE in array)
                {
                       Console.Write(VARIABLE + " ");
                }
                Console.WriteLine();
            }
        }
        float[] Smooth3( float[] A)
        {
            float[] original = new float[A.Length];
            Array.Copy(A, original, A.Length);

            for (int i = 1; i < A.Length - 1; i++)
            {
                A[i] = (original[i - 1] + original[i] + original[i + 1]) / 3f;
            }

            return A;
        }
    }


    /* Описать процедуру TrimRightC(S, C), удаляющую в строке S конечные символы, совпадающие с символом C. Строка S является входным и
    выходным параметром. Дан символ C и пять строк. Используя процедуру
    TrimRightC, преобразовать данные строки.*/
    public class lab35
    {
        public lab35()
        {
            string str1 = "Hellooooo";
            string str2 = "ABCDEEE";
            string str3 = "Goodbye";
            string str4 = "Programmingggg";
            string str5 = "CSharp";

            TrimRightC(ref str1, 'o');
            TrimRightC(ref str2, 'E');
            TrimRightC(ref str3, 'e');
            TrimRightC(ref str4, 'g');
            TrimRightC(ref str5, 'p');
            
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            
        }
        void TrimRightC(ref string S, char C)
        {
            int i = S.Length - 1;
            while (i >= 0 && S[i] == C)
            {
                i--;
            }
            S = S.Substring(0, i + 1);
           
        }
        
    }


  //Описать процедуру SplitIntFile(S0, K, S1, S2), копирующую первые K (≥ 0) элементов существующего файла целых чисел с именем S0
  //в новый файл целых чисел с именем S1, a остальные элементы — в новый файл целых чисел с именем S2. Один из созданных файлов может
  //    остаться пустым. Применить эту процедуру к файлу с данным именем S0,
  //    используя указанные значения K, S1 и S2.
    public class lab53
    {
        public lab53()
        {
            string S0 = "input.txt";
            int K = 5;
            string S1 = "firstPart.txt";
            string S2 = "secondPart.txt";

            SplitIntFile(S0, K, S1, S2);
        }
        
        void SplitIntFile(string S0, int K, string S1, string S2)
        {
            string[] numbers = File.ReadAllLines(S0);

            if (K >= numbers.Length)
            {
                File.WriteAllLines(S1, numbers);
                File.WriteAllText(S2, string.Empty);
            }
            else
            {
                string[] firstK = new string[K];
                for (int i = 0; i < K; i++)
                {
                    firstK[i] = numbers[i];
                }

                string[] remaining = new string[numbers.Length - K];
                for (int i = K; i < numbers.Length; i++)
                {
                    remaining[i - K] = numbers[i];
                }

                File.WriteAllLines(S1, firstK);
                File.WriteAllLines(S2, remaining);
            }
        }

    }
    
    
}