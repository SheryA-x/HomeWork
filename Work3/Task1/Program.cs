/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

using System;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Введите число");
        string N = Console.ReadLine();
        int lenght = N.Length;

        int first = 0;
        int last = lenght - 1;

        if (N[first] == N[last])
        {
            first++;
            last--;
            Console.WriteLine(N + " -> Полиндром");
        }
        else 
        {
            Console.WriteLine(N + " -> не Полиндром");
        }


    }

}