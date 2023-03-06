using System;

public class Program {
    public static void Main() {
        double x, y, z, w;

        Console.WriteLine("Ingrese el valor de x: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de z: ");
        z = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de w: ");
        w = Convert.ToDouble(Console.ReadLine());

        double resultado = 0.045 * x + 2.33 / Math.Pow(z, (x + 7.3 * w / (9.2 * z) - x * y)) * 2.1 - z / w * 4.5;

        Console.WriteLine("El resultado de la expresión es: " + resultado);
    }
}
