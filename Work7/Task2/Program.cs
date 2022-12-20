/*
Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1, 7]->такого числа в массиве нет
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int m = Enter("Задайте количество строк массива");
        int n = Enter("Задайте количество столбцов массива");
        int ind1 = Enter("Задайте индекс строки");
        int ind2 = Enter("Задайте индекс стольбца");
        Console.WriteLine();

        int[,] arr = new int[m, n];
        Random rnd = new Random();

        Getarray(n, m);
        Console.WriteLine();

        if (n <= ind1 & m <= ind2)
        {
            Console.WriteLine($"[{ind1},{ind2}] -> такого числа в массиве нет");
        }
        else
        {
            Console.WriteLine($"число в массиве под индексами [{ind1},{ind2}] -> {arr[ind1, ind2]}");
        }

        void Getarray(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = rnd.Next(10);
                    Console.Write($"{arr[i, j]} ");

                    if (j == y - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        } // вывод аккуратного массива от 1-9
        int Enter (string msg)
        {
            Console.WriteLine(msg);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }   // ввод чисел
    }
}