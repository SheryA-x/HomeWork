/*
Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18

 * 2 4 | 3 4
 * 3 2 | 3 3

 * 2*3 + 4*3 = 18   2*4 + 4*3 = 20
 * 3*3 + 2*3 = 15   3*4 + 2*3 = 18
 
 * 18 20
 * 15 18
*/

internal class Program
{
    private static void Main(string[] args)
    {

        int line = 3;// Enter("Задайте количество строк массива");
        int column = 3;// Enter("Задайте количество столбцов массива");

        int minRange = 1;// Enter("Задайте минимальный диапазон значений");
        int maxRange = 6;// Enter("Задайте максимальный диапазон значений");

        int[,] arr = new int[line, column];
        int[,] arr2 = new int[line, column];
        int[,] result = new int[line, column];

        GetFillArrayRandom(arr, minRange, maxRange);
        Console.WriteLine();
        GetFillArrayRandom(arr2, minRange, maxRange);

        matrixMultiplication(arr, arr2);
        Console.WriteLine();

        outputArray2D(result);
        
        




        int Enter(string msg)
        {
            Console.WriteLine(msg);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }   // ввод чисел

        int random(int x, int y)
        {
            Random rnd = new Random();
            return rnd.Next(x, y);
        }// Создание рандомного числа

        void GetFillArrayRandom(int[,] arr, int min, int max)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random(min, max); ;
                    Console.Write($"{arr[i, j]} ");

                    if (j == arr.GetLength(1) - 1) Console.WriteLine();
                }
            }

        }// Заполнение массива рандомными значениями

        void outputArray2D(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                    if (j == arr.GetLength(1) - 1) Console.WriteLine();
                }
            }
        }   // Вывод на экран двумерного массива

        void matrixMultiplication(int[,] arr1, int[,] arr2)
        {
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        result[i, j] += arr[i, k] * arr2[k, j];
                    }
                }
            }
        }   // Перемножение матриц

    }
}