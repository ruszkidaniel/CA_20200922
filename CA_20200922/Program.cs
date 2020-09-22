using System;

namespace CA_20200922
{
    class Program
    {
        static Random RND = new Random();
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ruszki Dániel");
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = (ConsoleColor)RND.Next(1, 16);
                Console.SetCursorPosition(
                    RND.Next(Console.WindowWidth),
                    RND.Next(Console.WindowHeight));
                Console.Write("Juhász Zoltán");
                //comment
            }
            Console.ReadKey();
        }
    }
}
