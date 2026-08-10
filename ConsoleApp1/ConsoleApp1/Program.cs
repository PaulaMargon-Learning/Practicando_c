// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Ejercicios
{
    /* EJERCICIO
    En este problema vas a declarar e inicializar una variable de tipo entero. Cuando hablamos de inicializar nos referimos a asignarle un valor.

    Entonces, debajo del comentario, pero encima del return, debes:

        1) Declarar una variable de tipo int y nombre elSignificadoDeLaVida

        2) Asígnale el valor 42

    Remueve las dos líneas indicadas más abajo para descomentar el código y comenzar el ejercicio.
     */

    public class NumerosEnteros
    {

        public int Ejercicio()
        {
            // Tu código debajo de esta línea

            int elSignificadoDeLaVida = 42;

            return elSignificadoDeLaVida;
        }

    }
}

/*
 * EJERCICIO
En este problema vas a declarar e inicializar una variable de tipo DateTime con una fecha y hora específica.

Entonces, debajo del comentario, pero encima del return, debes:

1) Declarar una variable de tipo DateTime y nombre fecha

2) Asignarle la fecha 12 de mayo a las 10 de la mañana. El año puede ser cualquiera (puedes poner el año actual).

Remueve las dos líneas indicadas más abajo para descomentar el código y comenzar el ejercicio.

DateTime fecha = new DateTime(2026, 5, 12, 10, 0, 0);
*/

var cantidad1 = 7;
var cantidad2 = 4;
var resultadoSuma = cantidad1 + cantidad2;
var resultadoResta = cantidad1 - cantidad2;

Console.WriteLine("La suma es " + resultadoSuma);
Console.WriteLine($"La suma de {cantidad1} y {cantidad2} es igual a: {resultadoSuma")