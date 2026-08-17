using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Level5
    {
        public static void Ejecutar()
        {
            // You see an old shopkeeper struggling to stack up variables in a window display. “Hoo-wee! All these
            // variable types sure are exciting but setting them all up to show them off to excited new programmers
            // like yourself is a lot of work for these aching bones,” she says. “You wouldn’t mind helping me set up this
            // program with one variable of every type, would you?”
            // Objectives:
            //     • Build a program with a variable of all fourteen types described in this level.
            //     • Assign each of them a value using a literal of the correct type.
            //     • Use Console.WriteLine to display the contents of each variable.

            byte yesornot = 0;
            int numero = 0;
            long numero2 = 0;
            char emoji = 'O';
            double decimales = 23.3;
            float decimales2 = 23.3f;
            decimal decimales3 = 23.3m;
            
            Console.WriteLine(yesornot);
            Console.WriteLine(numero);
            Console.WriteLine(numero2);
            Console.WriteLine(emoji);
            Console.WriteLine(decimales);
            Console.WriteLine(decimales2);
            Console.WriteLine(decimales3);
            
            

        }
    }
}