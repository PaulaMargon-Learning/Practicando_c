using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Level3
    {
        public static void Ejecutar()
        {
            //EJERCICIO//
            //            Estas tierras llevan mucho tiempo sin ver programación debido a la plaga del Sin Codificar.Incluso los viejos
            //programas se están desmoronando ahora.Tus habilidades con la programación son aún incipientes, pero puedes
            //marcar la diferencia en la vida de estas personas.Quizá algún día, en un futuro próximo, tus habilidades se hayan fortalecido
            //lo suficiente como para enfrentarte directamente al Sin Codificar. Pero, por ahora, decides hacer lo que puedas para ayudar.
            //En la cercana ciudad de Consolas, la comida escasea. Telim tiene un horno mágico capaz de producir pan de
            //la nada. Está dispuesto a compartirlo, pero Telim es un exceliano, y a los excelianos les encanta el papeleo; lo exigen para
            //todas las transacciones, sin excepciones.Telim compartirá su pan con la ciudad si consigues crear un programa que
            //le permita introducir los nombres de quienes lo recibirán. Una ejecución de prueba de este programa tiene este aspecto:
            //El pan está listo.
            //¿Para quién es el pan?
            //RB
            //Anotado: RB ha recibido pan.

            Console.WriteLine("El pan está listo");
            Console.WriteLine("¿Para quién es el pan?");
            var Nombre = Console.ReadLine();
            Console.WriteLine("Anotado: " + Nombre + " ha recibido pan");


        }
    }
}
