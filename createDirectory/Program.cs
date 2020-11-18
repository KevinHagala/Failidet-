using System;
using System.IO;

namespace createDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void CreateFolderOne()
        {
            string rootPath = @"C:\Users\opilane\sample";
            string folderName = "playerOne;";
            string fullFolderPath = Path.Combine(rootPath, folderName);
            Console.WriteLine(fullFolderPath);
            if (Directory.Exists(fullFolderPath)) // check if folder exists
            {
                Console.WriteLine("The folder already exists");
            }else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }
        public static void CreateFolderTwo()
        {

        }
    }
}
