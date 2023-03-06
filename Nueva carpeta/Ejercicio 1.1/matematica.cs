using System;

class matematica
{
    static void Main(string[] args)
    {
        bool otroEPS = true;

        while (otroEPS)
        {
            double a, b, c, d, f;
            Console.Write("Entre valor de a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Entre valor de b mayor que cero: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Entre valor de c: ");
            c = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Entre valor de d impar y mayor que cero: ");
                d = double.Parse(Console.ReadLine());
            } while (d % 2 == 0 || d <= 0);

            Console.Write("Entre valor de f: ");
            f = double.Parse(Console.ReadLine());

            // cálculo de la formula
            double resultado = a + Math.Sqrt(Math.Pow(b, c)) / (f + 9.2 + 5.6 * b - Math.Pow(Math.E, 2.87) / (c - d));

            // Muestra el resultado
            Console.WriteLine("Resultado = " + resultado);

            Console.Write("¿OTRO E-P-S? verdadero/falso: ");
            otroEPS = bool.Parse(Console.ReadLine());
        }

        Console.WriteLine("Fin del programa");
    }
}
