﻿/*Задача 3: **(Дополнительное, не обязательно)
Назовём число «интересным» если его произведение цифр делится на их сумму. 
Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000.

(каждый эл-т массива – сгенерирован случайно)

[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
*/

// 591 = 5*9*1 = 45
// 591 = 5+9+1 = 15
// 45 / 15 = 3

// рандомное число - разложить число на цифры - сложение - деление по модулю с "x % y == 0" - если да то arr [i]
// брать рандомное число от 10 - 1000
// прогонять через ProductNum SumNum, затем делить и если при делени число осталось без остатка то записываем в массив

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] arr = {};
        //int num = 591;
        int[] arr = new int[10];
     
        for (int i = 0; i < 10; i++)
        {
            int random = new Random().Next(10,1000);

            if ( ProductNum(random) % SumNum(random) != 0)
            {
                i--;
            }
            else if (ProductNum(random) % SumNum(random) == 0)
            {   
                arr[i] = random;
                Console.Write(arr[i] + ", ");  
            }
        }

        int SumNum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            return sum;
        }

        int ProductNum(int num)
        {
            int sum = 1;
            while (num > 0)
            {
                if (num % 10 == 0)      // проверка на ноль
                { 
                    num = num / 10;     // изъятие нуля
                }
                sum = sum * (num % 10);
                num = num / 10;
            }
            return sum;
        }
    }   
}
