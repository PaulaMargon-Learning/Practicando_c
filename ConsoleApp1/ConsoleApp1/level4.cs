
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Level4
    {
        public static void Ejecutar()
        {
//            /*
//  * Reto: El Nombrador de Cosas 3000 (The Thing Namer 3000) 100 XP
//    Mientras caminas por la ciudad de Commenton, admirando sus edificios arquitectónicos basados en barras inclinadas, un
//    joven se te acerca preso del pánico. "Dejé caer mi Nombrador de Cosas 3000 (Thing Namer 3000) y se rompió. Creo que
//    funciona en su mayor parte, ¡pero todos los nombres de mis variables se reiniciaron! ¡No entiendo qué hacen!" Te
//    muestra el siguiente programa:
//    Console.WriteLine("What kind of thing are we talking about?");
//    string a = Console.ReadLine();
//    Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
//    string b = Console.ReadLine();
//    string c = "of Doom";
//    string d = "3000";
//    Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
//    "¡Tienes que ayudarme a descifrarlo!"
//    Objetivos:
//    Reconstruye el programa anterior en tu ordenador.
//    Añade comentarios cerca de cada una de las cuatro variables que describan lo que almacenan. Debes usar al menos
//    uno de cada tipo de comentario ( // y /* * / ).
//    Encuentra el error en el texto mostrado y corrígelo.
//    Responde a esta pregunta:
//  */
// 
Console.WriteLine("En que objeto estás pensando?");
string objeto = Console.ReadLine();
Console.WriteLine("Como lo describirias? Grande? Pequenio?");
string adjetivo = Console.ReadLine();
string doom = "Doom";
string numero = "3000";
Console.WriteLine("The " + adjetivo + " " + objeto + " of " + doom + " " + numero + "!");
        }
    }
}