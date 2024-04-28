using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inicio");

        try
        {
            // Solicitar al usuario que ingrese el primer número
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            // Solicitar al usuario que ingrese el segundo número
            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            // Calcular la suma y el producto de los dos números
            int suma = num1 + num2;
            int producto = num1 * num2;

            // Imprimir la suma y el producto
            Console.WriteLine("La suma de los números es: " + suma);
            Console.WriteLine("El producto de los números es: " + producto);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ha ingresado un valor no numérico.");
        }

        Console.WriteLine("Fin");
    }
}
