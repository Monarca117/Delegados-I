using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_I
{
    internal class CRadio
    {
        public static void MetodoRadio(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Ests es tu mensaje {0}", pMensaje); 
        }
    }
}
