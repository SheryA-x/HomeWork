/*
Задача 38:
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3  22 2 78] -> 76
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[5];
        int min = 100;
        int max = 0;
 
        Console.Write($"[");

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
        Console.WriteLine($" -> {max - min}");
    }
}