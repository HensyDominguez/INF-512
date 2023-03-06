using System;

class notacionComputacional
{
    static void Main()
    {
        // Fórmula 1: y= (x-1)z / 2z-4t+1
        double x = 5.0;
        double z = 3.0;
        double t = 2.0;
        double y = (x - 1) * z / (2 * z - 4 * t + 1);
        Console.WriteLine("y = " + y);

        // Fórmula 2: Y= WZ+TX^2 / X+W+1
        double w = 2.0;
        double T = 3.0;
        double X = 4.0;
        double Y = w * z + T * Math.Pow(X, 2) / (X + w + 1);
        Console.WriteLine("Y = " + Y);

        // Fórmula 3: (2y-x+1) z + y / 4y
        double Y1 = 5.0;
        double X1 = 3.0;
        double Z1 = 2.0;
        double formula3 = (2 * Y1 - X1 + 1) * Z1 + Y1 / (4 * Y1);
        Console.WriteLine("formula3 = " + formula3);

        // Fórmula 4: TF= -2V0/g + Raiz cuadrada de (2v0/g)^2+ 8h/g / 2
        double v0 = 10.0;
        double g = 9.8;
        double h = 5.0;
        double TF = (-2 * v0 / g + Math.Sqrt(Math.Pow(2 * v0 / g, 2) + 8 * h / g)) / 2;
        Console.WriteLine("TF = " + TF);

        // Fórmula 5: AB= raiz cuadrada de (x1-x2)^2 + (y1-y2)^2
        double X2 = 1.0;
        double Y2 = 2.0;
        double AB = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
        Console.WriteLine("AB = " + AB);
    }
}
