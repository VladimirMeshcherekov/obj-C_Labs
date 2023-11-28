using System;

namespace lab4
{
    internal class Program
    {
        // 56 / 76 / 96
        public static void Main(string[] args)
        {
            //lab56 lab = new lab56();
            //lab76 lab = new lab76();
            //lab96 lab = new lab96();
        }
    }


/*
 *  Дана матрица размера M × N (N — четное число). Поменять местами
 *  левую и правую половины матрицы
 */
    public class lab56
    {
        public lab56()
        {
            int M = 4; // количество строк
            int N = 4; // количество столбцов (четное число)

            int[,] matrix =
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            SwapHalves(matrix, M, N);

            // Выводим измененную матрицу
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void SwapHalves(int[,] matrix, int rows, int columns)
        {
            int half = columns / 2;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < half; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + half];
                    matrix[i, j + half] = temp;
                }
            }
        }
    }


    /*
     * Дана матрица размера M × N. Упорядочить ее строки так, чтобы их
первые элементы образовывали возрастающую последовательность.
     */
    public class lab76
    {
        public lab76()
        {
            int M = 3; // количество строк
            int N = 3; // количество столбцов

            int[,] matrix =
            {
                { 3, 2, 1 },
                { 2, 5, 4 },
                { 9, 8, 7 },
            };

            SortRows(matrix, M, N);

            // Выводим измененную матрицу
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void SortRows(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (matrix[i, 0] > matrix[j, 0])
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[j, k];
                            matrix[j, k] = temp;
                        }
                    }
                }
            }
        }
    }


    
    /*
     * Дана квадратная матрица A порядка M. Зеркально отразить ее элементы относительно главной диагонали
     * (при этом элементы главной диагонали останутся на прежнем месте, элемент A(1,2) поменяется местами
с A(2,1), элемент A(1,3) — с A(3,1) и т. д.). Вспомогательную матрицу не использовать
     */
    public class lab96
    {
        public lab96()
        {
            int M = 3; // порядок квадратной матрицы
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            MirrorReflect(matrix, M);

            // Выводим измененную матрицу
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void MirrorReflect(int[,] matrix, int M)
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = i + 1; j < M; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }
    }
}