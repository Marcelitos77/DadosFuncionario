using System;

namespace DadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu salário bruto:");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do aumento:");
            double aumento = double.Parse(Console.ReadLine());

            double salarioLiquido = salarioBruto * 0.9;
            double salarioLiquido2 = (salarioBruto + aumento) * 0.9;

            Console.WriteLine($"{nome}, seu salário líquido é {salarioLiquido:c2}\n");

            Console.WriteLine($"{nome}, seu salário após o aumento é {salarioLiquido2:c2}");

        }
    }
}
