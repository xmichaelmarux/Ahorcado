using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoJuego
{
    internal class DibujoAhorcado
    {
        public static  int ContaVidas(int x)
        {
                if (x == 3)
                {
                    DibujoAhorcado.Cuerda();
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
        public static void Cabeza()
        {
            Console.WriteLine("  ______________________________");
            Console.WriteLine("  |                             |");
            Console.WriteLine("  |                             |");
            Console.WriteLine("  |                             ┴");
            Console.WriteLine("  |                           .___.");
            Console.WriteLine("  |                           |x x|");
            Console.WriteLine("  |                           |_º_|");
            Console.WriteLine("  |                               ");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                                 ");
            Console.WriteLine("  |                              ");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                                 ");
            Console.WriteLine("__|______________________\n\n");
        }
        public static void Cuerpo()
        {
            Console.WriteLine("  ______________________________");
            Console.WriteLine("  |                             |");
            Console.WriteLine("  |                             |");
            Console.WriteLine("  |                             ┴");
            Console.WriteLine("  |                           .___.");
            Console.WriteLine("  |                           |x x|");
            Console.WriteLine("  |                           |_º_|");
            Console.WriteLine("  |                            [|]");
            Console.WriteLine("  |                            /|\\");
            Console.WriteLine("  |                           / | \\");
            Console.WriteLine("  |                             |");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                                 ");
            Console.WriteLine("__|______________________\n\n");
        }
        public static void Completo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("  ______________________________");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" |                             ┴");
            Console.WriteLine(" |                           .___.");
            Console.WriteLine(" |                           |x x|");
            Console.WriteLine(" |                           |_º_|");
            Console.WriteLine(" |                            [|]");
            Console.WriteLine(" |                            /|\\");
            Console.WriteLine(" |                           / | \\");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" |                            / \\");
            Console.WriteLine(" |                           /   \\");
            Console.WriteLine("_|______________________\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Libre()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\t\t\t\t\t\t      .___.");
            Console.WriteLine("\t\t\t\t\t\t      |^ ^|");
            Console.WriteLine("\t\t\t\t\t\t      |_O_|");
            Console.WriteLine("\t\t\t\t\t\t      \\ | /");
            Console.WriteLine("\t\t\t\t\t\t       \\|/");
            Console.WriteLine("\t\t\t\t\t\t        |");
            Console.WriteLine("\t\t\t\t\t\t        |");
            Console.WriteLine("\t\t\t\t\t\t       / \\");
            Console.WriteLine("\t\t\t\t\t\t      /   \\");
            Console.WriteLine("\t\t\t\t----------------------------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void Cuerda()
        {
            Console.WriteLine("  ______________________________");
            Console.WriteLine("  |                             |");
            Console.WriteLine("  |                             |");
            Console.WriteLine("  |                             ┴");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                               ");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                                 ");
            Console.WriteLine("  |                              ");
            Console.WriteLine("  |                                ");
            Console.WriteLine("  |                                 ");
            Console.WriteLine("__|______________________\n\n");
        }
    }
}
