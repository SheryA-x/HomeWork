/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Int32.Parse(Console.ReadLine());
        int revers_res = revers(number);

        if (number == revers_res)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("не Палиндром");
        }

        //////////////////////////
            int revers(int x) // метод
        {
            int result = 0;
            int number = x;
            while (number > 0)
            {
                result = result * 10;
                result = result + number % 10;
                number = number / 10;
            }
            return result;
        }// математический метод на разворот числа
    }
}