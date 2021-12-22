using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutingsUI.UI
{
        public interface IOutingsConsole
        {
            string ReadLine();
            ConsoleKeyInfo ReadKey();
            void Clear();
            void Write(string o);
            void WriteLine(string o);

        }
}
