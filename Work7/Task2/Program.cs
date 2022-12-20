/*
Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1, 7]->такого числа в массиве нет
*/
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задайте количество строк массива");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Задайте количество столбцов массива");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Укажите два индекса массива");
        int ind1 = Convert.ToInt32(Console.ReadLine());
        int ind2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int[,] arr = new int[m, n];
        Random rnd = new Random();

        int numberRequested = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rnd.Next(1, 10);
                Console.Write($"{arr[i, j]} ");

                if (j == n - 1)
                {
                    Console.WriteLine();
                }
            }
        }

        if (n <= ind1 & m <= ind2)
        {
            Console.WriteLine($"[{ind1},{ind2}] -> такого числа в массиве нет");
        }
        else
        {
            numberRequested = arr[ind1, ind2];
            Console.WriteLine($"число в массиве [{ind1},{ind2}] -> {numberRequested}");
        }
    }
}