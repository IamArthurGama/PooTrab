using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public static class Terminal
    {
        public static void Narrador(string Text)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(Text);
            
            Console.ResetColor();
        }
    }
}
