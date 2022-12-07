using System;
using System.Threading;

namespace CryptoSoft_ConsoleV
{
    class Program
    {
        static void Main(string[] args)
        {
            Encrypt Encryption;
            Encryption = new Encrypt();

            Encryption.ToEncrypt();
            Thread.Sleep(4000);
        }
    }
}
