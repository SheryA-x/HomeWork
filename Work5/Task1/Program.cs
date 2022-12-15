/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write($"[");
        int[] arr = new int[10];
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int num = new Random().Next(99, 1000);
            arr[i] = num;

            if (arr[i] % 2 == 0)
            {
                count++;
            }

            Console.Write($"{num}, ");
        }
        Console.Write($"]");
        Console.Write($" -> {count}");
    }
}