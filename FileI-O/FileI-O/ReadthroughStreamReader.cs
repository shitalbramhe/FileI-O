using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileI_O
{
    public class ReadthroughStreamReader
    {
        public void WriteUsingStreamWriter()
        {
            String path = @"E:\RFP\FileI-O\FileI-O\FileI-O\Example.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello world - .Net is awesome");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        public void ReadFromStreamReader()
        {
            String path = @"E:\RFP\FileI-O\FileI-O\FileI-O\Example.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                
                String s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
