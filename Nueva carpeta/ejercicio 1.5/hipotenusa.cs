using System;

class hipotenusa {
    static void Main(string[] args) {
        double a, b, h;
        Console.Write("Ingrese la longitud del lado a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la longitud del lado b: ");
        b = double.Parse(Console.ReadLine());
        h = Math.Sqrt(a * a + b * b);
        Console.WriteLine("La hipotenusa del triángulo es: " + h);
    }
}
