/*
Задача 3.Необязательная, дополнительная задача 
Задайте двумерный массив из трехзначных целых чисел 
(не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов,
которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0). 
Полученные средние арифметические занести в одномерный массив.

Например, задан массив:
100 404 504 225
550 478 800 363
505 101 410 479

=> [505, 252.5, 0, 363 ]
*/

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        int line = Enter("Задайте количество строк массива");
        int column = Enter("Задайте количество столбцов массива");

        int min = Enter("Задайте минимальный диапазон значений");
        int max = Enter("Задайте максимальный диапазон значений");

        double summ = 0;
        int number = 0;
        double result = 0;
        double Count = 0;

        int[,] arr = new int[line, column];   //Массив
        int [] arrPol = new int[line * column];     // Одномерный массив с максимальным возможным колличеством эелементов

        Console.WriteLine();
        GetFillArrayRandom(line, column, min, max);
        Console.WriteLine();

        Console.Write($"=> [");
        for (int i = 0; i < column;i++)
        {
            for (int j = 0; j < line; j++)
            {
                number = arr[j,i];
                if (number == revers(number))
                {
                    arrPol[j] = number;
                    summ +=(double) arrPol[j];
                    Count++;
                }
            }

            if (summ == 0)
            {
                Console.Write($" 0, ");
            }
            else
            {
                result = Math.Round(summ / Count, 1);
                Console.Write($" {result}, ");
                Count = 0;
                summ = 0;
            }
        }
        Console.Write("]");
        /////////////////////////////

        int revers(int x) // метод
        {
            int result = 0;
            int number = x;
            while (number > 0)
            {
                result = result * 10;
                result = result + number % 10;
                number = number / 10;
            }
            return result;
        }// математический метод на разворот числа

        int random (int x, int y)
        {
            Random rnd = new Random();
            return rnd.Next(x, y);
        }// Создание рандомного числа

        void GetFillArrayRandom(int line, int column, int min, int max)
        {
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = random(min, max); ;
                    Console.Write($"{arr[i, j]} ");
                    if (j == column - 1) Console.WriteLine();
                }
            }

        }//Создание и заполнение массива рандомными значениями

        int Enter(string msg)
        {
            Console.WriteLine(msg);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }   // ввод чисел
    }
}