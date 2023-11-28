using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab5
{
    internal class Program
    {
        // 13 / 33 / 53
        public static void Main(string[] args)
        {
            //lab13 lab = new lab13(); // путь к файлам - bin/Debug
            //lab33 lab = new lab33(); 
        }
    }

    /*
     * Дан файл целых чисел. Создать два новых файла, первый из которых
        содержит положительные числа из исходного файла (в обратном порядке), а второй — отрицательные (также в обратном порядке). Если положительные или отрицательные числа в исходном файле отсутствуют, то
        соответствующий результирующий файл оставить пустым.
     * 
     */
    public class lab13
    {
        public lab13()
        {
            string sourceFilePath = "input13.txt";
            string positiveFilePath = "positive.txt";
            string negativeFilePath = "negative.txt";

            
            // Создаем списки для хранения положительных и отрицательных чисел
            List<int> positiveNumbers = new List<int>();
            List<int> negativeNumbers = new List<int>();

            // Читаем исходный файл
            string[] lines = File.ReadAllLines(sourceFilePath);
            foreach (string line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    if (number > 0)
                    {
                        positiveNumbers.Add(number);
                    }
                    else if (number < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                }
            }

            // Пишем положительные числа в обратном порядке
            if (positiveNumbers.Any())
            {
                positiveNumbers.Reverse();
                List<string> positiveText = new List<string>();

                foreach (var VARIABLE in positiveNumbers)
                {
                    positiveText.Add(VARIABLE.ToString());
                }

                File.WriteAllLines(positiveFilePath, positiveText.ToArray());
            }

            // Пишем отрицательные числа в обратном порядке
            if (negativeNumbers.Any())
            {
                List<string> negativeText = new List<string>();
                foreach (var VARIABLE in positiveNumbers)
                {
                    negativeText.Add(VARIABLE.ToString());
                }

                negativeNumbers.Reverse();
                File.WriteAllLines(negativeFilePath, negativeText.ToArray());
            }
        }
    }
    
    
    /*
     * Дан файл целых чисел, содержащий четное количество элементов.
        Удалить из данного файла первую половину элементов.
     */
    
    public class lab33
    {
        
        public lab33()
        {
            string filePath = "input33.txt";

            // Читаем все числа из файла в список
            List<int> numbers = new List<int>(Array.ConvertAll(File.ReadAllLines(filePath), int.Parse));

            // Проверяем, что количество элементов четное
            if (numbers.Count % 2 == 0)
            {
                // Удаляем первую половину элементов
                numbers.RemoveRange(0, numbers.Count / 2);

                // Перезаписываем файл с оставшимися числами
                File.WriteAllLines(filePath, Array.ConvertAll(numbers.ToArray(), x => x.ToString()));
            }
            else
            {
                Console.WriteLine("Количество чисел в файле нечетное");
            }
        }
    }
    
}