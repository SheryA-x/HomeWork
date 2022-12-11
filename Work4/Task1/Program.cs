/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. 
Не использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int num = Enter("Введите число");
        int pow = Enter("Введите степень числа");
        
        int result = MathPow(num, pow);

        Console.WriteLine(result);
        

        int MathPow (int x, int y)
        {
            int sum = 1;
            for (int i = 1; i <= y; i++)
            {
                sum = sum * x;  
            }
            return sum;
        }   // Цикл для степени

        int Enter(string msg)
        {
            Console.WriteLine(msg);
            int x = Convert.ToInt32(Console.ReadLine());

            return x;
        }        
    }
}