using System;

class suma
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el valor de x: ");
        double x = double.Parse(Console.ReadLine());

        double result = 1.0;
        double term = 1.0;

        for (int n = 1; n <= 100; n++)
        {
            term *= x / n;
            result += term;
            Console.WriteLine("n = {0}, e^x = {1}", n, result);
        }

        Console.ReadKey();
    }
}
