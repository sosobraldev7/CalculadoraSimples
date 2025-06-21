using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_simples_com_Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            string operacao;

            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite a operação (+, -, *, /):");
            operacao = Console.ReadLine();


            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;

                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;

                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");

                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida. Por favor, use +, -, * ou /.");

                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
