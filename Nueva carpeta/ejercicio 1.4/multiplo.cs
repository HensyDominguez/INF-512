using System;

class multiplo {
    static void Main(string[] args) {
        // Lee los valores de M y N del usuario
        Console.Write("Ingrese el valor de M: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de N: ");
        int N = int.Parse(Console.ReadLine());

        // Encuentra los mĂșltiplos de 3 y 5 y almacenados en un arreglo
        int[] multiplos = new int[N - M + 1];
        int idx = 0;
        for (int i = M; i <= N; i++) {
            if (i % 3 == 0 || i % 5 == 0) {
                multiplos[idx] = i;
                idx++;
            }
        }

        // Calcula el promedio de los mĂșltiplos
        int sum = 0;
        for (int i = 0; i < idx; i++) {
            sum += multiplos[i];
        }
        double promedio = (double)sum / idx;

        // Muestra el resultado al usuario
        Console.WriteLine("El promedio de los mĂșltiplos de 3 y 5 en el intervalo [{0}-{1}] es {2}", M, N, promedio);
    }
}
