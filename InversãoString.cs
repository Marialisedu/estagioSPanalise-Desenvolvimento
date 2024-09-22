using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();

        string inverted = InverterString(input);

        Console.WriteLine($"String invertida: {inverted}");
    }

    static string InverterString(string str)
    {
        char[] caracteres = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            caracteres[i] = str[str.Length - 1 - i];
        }

        return new string(caracteres);
    }
}
