using System;

public class Class3
{
    static void Main() 
    {
        Console.WriteLine("Digite o primeiro numero:");
        double? number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A soma entre esses dois números é: "+ (number1+number2));
        Console.WriteLine("A subtração entre os dois números é: "+ (number1-number2));
        Console.WriteLine("A multiplicação entre os dois números é: "+ (number1*number2));
        if (number2 == 0)
        {
            Console.WriteLine("Erro: divisão por zero não é permitida.");
        }
        else { 
            Console.WriteLine("A divisão entre os dois números é: " + (number1 / number2));
        }
        Console.WriteLine("A média entre os dois números é: "+ ((number1+number2)/2));
    }
}

