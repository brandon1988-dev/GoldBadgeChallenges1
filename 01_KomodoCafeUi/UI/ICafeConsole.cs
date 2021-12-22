using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafeUi.UI
{
    public interface ICafeConsole
    {
        string ReadLine();
        ConsoleKeyInfo ReadKey();
        void Clear();
        void Write(string M);
        void WriteLine(string M);

    }
}