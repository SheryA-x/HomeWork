/*
Задача 3 

 *.Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Если кол-во элементов нечетное, то элемент посередине не учитывать.

Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11 (1*2 = 2; 3*3 = 9) (2+9 = 11)
8, 3, 4, 2 -> 28
*/

using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длину массива");
        int length = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        int num = 0;

        int[] arr = new int[length];
       
        for (int i = 0; i < arr.Length; i++)
        {
            for (i = 0; i < arr.Length-1; i++)
            {
                num = new Random().Next(1, 10);
                arr[i] = num;
                Console.Write($"{num}, ");
            }

            num = new Random().Next(1, 10);
            arr[i] = num;
            Console.Write($"{num} -> ");
        }

        for(int i = 0, j = arr.Length-1; i < arr.Length/2; i++, j--)
        {
            result = result + (arr[i] * arr[j]);
        }
        Console.WriteLine(result);
    }
}