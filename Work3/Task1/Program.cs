internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Int32.Parse(Console.ReadLine());

        int revers_res = revers(number);

        if (number == revers_res)
        {
            Console.WriteLine("Полиндром");
        }
        else
        {
            Console.WriteLine("не Полиндром");
        }
            static int revers(int x)
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