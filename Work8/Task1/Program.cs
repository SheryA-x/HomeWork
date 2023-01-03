/*
Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int line = 5;// Enter("Задайте количество строк массива");
        int column = 5;// Enter("Задайте количество столбцов массива");

        int minRange = 1;// Enter("Задайте минимальный диапазон значений");
        int maxRange = 10;// Enter("Задайте максимальный диапазон значений");

        int[,] arr = new int[line, column];
        GetFillArrayRandom(arr, minRange, maxRange);

        bubbleMethod(arr);

        Console.WriteLine();
        for (int i = 0; i < arr.GetLength(0);i++)
        {
            Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            
        }   // вывод на экран

        //////////////////////////

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

        void bubbleMethod(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(1) - 1; k++)
                    {
                        if (arr[i, k] < arr[i, k + 1])
                        {
                            int temp = arr[i, k + 1];
                            arr[i, k + 1] = arr[i, k];
                            arr[i, k] = temp;
                        }
                    }
                }
            }
        }   // Пузырьковый метод

    }
}