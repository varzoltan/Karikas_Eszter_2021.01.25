using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karikas_Eszter_2021._01._25
{
    class Program
    {
        static void Main(string[] args)
        {
            //2^0 - 2^32-ig kiírni 2 hatványait.
            long hatvany = 1;
            for (int i = 0;i<=32;i++)
            {
                //Console.WriteLine($"2^{i}={Math.Pow(2,i)}");
                if (i == 0)
                {
                    Console.WriteLine($"2^{i}=1");
                }
                else
                {
                    hatvany = hatvany * 2;
                    Console.WriteLine($"2^{i}={hatvany}");
                }
                
            }

            Console.WriteLine($"A téglalap területe: {Terulet()}");
            vonalhuz();
            Console.WriteLine($"\nA másik téglalap területe: {Terulet_parameterrel(6.0, 5)}");

            //Példa függvényre
            double a = 6.0;
            for (int i = 1;i<=10;i++)
            {
                Console.WriteLine($"Tizszer írom ki 5 szorzatát: {Terulet_parameterrel(a, i)}");
            }
            Console.ReadKey();
        }

        //függvény szabályai
        //1- Minden esetben az osztályon belül, de a MAIN-en kívül kell létrehozni.
        //2- A függvény kötelezően visszaad értéket.
        //3- Az első bejegyzés a láthatóság
        //  -publikus public
        //  -védett protected
        //  -statikus static
        //  -private 
        //4- A függvény visszatérési értékének a típusa
        //5- A függvény neve, nem lehet foglalt szó, kulcsszó
        //6- Paraméter vagy paraméterlista, de legalább egy üres zárójel kötelező
        //7- Változókat ugyanúgy létrehozhatunk a függvényen belül, mint a főprogramban
        //8- kötelezően hasznélni kell a return kulcsszót.
        static int Terulet()
        {
            int a = 5;
            int b = 6;
            return a * b;
        }

        static double Terulet_parameterrel(double a, int b)
        {
            return a * b;
        }

        //Eljárás szabályai
        //1- Minden esetben az osztályon belül, de a MAIN-en kívül kell létrehozni.
        //2- Az eljárás nem ad vissza értéket. (Csinál valamit)
        //3- Kötelezően kell tartalmaznia a láthatóság után a "void" kulcsszót!
        //4- Az első bejegyzés a láthatóság
        //  -publikus public
        //  -védett protected
        //  -statikus static
        //  -private
        //5- Az eljárás neve, nem lehet foglalt szó, kulcsszó
        //6- Paraméter vagy paraméterlista, de legalább egy üres zárójel kötelező
        //7- Változókat ugyanúgy létrehozhatunk az eljáráson belül, mint a főprogramban
        //8- Nem tartalmazza a return kulcsszót.

        //Példa eljárásra
        static void vonalhuz()
        {
            for (int i = 1;i<40;i++)
            {
                Console.Write("_");
            }
        }
    }
}
