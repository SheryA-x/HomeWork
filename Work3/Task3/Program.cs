/*
Задача 3
Напишите программу, которая принимает на вход число (N) 
и помещает в массив таблицу кубов чисел от 1 до N. 
Полученный массив вывести на экран.
3 -> [1, 8, 27].
5-> [1, 8, 27, 64, 125]
Указание: Вывод массива вынести в отдельную функцию.
*/

//1) 1 ^ 3 = 1 * 1 * 1;
//2) n ^ 3 = n * n * n;

using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] cub = new int[N + 1];

        for (int i = 1; i <= N; i++)
        {
            cub[i] =i * i * i;
        }
        Print_cub(N, cub);
        

        void Print_cub(int num,int[] pow)
        {
            for (int i = 1; i < pow.Length; i++)
            {
                Console.Write(num + " -> " + "[");
                for ( i = 1; i < pow.Length-1; i++)         //  pow.Length-1 для того что бы вывелось на экран все кроме последней
                {
                    Console.Write(pow[i] + "," + " ");      //счетчик i в двух for, для того что бы счетчик который закончил во 2м for, продолжил в 1м
                }
                Console.Write(pow[i] + "]");                //  вывод последнего значения без запятой и пробела
            }
        }// Метод вывода массива (Советую посмотреть =) )
    }
}