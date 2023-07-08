using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace AhorcadoJuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creo las Listas
            List<string> GuardaFrases = new() {
                "CELULAR","NEVERA","ORDENADOR","TELEVISOR",
                "AGUA","AIRE","FUEGO","TIERRA",
                "LUZ","ELECTRICIDAD","OSCURIDAD","RELAMPAGO",
                "MANZANA","PERA","MELOCOTON","PARAGUAYO"};
            List<string> Frutas = new() {
                "MANZANA","PERA","MELOCOTON","PARAGUAYO"};
            List<string> Objeto = new() {
                "CELULAR","NEVERA","ORDENADOR","TELEVISOR"};
            List<string> Elementos = new() {
                "AGUA","AIRE","FUEGO","TIERRA"};
            List<string> Energia = new() {
                "LUZ","ELECTRICIDAD","OSCURIDAD","RELAMPAGO"};

            List<string> AyudaFruta = new() {
               "Es una fruta", "Se puede comer", "Es dulce"};
            List<string> AyudaObjeto = new() {
               "Es un Objeto", "Esta presente en los hogares", "Se puede apagar y prender"};
            List<string> AyudaEnergia = new() {
               "Es energia", "Esta presente como magia en videojuegos", "Algunas de ellas podrian lastimarte"};
            List<string> AyudaElemento = new() {
                "Es un Elemento","El planeta los manifiesta en ocaciones de manera salvage","Gracias a ellos podemos vivir dentro del planeta"};

            //Utilizo Random para generar los numeros aleatorios y Regex para la validacion de caracteres especiales.
            Random Rnd = new ();
            Regex regex = new Regex("^[a-zA-Z0-9]+$");

            //Creo el menu principal del juego.
            string Opcion ;            
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t\t\t __________________________________________");
                Console.WriteLine("\n\t\t\t\t\t\t El AHORCADO");
                Console.WriteLine("\t\t\t\t __________________________________________\n\n\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Elige una opcion :\n\n" +
                                  "\t1) Genera una frase al azar y empieza a jugar\n" +
                                  "\t2) Mostrar frases del juego\n" +                                 
                                  "\t3) Mostrar los diferentes estados del ahorcado completo\n" +
                                  "\t0) Salir del juego. \n\n" +
                                  "Escribe una opcion:\n");
                Opcion = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Console.ResetColor();
                switch (Opcion)
                {
                    case "1":

                        //Variables
                        int ObtenerNum, Vidas = 3, i=0,Conta = 0, Ayudas= 3, EsObjeto, EsElemento, EsEnergia, EsFruta;
                        string ObtenerFrase , Aster = "" , AdivinaLetra, ObtenerFruta, ObtenerObjeto, ObtenerElemento, ObtenerEnergia, General="",Numbers="1234567890", FraCompleta="";
                        
                        //Genero una frase aleatoria
                        ObtenerNum = Rnd.Next(0, GuardaFrases.Count);
                        ObtenerFrase = GuardaFrases[ObtenerNum];
                        
                        //Genero los Asteriscos
                        foreach (var Valor in ObtenerFrase)
                        {
                            Aster += "*";
                        }     
                        
                        //Ciclo del juego por vidas
                        while (Vidas != 0)
                        {
                            // mientras que siga conteniendo asteriscos  se va a seguir ejecutando el programa hasta que se agoten las vidas o los asteriscos.
                            while (Aster.Contains("*"))
                            {                              
                                Console.ForegroundColor = ConsoleColor.White;                               
                                DibujoAhorcado.ContaVidas(Vidas);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"FRASE: {Aster}\t Pista: {General}\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine($"Tienes {Vidas} Oportunidades y {Ayudas} Ayudas\n");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($"Si quieres pedir ayuda Escribe ==> AYUDA <==\n" +
                                                   "Las ayudas salen de forma aleatoria y se podrian repetir\n");
                                Console.WriteLine($"Si sabes la frase completa escribe ==> FRASE <==\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escribe una letra para adivinar la frase: ");                                                                                             
                                AdivinaLetra = Convert.ToString(Console.ReadLine().ToUpper());

                                //Funcionamiento de la Opcion de adivinar la palabra entera para asi ganar o perder.                             
                                if (AdivinaLetra == "FRASE")
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nEscribe la la frase completa si aciertas ganas y sino pierdes todas las vidas:\n");
                                    FraCompleta = Convert.ToString(Console.ReadLine().ToUpper());
                                    if (ObtenerFrase.Equals(FraCompleta))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nFelicidades has acertado la palabra entera !!!\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;                                
                                    }
                                    else
                                    {                                       
                                        Vidas = 0;
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\nHas perdido, Te has equivocado de palabra !!!\n");
                                        Console.ForegroundColor = ConsoleColor.White;                                       
                                    }                                 
                                }

                                // Funcionamiento de las ayudas 
                                    if (AdivinaLetra == "AYUDA" && Ayudas > 0)
                                    {
                                        for (i = 0; i < Frutas.Count; i++)
                                        {                                 
                                            ObtenerFruta = Frutas[i];
                                            ObtenerObjeto = Objeto[i];
                                            ObtenerElemento = Elementos[i];
                                            ObtenerEnergia = Energia[i];
                                            if (ObtenerFrase.Equals(ObtenerFruta))
                                            {
                                            EsFruta = Rnd.Next(0, AyudaFruta.Count); ;

                                                General = AyudaFruta[EsFruta];
                                                break;
                                            }
                                            else if (ObtenerFrase.Equals(ObtenerElemento))
                                            {
                                            EsElemento = Rnd.Next(0, AyudaElemento.Count); ;

                                            General = AyudaElemento[EsElemento];
                                            break;
                                            }
                                            else if (ObtenerFrase.Equals(ObtenerEnergia))
                                            {
                                            EsEnergia = Rnd.Next(0, AyudaEnergia.Count); ;

                                            General = AyudaEnergia[EsEnergia];
                                            break;
                                            }
                                            else if (ObtenerFrase.Equals(ObtenerObjeto))
                                            {
                                            EsObjeto = Rnd.Next(0, AyudaObjeto.Count); ;

                                            General = AyudaObjeto[EsObjeto];
                                            break;
                                            }
                                        }
                                    Ayudas--;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\n»»»»»»»»»»»» Has usado una ayuda ««««««««««««");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    }
                                     
                                // Validaciones    
                                if(Ayudas <= 0 && AdivinaLetra.Contains("AYUDA"))
                                {
                                    Ayudas = 0;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\n»»»»»»»»»»»» No te quedan mas ayudas ««««««««««««");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (AdivinaLetra == "" || Aster.Contains(AdivinaLetra) || !regex.IsMatch(AdivinaLetra) && !AdivinaLetra.Contains("AYUDA") && !AdivinaLetra.Contains("FRASE") ||  AdivinaLetra.Length !> 1 && !AdivinaLetra.Contains("AYUDA") && !AdivinaLetra.Contains("FRASE") ||  Numbers.Contains(AdivinaLetra))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\n»»»»»»»»»»»» Escribe un caracter valido o ya lo has adivinado ««««««««««««");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }                             
                               else if (ObtenerFrase.Contains(AdivinaLetra))
                                {

                                    // Reemplazar los asteriscos por la letra correcta
                                    Conta = 0;
                                    int posicion = ObtenerFrase.IndexOf(AdivinaLetra);
                                    while (posicion != -1)
                                    {
                                        Conta++;

                                        //Remuevo e inserto en la posicion donde esta la letra a adivinar
                                        Aster = Aster.Remove(posicion, 1).Insert(posicion, AdivinaLetra);
                                        posicion = ObtenerFrase.IndexOf(AdivinaLetra, posicion + 1);                                      
                                    }
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine($"\nSe han encontrado {Conta} coincidencias :)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (!ObtenerFrase.Contains(AdivinaLetra) && !AdivinaLetra.Contains("AYUDA") && !AdivinaLetra.Contains("FRASE"))
                                {
                                    Vidas--;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine($"\nNo se han encontrado coincidencias :(");
                                    Console.ForegroundColor = ConsoleColor.White;                                   
                                }
                                if (Vidas <= 0)
                                {      
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n\n\t\t\t\t********** Lo siento pero has perdido !!!! **********\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine($"La frase oculta era : {ObtenerFrase.ToUpper()}\n\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    DibujoAhorcado.ContaVidas(Vidas);
                                    break;
                                }                              
                                VolverMenu.volverMenu();   
                            }
                            if (!Aster.Contains("*") || ObtenerFrase.Equals(FraCompleta))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n\n\t\t\t\t********** Felicidades has ganado !!!! **********\n\n");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine($"\t\t\t\tLa frase oculta era: { ObtenerFrase}\n\n");
                                DibujoAhorcado.Libre();
                            }
                            break;
                        }
                        VolverMenu.volverMenu();
                        break;
                    case "2":
                        string Frases;
                        int Count = 0;
                        Console.WriteLine("Frases del juego:\n\n ");
                        foreach (var Valor in GuardaFrases)
                        {
                            Count++;
                            Frases = Convert.ToString(Valor);
                            Console.WriteLine($"{Count}) {Frases}");
                        }
                        VolverMenu.volverMenu();
                        break;                  
                    case "3":
                        Console.ResetColor();
                        Console.WriteLine("Muerto:\n");
                        DibujoAhorcado.Completo();
                        Console.WriteLine("\nVivo:\n");
                        DibujoAhorcado.Libre();
                        VolverMenu.volverMenu();
                        break;
                    case "0":
                        Opcion ="";
                        break;
                    case "":
                        Opcion = "*";
                        break;
                }
            }
            while (Opcion != "");
        }
    }
}