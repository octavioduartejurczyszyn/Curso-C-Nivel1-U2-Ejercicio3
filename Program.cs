using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometros, velocidad, tiempo;
            Console.WriteLine("Escriba los kilómetros existentes entre dos ciudades:");
            kilometros = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la velocidad promedio de un vehículo");
            velocidad = float.Parse(Console.ReadLine());
            tiempo = kilometros / velocidad;
            Console.WriteLine("El tiempo aproximado de llegar de una ciudad a otra es: " + tiempo.ToString("0.00") + " horas");
        }
    }
}
