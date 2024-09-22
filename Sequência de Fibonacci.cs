using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero;

        if (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            return;
        }

        if (PertenceAFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceAFibonacci(int num)
    {
        int a = 0, b = 1;

        if (num == a || num == b)
            return true;

        while (b < num)
        {
            int temp = b;
            b = a + b; 
            a = temp; 
        }

        return b == num;
    }
}
