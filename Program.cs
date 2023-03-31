using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace TextFile
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the file path: ");
            FormatValidation();
            FileExists();
            
        }

        static void FormatValidation()
        {
            FilePath i = new FilePath(); 
            do
            {
                try
                {
                    i.FPath = @"" + Console.ReadLine();

                    StreamReader sr = new StreamReader(i.FPath);
                    
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Encountered a problem! " + e.Message);
                }
            } while(i.FPath != null);
        }

        static void FileExists()
        {
            FilePath i = new FilePath();
            i.FPath = @"" + Console.ReadLine();
            Console.WriteLine(File.Exists(i.FPath) ? "File exists." : "File does not exists.");
        }
    }

    public class FilePath
    {
        private string fPath;

        public string FPath
        {
            get => fPath;
            set => fPath = value;
        }
    }

}