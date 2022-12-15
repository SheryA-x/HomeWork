/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write($"[");
        int[] arr = new int[10];
        int summ = 0;

        for (int i = 0; i < arr.Length; i ++)
        {
            int num = new Random().Next(-100,100);
            arr[i] = num;
            
            Console.Write($"{num}, ");
        }

        Console.Write($"]");

        for (int i = 1; i < arr.Length; i += 2)
        {
            summ+= arr[i];
        }
        
        Console.Write($" -> {summ}");

    }
}