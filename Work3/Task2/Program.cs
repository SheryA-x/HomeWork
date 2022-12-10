/*
Задача 2
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//  AB = √(x - x1)2 + (y - y1)2 + (z - z1)2;

//  AB = Math.Sqrt(Math.Pow() + Math.Pow() + Math.Pow());

//  ( Math.Pow ( (x-x1), 2 );

internal class Program
{
    private static void Main(string[] args)
    {
        //SpaceCoordinates();       // Введите координаты вручную
        SpaceCoordinatesRandom(-10, 10);   // Автоматическое заполнение произвольными параметрами



        void SpaceCoordinatesRandom(int a, int b)
        {
            double result = 0;
            int x = new Random().Next(a, b);
            int y = new Random().Next(a, b);
            int z = new Random().Next(a, b);
            
            int x1 = new Random().Next(a, b);
            int y1 = new Random().Next(a, b);
            int z1 = new Random().Next(a, b)
                ;
            result = Math.Sqrt( (Math.Pow ((x - x1), 2))           //AB = √(x - x1)2 + (y - y1)2 + (z - z1)2;
                             +  (Math.Pow ((y - y1), 2))
                             +  (Math.Pow ((z - z1), 2)) );

            Console.WriteLine($"А({x},{y},{z}); B({x1},{y1},{z1}) -> " + Math.Round(result, 2));
        }// Автоматическое заполнение произвольными параметрами

        void SpaceCoordinates()
        {
            double result = 0;
            Console.WriteLine($"Введите точку A: ");
            Console.Write($"координаты x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            //int x = new Random().Next(-10, 10);

            Console.Write($"координаты y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            //int y = new Random().Next(-10, 10);

            Console.Write($"координаты z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            //int z = new Random().Next(-10, 10);

            Console.WriteLine($"Введите точку B: ");
            Console.Write($"координаты x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            //int x1 = new Random().Next(-10, 10);

            Console.Write($"координаты y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            //int y1 = new Random().Next(-10, 10);

            Console.Write($"координаты z1: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            //int z1 = new Random().Next(-10, 10);

            result = Math.Sqrt( (Math.Pow((x - x1), 2))           //AB = √(x - x1)2 + (y - y1)2 + (z - z1)2;
                              + (Math.Pow((y - y1), 2))
                              + (Math.Pow((z - z1), 2)) );

            Console.WriteLine($"А({x},{y},{z}); B({x1},{y1},{z1}) -> " + Math.Round (result,2));
        }// Введите координаты вручную
    }
}