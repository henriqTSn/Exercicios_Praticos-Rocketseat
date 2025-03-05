using System;

public class Class4
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra: ");
        string? input = Console.ReadLine();

        int quantidadeDeInput = input.Length;
        Console.WriteLine("A quantidade de caracteres é: " + quantidadeDeInput);
    }
}
