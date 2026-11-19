using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = 10;
            float nombre_flottant = 3.54F;
            string texte = "Je suis une chaîne de caractères"; 
            Console.WriteLine("Hello World!");
            Console.WriteLine(nombre);
            Console.WriteLine(texte);
            if (nombre_flottant > 3.52F)
            {
                Console.WriteLine("Je suis un nombre supérieur à 3,52 !");
            }
        }
    }
}