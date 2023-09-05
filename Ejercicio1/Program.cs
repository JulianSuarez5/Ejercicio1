using System;

class SumaDosNumeros
{
    static void Main()
    {
        int num1, num2, suma;

        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        suma = num1 + num2;

        Console.WriteLine("La suma es: " + suma);
        Console.ReadKey();
    }
}