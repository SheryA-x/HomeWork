/*
Задача 4*. 
Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
Напишите программу, которая будет построчно выводить массив. 
Обратите внимание, что максимальный размер такого массива ограничен. 
Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

Например,
11 22 78
12 47 96
25 87 88
*/

using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        int line = 5;// Enter("Задайте количество строк массива");
        int column = 5;// Enter("Задайте количество столбцов массива");

        int minRange = 1;// Enter("Задайте минимальный диапазон значений");
        int maxRange = 25;// Enter("Задайте максимальный диапазон значений");

        int[,] arr = new int[line, column];
        int[] tmp = new int[line * column];

        GetFillArrayRandom(arr, minRange, maxRange, tmp);
        moveToTheNextLine();

        for (int i = 1; i < tmp.Length; i++)
        {
            for (int j = i + 1; j < tmp.Length; j++)
            {
                if (tmp[i] == tmp[j])
                {
                    tmp[j] = random(minRange, maxRange);

                    i = 0;
                    break;
                }

            }
        } // почему то не работает в методе(


        moveToTheNextLine();

        fill2DArray(arr, tmp);
 
        outputArray2D(arr);

/////////////////////////////////

        void moveToTheNextLine()
        {
            Console.WriteLine();
        }

        int random(int x, int y)
        {
            Random rnd = new Random();
            return rnd.Next(x, y);
        }// Создание рандомного числа

        void GetFillArrayRandom(int[,] arr, int min, int max, int[] arr2)
        {
            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++, k++)
                {
                    arr2[k] = random(min, max);
                    arr[i, j] = tmp[k];

                    Console.Write($"{arr[i, j]} ");
                    if (j == arr.GetLength(1) - 1) Console.WriteLine();
                }
            }

        }// Заполнение массива рандомными значениями и запись чисел в одномерный массив

        void matchCheckAndFillRandom(int[] x)
        {
            
            for (int i = 0; i < x.Length; i++)
            {
                
                for (int j = i; j < x.Length; j++)
                {
                    if (x[i] == x[j])
                    {
                        x[j] = random(minRange, maxRange);

                        i = 0;
                        break;
                    }
                    
                }
            }
        } // не работает
        

        void fill2DArray(int[,] x, int[] y)
        {
            int k = 0;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++, k++)
                {
                    x[i, j] = y[k];
                }
            }
        }

        void outputArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]} ");
            }
        }
        void outputArray2D(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write($"{x[i, j]} ");
                    if (j == x.GetLength(1) - 1) Console.WriteLine();
                }
            }
        }
    }
}