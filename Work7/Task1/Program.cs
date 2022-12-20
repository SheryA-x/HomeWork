/*
Задача 1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.

m = 3, n = 4.
0.5 7.96 -2.78 -0.2
1.7 -3.3 8.574 -9.9
8.5 7.87 -7.1 9.15
*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задайте количество строк массива");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Задайте количество столбцов массива");
        int n = Convert.ToInt32(Console.ReadLine());

        Random rnd = new Random();

        Console.WriteLine($"m = {m}, n = {n}.");
        double[,] arr = new double[m,n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i,j] = Math.Round( (rnd.NextDouble()*100/10), 3);

                Console.Write($"{arr[i, j]} ");

                if (j == n -1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}