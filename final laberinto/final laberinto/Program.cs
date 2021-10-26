using System;

namespace final_laberinto
{
    class Program
    {
        public const int anchomenosuno = 9;

        public const int yey = 2;

        public const int xux = 5;

        public const int grih = ancho * alto;

        public const int alto = 10;

        public const int ancho = 10;

        public const int tesoro = 64;

        public const int jugador = 37;

        public const int hueco = 0;

        public const int pared = 35;

        static int pj_x = 2;

        static int pj_y = 7;

        public static int[] grid = new int[5625];

        static void Menu()
        {

            Console.WriteLine(" 1.-Jugar\n" + " 2.-Instrucciones\n" + " 3.-Salir del juego \n");
            int mein_menu = Convert.ToInt32(Console.ReadLine());

            if (mein_menu == 1) { Game(); }
            if (mein_menu == 2) { Instrucciones(); }


        }

        static void Instrucciones()
        {
            Console.WriteLine("\n\n\n\n");

            Console.WriteLine("Bienvenidos al tres en raya a continuacion se expecificará las sencillas instruccionesdel juego que hará que revientes el ordenador contra el suelo:\n");
            Console.WriteLine("-El jugador puede moverse horizontalmente y hacia arriba\n");
            Console.WriteLine("-Los obstáculos impiden el avance al jugador mientras que los huecos le permiten el paso.\n");
            Console.WriteLine("-Al inicio de la partida se le da al jugador 10 créditos y se muestran siempre en pantalla.\n");
            Console.WriteLine("-Existen 3 armas o herramientas con las que el jugador pueden destruir obstáculos gastando una cantidad de créditos para cada una.\n");
            Console.WriteLine("-Si el jugador se queda sin créditos y no puede continuar avanzando, pierde la partida.\n");
            Console.WriteLine("-Si el jugador alcanza la casilla con el tesoro, gana la partida.\n");
            Console.WriteLine("-Las armas son las siguientes-->\n Goma elastica 1 moneda. \n Tirachinas 2 monedas. \n Chancla de tu madre 5 monedas.\n");

            Console.WriteLine("\n\n\n\n");

            Menu();
        }

        static void Pintar()
        {
            Console.Write("\n\n");

            for (int i = 0; i < grih; i++)
            {
                if (i % ancho == 0) { Console.Write("\n"); }


                char macaco = Convert.ToChar(grid[i]);
                Console.Write(macaco);

            }

            

        }
        static void Reset()
        {
            

            int tapper;

            Random rand = new Random();


            for (int i = 0; i < grih; i++)
            {
                tapper = rand.Next(2);

                if (tapper == 0)
                {
                    grid[i] = hueco;

                }
                else if (tapper == 1)
                {
                    grid[i] = pared;

                }

            }
            int x;

            Random rans = new Random();

            x = rand.Next(xux);

            int y;

            Random ran = new Random();

            y = rand.Next(yey);

            grid[x + ancho * y] = tesoro;

            grid[pj_x + ancho * pj_y] = jugador;

        }
        public static void MoverJugador()
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            Console.SetCursorPosition(pj_x, pj_y);

            if (tecla.Key == ConsoleKey.D)
            {
                if (grid[pj_x + ancho * pj_y] < grih)

                    if (grid[(pj_x + 1) + ancho * pj_y] == 0)

                        if (pj_x < anchomenosuno)
                        {
                            grid[pj_x + ancho * pj_y] = 0;

                            pj_x += 1;

                            grid[pj_x + ancho * pj_y] = jugador;

                        }
                if(grid[(pj_x + 1) + ancho * pj_y] == 64)
                {
                    Console.Clear();

                    Console.WriteLine("\f\n\n\n       HAS GANADO     \n\n");

                    Console.WriteLine("\n");

                    Menu();
                }
               
            }
            else if (tecla.Key == ConsoleKey.A)
            {
                if (grid[pj_x + ancho * pj_y] < grih)

                    if (grid[(pj_x - 1) + ancho * pj_y] == 0)

                        if (pj_x > 0)
                        {
                            grid[pj_x + ancho * pj_y] = 0;

                            pj_x -= 1;

                            grid[pj_x + ancho * pj_y] = jugador;
                        }
                   if (grid[(pj_x - 1) + ancho * pj_y] == 64)
                   {
                    Console.Clear();

                    Console.WriteLine("\f\n\n\n       HAS GANADO     \n\n");

                    Console.WriteLine("\n");

                    Menu();

                   } 
            }
            else if (tecla.Key == ConsoleKey.W)
            {
                if (pj_y > 0)

                    if (grid[pj_x + ancho * (pj_y - 1)] == 0)

                        if (pj_y > 0)
                        {
                            grid[pj_x + ancho * pj_y] = 0;

                            pj_y -= 1;

                            grid[pj_x + ancho * pj_y] = jugador;
                        }
                      if (grid[pj_x + ancho * (pj_y - 1)] == 64)
                      {
                          Console.Clear();

                          Console.WriteLine("\f\n\n\n       HAS GANADO     \n\n");

                          Console.WriteLine("\n");

                          Menu();

                      }

            }
            if (tecla.Key == ConsoleKey.D4)
            {
                for (int i = pj_y; i > 0; i--)
                {
                    grid[pj_x + ancho * i] = 0;
                }
            }
            if (tecla.Key == ConsoleKey.D5)
            {


            }
            if (tecla.Key == ConsoleKey.D6)
            {


            }
        }
        public static void Monedas()
        {

            int m = Convert.ToInt32(Console.ReadLine());

            m = 10;
           
            Console.Write("Moneditas" + m);

            if(m == 7) { m = 9; }

        } 
        static bool Game()
        {

            Reset();
           
            do
            {
                Pintar();

                MoverJugador();

                Console.Clear();

            } while (true);

            Console.WriteLine("\n\n");

            Menu();

            return false;

        }


        static void Main(string[] args)
        {
            Console.Write("Bienveidos al laberinto latinoamerica\n\n");
            Menu();
        }
    }
}
//for(int i = pj_y; i>0;i--;)
//grid[pj_x+ancho*i]=0

