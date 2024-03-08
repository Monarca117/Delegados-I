using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_I
{
    internal class CPastel
    {
        public static void MostrarPastel(string pAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Este pastel llevara el mensaje de {0}", pAnuncio);
        }
    }
}
