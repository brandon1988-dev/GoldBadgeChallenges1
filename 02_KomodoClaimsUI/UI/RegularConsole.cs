using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaimsUI.UI
{
    public class RegularConsole : IClaimsConsole
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
        public void Write(string C)
        {
            Console.Write(C);
        }

        public void WriteLine(string C)
        {
            Console.WriteLine(C);
        }
    }
}

