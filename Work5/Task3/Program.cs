/*
Задача 38:
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3  22 2 78] -> 76
*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        

        
        int summ = 0;
        int min = 100;
        int max = 0;
 
        Console.Write($"[");



         int[] arr = new int[5];
         for (int i = 0; i < arr.Length; i++)
         {
             int num = new Random().Next(0, 100);
             arr[i] = num;
             Console.Write($"{num}, ");
         }


        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            else if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.Write($"]");
        Console.WriteLine($" -> {min} {max}");

       
    }
}