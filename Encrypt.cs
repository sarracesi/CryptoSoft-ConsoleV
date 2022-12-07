using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoSoft_ConsoleV
{
    class Encrypt
    {
        public string text;
        public string key;
        public string ResultF;
        public String FilePath_Source2;
        public void GetInfoToDecrypt()
        {
            File1 FileToEncrypt;
            FileToEncrypt = new File1();

            FileToEncrypt.GetFile();
            Console.WriteLine("le nom du fichier est " + FileToEncrypt.File_Name);

            FileToEncrypt.ReadFileText();
            text = FileToEncrypt.Text;
            /*Console.WriteLine("le contenu du fichier est " + text);*/

            key = "sarrakhechine";
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
            {
                // take next character from string
                char character = text[c];

                // cast to a uint
                uint charCode = (uint)character;

                // figure out which character to take from the key
                int keyPosition = c % key.Length; // use modulo to "wrap round"

                // take the key character
                char keyChar = key[keyPosition];

                // cast it to a uint also
                uint keyCode = (uint)keyChar;

                // perform XOR on the two character codes
                uint combinedCode = charCode ^ keyCode;

                // cast back to a char
                char combinedChar = (char)combinedCode;

                // add to the result
                result.Append(combinedChar);
            }
            ResultF = result.ToString();
            FilePath_Source2 = Console.ReadLine();
            /*File.CreateText(FilePath_Source2);
            *//*File.WriteAllText(FilePath_Source2, ResultF);*//*
            using (StreamWriter sw = File.CreateText(FilePath_Source2))
            {
                sw.WriteLine(ResultF);
            }*/

            Directory.CreateDirectory(FilePath_Source2);
            File.AppendAllText(FilePath_Source2 + FileToEncrypt.File_Name + "\\ENCRYPTED", ResultF);

            /*Console.WriteLine("le resultat est " + ResultF);*/
        }

  

    }
}
