using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autor: Miguel Angel Arellano Juárez
 * Fecha: 12/02/2024
 * Versión: 1.0.0.0
 * Modificación: 08/03/2024
 */

namespace Delegados_I
{
    internal class Program
    {
        public delegate void MiDelegado(string m);
        static void Main(string[] args)
        {
            //Se crea el objeto del delegado y se referencia a el metodo que queremos
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);
            
            //Se hace uso del metodo a traves del delegado
            delegado("El demonio de la radiooooo");

            //Se apunta a otra clase
            delegado = new MiDelegado(CPastel.MostrarPastel);

            delegado("Toma pastel en la cara");
        }
    }
}
