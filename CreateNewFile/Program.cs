using System;
using System.IO;

namespace CreateNewFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the file name (include extensions):");
            string userInput = Console.ReadLine();
            //CreateUserFile(userInput);
            CreateFileWithExtension(userInput);
        }

        public static void CreateNewFile()
        {
            string rootPath = @"C:\Users\opilane\samples\playerOne";
            string fileName = "ball.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }

        public static void CreateFileWithExtension(string fileName)
        {
            string rootPath = @"C:\Users\opilane\samples\playerTwo";
            string fullfileName = $"{fileName}.txt";
            File.Create(Path.Combine(rootPath, fullfileName));
        }


    }
}
