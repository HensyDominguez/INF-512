using System;
class HolaMundo
{
 static void Main()
    {
        String nombre, matricula;

        Console.Write("nombre:");
        nombre = Console.ReadLine();

        Console.Write("\nmatricula:");
        matricula = Console.ReadLine();
        
        Console.Write("\n Hola mundo\n");
        Console.Write("su nombre es: \t\t" + nombre);
        Console.Write("su matricula es \t" + matricula);


    
    }
}