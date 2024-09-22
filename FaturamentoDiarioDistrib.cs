 using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dados de faturamento diário
        var faturamentoDiario = new List<double>
        {
            22174.1664, 24537.6698, 26139.6134, 0.0, 0.0,
            26742.6612, 0.0, 42889.2258, 46251.174, 11191.4722,
            0.0, 0.0, 3847.4823, 373.7838, 2659.7563,
            48924.2448, 18419.2614, 0.0, 0.0, 35240.1826,
            43829.1667, 18235.6852, 4355.0662, 13327.1025, 0.0,
            0.0, 25681.8318, 1718.1221, 13220.495, 8414.61
        };

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0.0;
        int diasComFaturamento = 0;

        foreach (var faturamento in faturamentoDiario)
        {
            if (faturamento > 0)
            {
                if (faturamento < menorFaturamento)
                    menorFaturamento = faturamento;

                if (faturamento > maiorFaturamento)
                    maiorFaturamento = faturamento;

                somaFaturamento += faturamento;
                diasComFaturamento++;
            }
        }

        double mediaFaturamento = diasComFaturamento > 0 ? somaFaturamento / diasComFaturamento : 0.0;

        int diasAcimaDaMedia = 0;
        foreach (var faturamento in faturamentoDiario)
        {
            if (faturamento > mediaFaturamento)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine($"Menor faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
