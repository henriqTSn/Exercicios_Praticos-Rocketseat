using System;

public class Class6
{
    static void Main()
    {
        Console.WriteLine("Digite a data em (dia da semana, dia do mês, mês, ano, hora, minutos, segundos): ");
        string? data1 = Console.ReadLine();
        Console.WriteLine("Digite a data no formato 01/03/2024: ");
        string? data2 = Console.ReadLine();
        Console.WriteLine("Digite a hora no formato de 24 horas: ");
        string? data3 = Console.ReadLine();
        Console.WriteLine("Digite a data com o mês por extenso: ");
        string? data4 = Console.ReadLine();

        Console.WriteLine(data1);
        Console.WriteLine(data2);
        Console.WriteLine(data3);
        Console.WriteLine(data4);
    }
}

