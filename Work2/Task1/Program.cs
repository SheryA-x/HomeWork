/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа. 

456 -> 5
782 -> 8
918 -> 1 */


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());
        int x = 0;

        if (number > 99)
        {
            if (number < 999)
            {
                x = number % 100 / 10;
                Console.WriteLine(number + " ->" + x);
            }
        }
        else
            Console.WriteLine("число не подходит ");
    }
}