using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafeUi.UI
{
    public class RegularConsole : ICafeConsole
    {
        public void Clear()
        {
            Console.Clear();
        }
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public void Write(string M)
        {
            Console.Write(M);
        }

        public void WriteLine(string M)
        {
            Console.WriteLine(M);
        }
    }
}
