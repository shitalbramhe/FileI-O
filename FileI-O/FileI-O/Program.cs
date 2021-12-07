using FileI_O;
using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)

        {
            //Program.FileExists();
            //Program.ReadAllLines();
            //Program.ReadAllText();

            ReadthroughStreamReader readthroughStreamReader = new ReadthroughStreamReader();
            readthroughStreamReader.WriteUsingStreamWriter();
            //readthroughStreamReader.ReadFromStreamReader();
        }
        public static void FileExists()
        {
            String path = @"E:\RFP\FileI-O\FileI-O\FileI-O\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadAllLines()
        {
            String path = @"E:\RFP\FileI-O\FileI-O\FileI-O\Example.txt";
            String[] Lines;
            Lines = File.ReadAllLines(path);

            Console.WriteLine("lines[0]");
            Console.WriteLine("lines[1]");

            Console.ReadKey();
        }
        public static void ReadAllText()
        {
            String path = @"E:\RFP\FileI-O\FileI-O\FileI-O\Example.txt";
            String lines;
            lines = File.ReadAllText(path);

            Console.WriteLine("lines");
           
            Console.ReadKey();
        }
    }
}




