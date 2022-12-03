/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Введите первое число");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("a = " + number1 + " "); // a = 5; b = 7

        Console.Write("b = " + number2 + " ");

        if (number1 > number2)
        {
            Console.WriteLine("max = " + number1);
        }

        else
        {
            Console.WriteLine("max = " + number2);
        }
    }
}