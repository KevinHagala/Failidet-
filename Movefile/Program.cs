using System;
using System.IO;

namespace Movefile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Movefile()
        {
            string sourceDirectory = @"C:\Users\opilane\samples\playerOne";
            string destinationPath = @"C:\Users\opilane\samples\playerTwo";
            string fileName = "ball.txt";

            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }
    }
}
