using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoSoft_ConsoleV
{
    class Encrypt
    {
        public void ToEncrypt()
        {
            File1 FileToEncrypt;
            FileToEncrypt = new File1();

            FileToEncrypt.GetFile();
            Console.WriteLine("le nom du fichier est " + FileToEncrypt.File_Name);

            FileToEncrypt.ReadFileText();
            Console.WriteLine("le contenu du fichier est " + FileToEncrypt.Length);

        }

    }
}
