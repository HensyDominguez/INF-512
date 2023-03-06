using System;

class numeroperfecto
{
    static void Main(string[] args)
    {
        int num = 2;
        int countPar = 0;
        int countImpar = 0;

        Console.WriteLine("Los tres primeros números perfectos pares son:");

        while (countPar < 3)
        {
            int sum = 1;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (num % 2 == 0 && sum == num)
            {
                Console.WriteLine(num);
                countPar++;
            }

            num += 2;
        }

        num = 1;

        Console.WriteLine("Los tres primeros números perfectos impares son:");

        while (countImpar < 3)
        {
            int sum = 1;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (num % 2 != 0 && sum == num)
            {
                Console.WriteLine(num);
                countImpar++;
            }

            num += 2;
        }

        Console.ReadKey();
    }
}
