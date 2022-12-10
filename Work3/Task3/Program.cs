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
//2) i ^ 3 = i * i * i;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = Enter_Number();

        int[] cub = new int[N + 1];

        for (int i = 1; i <= N; i++)
        {
            cub[i] = Convert.ToInt32(Math.Pow(i, 3));   //cub[i] = i * i * i;   //конвертация Math.Pow в целое число    
        }
        Print_cub(N, cub);  //Вывод на экран


////////////////////////////////
        int Enter_Number()
        {
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }// Метод вывод на экран сообщения о вводе числа, ввод с клавиатуры и конвертация из string в int

        void Print_cub(int num,int[] pow)       // num - число с клавиатуры, pow - массив
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