using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoJuego
{
    internal class Ayudas
    {
        public static int ContaAyudas(int x)
        {

          
            if (x == 3)
            {
               
            }
            else if (x == 2)
            {
                DibujoAhorcado.Cabeza();
            }
            else if (x == 1)
            {
                DibujoAhorcado.Cuerpo();
            }
            else if (x <= 0)
            {
                DibujoAhorcado.Completo();
            }
            return x;
        }
    }
}
