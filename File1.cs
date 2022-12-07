using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CryptoSoft_ConsoleV
{
    class File1
    {
        public String FilePath_Source;
        public String File_Name { get; set; }
        public String File_Name1 { get; set; }

        public String Text;
        public int Length;

        public void GetFileProcess()
        {
            Console.WriteLine("Welcome to CryptoSoft");
            Thread.Sleep(1000);
            Console.WriteLine("Enter the file path you want to encrypt");

            FilePath_Source = Console.ReadLine();
            FilePath_Source += '/';
            Thread.Sleep(1000);
            Console.WriteLine("Enter the Name of the file you want to encrypt");
            File_Name = Console.ReadLine();
            
                

            Text = File.ReadAllText(FilePath_Source  + File_Name);
            Length = Text.Length;
            /*Console.WriteLine(File_Name);*/
            /*Thread.Sleep(2500);*/
            
        }

        

    }
}
