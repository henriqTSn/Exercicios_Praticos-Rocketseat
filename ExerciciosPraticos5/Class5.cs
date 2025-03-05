using System;

public class Class5
{
    static void Main()
    {
        Console.WriteLine("Digite a placa do seu carro, EX: abc1234 :");
        String? placa = Console.ReadLine();

        bool placaValida = VerificarPlaca(placa);
        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
    }
    static bool VerificarPlaca(string placa) 
    {
        if (placa.Length != 7)
        {
            return false;
        }
        for (int i = 0; i < 3; i++)
        {
            //Verifica se é uma letra
            if (!char.IsLetter(placa[i])) 
            {
                return false;
            }
        }
        for (int i = 3; i < 7; i++)
        {
            //IsDigit verifica se o caractere for um dígito (0-9)
            if (!char.IsDigit(placa[i]))
            {
                return false;
            }
        }
        return true;
    }
}