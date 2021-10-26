﻿using System;

namespace buscaminas
{
    class Tablero
    {
        public const int mina = 0;

        public const int minaslimite = 1;

        public const int ahoy = ancho * alto;

        public const int ancho = 10;

        public const int alto = 10;

        public int[] Agay = new int[ahoy];

        public Mina[] Paco = new Mina[minaslimite];

        public int a_x = 5;

        public int a_y = 5;



        public void Pintar()
        {
            for (int i = 0; i < ahoy; i++)
            {
                Console.Write(Agay[i]);

                if (i == 9) { Console.Write("\n"); }
                if (i == 19) { Console.Write("\n"); }
                if (i == 29) { Console.Write("\n"); }
                if (i == 39) { Console.Write("\n"); }
                if (i == 49) { Console.Write("\n"); }
                if (i == 59) { Console.Write("\n"); }
                if (i == 69) { Console.Write("\n"); }
                if (i == 79) { Console.Write("\n"); }
                if (i == 89) { Console.Write("\n"); }

            }

        }
        public void Minas()
        {
            for (int j = 0; j <= minaslimite; j++)
            {

                if (Agay[(Paco[j].x + 1) * ancho + Paco[j].y]!=mina)
                {

                    Agay[(Paco[j].x + 1) * ancho + Paco[j].y] +=1;

                }
                if (Agay[(Paco[j].x - 1) * ancho + Paco[j].y] != mina)
                {

                    Agay[(Paco[j].x - 1) * ancho + Paco[j].y] += 1;

                }
                if (Agay[(Paco[j].x + 1) * ancho + (Paco[j].y-1)] != mina)
                {

                    Agay[(Paco[j].x + 1) * ancho + (Paco[j].y-1)] += 1;

                }
                if (Agay[(Paco[j].x + 1) * ancho + (Paco[j].y+1)] != mina)
                {

                    Agay[(Paco[j].x + 1) * ancho + (Paco[j].y+1)] += 1;

                }
                if (Agay[Paco[j].x * ancho + (Paco[j].y + 1)] != mina)
                {

                    Agay[Paco[j].x * ancho + (Paco[j].y + 1)] += 1;

                }
                if (Agay[Paco[j].x  * ancho + (Paco[j].y - 1)] != mina)
                {

                    Agay[Paco[j].x * ancho + (Paco[j].y - 1)] += 1;

                }

            }

        }
        public void Moverse()
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            Console.SetCursorPosition(a_x, a_y);
            if (tecla.Key == ConsoleKey.UpArrow)
            {
                if (a_y > 0)
                {
                    a_y -= 1;
                }
                                
            }
            if (tecla.Key == ConsoleKey.DownArrow)
            {
                if (a_y < 9)
                {
                    a_y += 1;
                }

            }
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                if (a_x > 0)
                {
                    a_x -= 1;
                }

            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                if (a_x < 9)
                {
                    a_x += 1;
                }

            }
        }
        public void Game1()
        {
                
             Pintar();
            do
            {               
                
                Moverse();

                Console.Clear();                

                Pintar();

                Console.SetCursorPosition(a_x, a_y);

            } while (true);


        }
    }
    public class Mina
    {





    }
    class Program
    {
        public static void Instrucciones()
        {

              Console.Write("JUASJUAS");

        }

        public static void Menu()
        {

            Console.WriteLine(" 1.-JUGAR\n" + " 2.-INSTRUCCIONES\n" + " 3.-SALIR DEL JUEGO \n");

              int mein_menu = Convert.ToInt32(Console.ReadLine());
               if (mein_menu == 1)
               {

                  Tablero tab = new Tablero();
                  tab.Game1();

               }
               if (mein_menu == 2)
               {

                  Instrucciones();

               }


            }
            static void Main(string[] args)
            {

                Menu();

            }
        }
    
}   
