using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutingsUI.UI
{
    public class RegularConsole : IOutingsConsole
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
        public void Write(string o)
        {
            Console.Write(o);
        }

        public void WriteLine(string o)
        {
            Console.WriteLine(o);
        }
    }
}
