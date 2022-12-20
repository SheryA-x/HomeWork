/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.

M=5 ; 0, 7, 8, -2, -2-> 2
M = 5; -1, -7, 567, 89, 223-> 3
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество цифр");
        int num = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        Console.WriteLine("Вводите числа ");
        int y = 0;
        for (int i = 0; i < num; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                count++;
            }
        }
        
        Console.Write($" -> {count}");

    }
}