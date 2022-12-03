internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число 2");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int max, min, x;

        if (number1 > number2)
        {
            max = number1;
            min = number2;
        }
        else
        {
            max = number2;
            min = number1;
        }
        //max / min
        if (max % min == 0)
        {
            Console.WriteLine("кратно");
        }
        else
        {
            x = max % min;
            Console.WriteLine("Не кратно, остаток " + x);
        }
    }
}