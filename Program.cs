using System;

namespace Ejemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Persona = "Edelmiro";
            int edad = 47;
            int sumatorio1 = 21;
            int sumatorio2 = 22;
            int suma = sumatorio1 + sumatorio2;
            int multiplicacion = suma * suma;
            int division = multiplicacion / suma;            

            var combinación = suma + multiplicacion + division + edad;
            
            Console.WriteLine("Nombre de persona: " + Persona);
            Console.WriteLine("Edad al cuadrado: " + edad + edad);
            Console.WriteLine("Una suma: " + suma);
            Console.WriteLine("Una multiplicación: " + multiplicacion);
            Console.WriteLine("Una división:" + division);
            Console.ReadKey();
            Console.WriteLine("Un potajillo: " + combinación);

            var grupo = new string[] { 
                "Elena",
                "Tomás",
                "Francisco",
                "Mariló",
                "Alberto",
                "Lourdes",
                "Jose",
                "Laura",
                "Ale",
                "Bego"
            };

            const string Entrada = "Buuuuuuuuuuuuuuuuuuuuenas tardes ";

            MensajeDeBienvenida();

            foreach (var miembro in grupo)
            {
                Saludar(miembro);
            }

            Console.ReadKey();
        }

        static void Saludar(string nombre)
        {
            Console.WriteLine("Hello " + nombre);
        }

        static void MensajeDeBienvenida()
        {
            Console.WriteLine("Si has llegado hasta aquí es que quieres más y más");
        }

        
        
    }
}
