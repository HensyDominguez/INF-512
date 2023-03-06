using System;

class Salario
{
    static void Main(string[] args)
    {
        // Se solicita al usuario que ingrese los datos necesarios
        Console.Write("Ingrese el salario por hora: ");
        double salarioPorHora = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de horas trabajadas en la semana: ");
        int horasTrabajadas = int.Parse(Console.ReadLine());

        // Se calcula el salario bruto
        double salarioBruto;
        if (horasTrabajadas < 38)
        {
            salarioBruto = salarioPorHora * horasTrabajadas;
        }
        else
        {
            salarioBruto = (salarioPorHora * 38) + ((salarioPorHora * 1.5) * (horasTrabajadas - 38));
        }

        // Se calcula el impuesto
        double impuesto;
        if (salarioBruto <= 25000)
        {
            impuesto = 0;
        }
        else
        {
            impuesto = salarioBruto * 0.1;
        }

        // Se calcula el salario neto
        double salarioNeto = salarioBruto - impuesto;

        // Se muestra el resultado al usuario
        Console.WriteLine("Salario bruto: {0:N2}", salarioBruto);
        Console.WriteLine("Impuesto: {0:N2}", impuesto);
        Console.WriteLine("Salario neto: {0:N2}", salarioNeto);
    }
}
