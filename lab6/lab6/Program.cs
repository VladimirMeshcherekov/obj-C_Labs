using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab6
{
    internal class Program
    {
        //61 / 81 / 31
        public static void Main(string[] args)
        {
            
            // путь к файлам bin/Debug
            
            //lab61 lab = new lab61();
            // lab81 lab = new lab81();
            //lab31 lab = new lab31();
           // lab31_text lab = new lab31_text();
        }
    }


    /*
     * Дан символьный файл, содержащий по крайней мере один символ
пробела. Удалить все его элементы, расположенные перед последним символом пробела, включая и этот пробел.
     */
    public class lab61
    {
        public lab61()
        {
            string filePath = "input.txt";
            string content = File.ReadAllText(filePath);

            // Находим индекс последнего пробела
            int lastSpaceIndex = content.LastIndexOf(' ');

            // Удаляем все элементы перед последним пробелом, включая пробел
            if (lastSpaceIndex >= 0)
            {
                content = content.Substring(lastSpaceIndex + 1);
                File.WriteAllText(filePath, content);
            }
            else
            {
                // Если нет пробела, оставляем содержимое файла без изменений
                Console.WriteLine("В файле отсутствует символ пробела");
            }
        }
    }


    /*
     * Дан файл вещественных чисел, содержащий элементы нижнетреугольной матрицы (по строкам).
     * Создать новый файл, содержащий элементы ненулевой части данной матрицы (по строкам).
     */

    public class lab81
    {
        public lab81()
        {
            string inputFilePath = "input81.txt";
            string outputFilePath = "output81.txt";

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(inputFilePath);

            // Создаем новый файл и записываем в него ненулевые элементы нижнетреугольной матрицы
            using (StreamWriter outputFile = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] elements = lines[i].Split(' ');
                    for (int j = i; j < elements.Length; j++)
                    {
                        double number = double.Parse(elements[j]);
                        if (number != 0)
                        {
                            outputFile.Write(number + " ");
                        }
                    }

                    outputFile.WriteLine(); // Переходим на новую строку после каждой строки матрицы
                }
            }
        }
    }

    /*
    * Дан файл целых чисел, содержащий более 50 элементов. Уменьшить
    его размер до 50 элементов, удалив из файла необходимое количество
    начальных элементов.
    */
    
    public class lab31
    {
        public lab31()
        {
            string filePath = "input31.txt";

            // Читаем все числа из файла в виде строки
            string content = File.ReadAllText(filePath);

            // Разбиваем строку на массив чисел
            string[] numbersStr = content.Split(' ');
        
            // Если количество элементов больше 50, удаляем лишние
            if (numbersStr.Length > 50)
            {
                Array.Resize(ref numbersStr, 50); // Уменьшаем размер массива, оставляя только первые 50 элементов
            }

            // Записываем оставшиеся элементы обратно в файл
            File.WriteAllText(filePath, string.Join(" ", numbersStr));
        }

    }

    
    
  // Дано целое число K и текстовый файл. Создать строковый файл и записать в него все слова длины K из исходного файла. Словом считать набор
  //     символов, не содержащий пробелов, знаков препинания и ограниченный
  //     пробелами, знаками препинания или началом/концом строки. Если исходный файл не содержит слов длины K, то оставить результирующий файл
  // пустым.
    public class lab31_text
    {
        string filePath = "input31_text.txt";
        string outputPath = "output31_text.txt";
        private int K = 4;
        public lab31_text()
        {
            // Читаем все числа из файла в виде строки
              string content = File.ReadAllText(filePath);
              string[] separators = { " ", ",", ".", ";", ":", "-", "!", "?" }; // Define word separators
            
              string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);
              List<string> result = words.Where(word => word.Length == 4).ToList();
                File.WriteAllLines(outputPath,result.ToArray() );
            
        }
      
    }
    
}