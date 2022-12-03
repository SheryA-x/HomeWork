/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа. 

456 -> 5
782 -> 8
918 -> 1 
*/

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Введите число ");
        //int number = Convert.ToInt32(Console.ReadLine());

        int number = new Random().Next(1, 1200);
        int x = 0;
       
        if (number >= 1000)
        {
            Console.WriteLine(number + " -> число четырехзначное или выше");
        }
        else if (number / 100 != 0)
        {
            x = number /10 % 10;
            Console.WriteLine((number + " -> " + x));
        }
        else if (number < 100)
        {
            Console.WriteLine(number + " -> число двузначное ");
        }  
    }
}