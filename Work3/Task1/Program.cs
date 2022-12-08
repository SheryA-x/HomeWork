internal class Program
{
    private static void Main(string[] args)
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