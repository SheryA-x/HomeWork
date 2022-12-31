/*
Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

using System;
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        int line = 5;// Enter("Задайте количество строк массива");
        int column = 8;// Enter("Задайте количество столбцов массива");

        int minRange = 1;// Enter("Задайте минимальный диапазон значений");
        int maxRange = 16;// Enter("Задайте максимальный диапазон значений");

        int minimum = column * maxRange; // что бы не ставить конкретное(волшебное) число в строке, мы поставим максимальное какое может быть

        int[] summArr = new int[line];
        
        
        int[,] arr = new int[line, column];
        GetFillArrayRandom(arr, minRange, maxRange);

        Console.WriteLine();

        summLine(arr, summArr);

        Console.WriteLine();

        minSumm(summArr);

        Console.WriteLine();
        
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSummLineArr(summArr)}");

        ///////////////////////////

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
                    arr[i, j] = random(min, max);

                    Console.Write($"{arr[i, j]} ");

                    if (j == arr.GetLength(1) - 1) Console.WriteLine();
                }
            }

        }// Заполнение массива рандомными значениями

        void summLine(int[,] arr, int[] arr2)
        {
            int summ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summ += arr[i, j];
                }
                //Console.WriteLine(summ);
                summArr[i] = summ;
                summ = 0;
                Console.WriteLine(summArr[i]);
            }
        }//  подсчет строк двумерного массива и запись в одномерный

        void minSumm(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
                
            }   // Поиск наименьшего числа

            Console.WriteLine($"{minimum}");
        }   //  Поиск наименьшего числа в одномерном массиве

        int minSummLineArr(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
                if (arr[i] == minimum)
                {
                    break;
                }
            }
            return count;
        }   // поиск строки
    }
}