using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoSoft_ConsoleV
{
    class File1
    {
        public String FilePath_Source;
        public String File_Name { get; set; }

        public String Text;
        public int Length;

        public void GetFile()
        {
            Console.WriteLine("Welcome to CryptoSoft");
            Console.WriteLine("Enter the file path you want to encrypt");

            FilePath_Source = Console.ReadLine();
            this.File_Name = Path.GetFileName(FilePath_Source);
            /*Console.WriteLine(File_Name);*/
            Thread.Sleep(2500);

        }

        public void ReadFileText()
        {
            Text = File.ReadAllText(FilePath_Source);
            Length = Text.Length;

        }

    }
}
