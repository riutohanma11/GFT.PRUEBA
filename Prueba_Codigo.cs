using System;
//HOLA SOZ ZO
class Program
{
    static void Main()
    {
        // Solicitar al usuario el primer número
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
 
        // Solicitar al usuario el segundo número
        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
 
        // Llamar a la función de suma
        double resultado = Suma(numero1, numero2);
 
        // Mostrar el resultado
        Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");
    }
 
    // Función para sumar dos números
    static double Suma(double num1, double num2)
    {
        return num1 + num2;
    }
}