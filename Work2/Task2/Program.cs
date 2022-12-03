/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


internal class Program
{
    private static void Main()
    {
        //Console.WriteLine("Введите число ");
        //int number = Convert.ToInt32(Console.ReadLine());

        int number = new Random().Next(1,9999);
        int x;

        if (number / 1000 != 0) 
        {
                x = number /10 % 10;
                Console.WriteLine(number + " -> " + x);
        }
        else if (number / 100 != 0)
        {
                x = number % 10;
                Console.WriteLine((number + " -> " + x));
        }
        else 
        {
            Console.WriteLine(number + " -> третьей цифры нет");
        }





    }
}