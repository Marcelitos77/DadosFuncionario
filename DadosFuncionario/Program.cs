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

            Funcionario funcionario = new Funcionario(nome, salarioBruto);

            double salarioLiquido = funcionario.CalcularSalarioLiquido();

            funcionario.AumentarSalario(aumento);

            double salarioLiquidoAposAumento = funcionario.CalcularSalarioLiquido();

            Console.WriteLine($"{funcionario.Nome}, seu salário líquido é {salarioLiquido:c2}\n");

            Console.WriteLine($"{funcionario.Nome}, seu salário após o aumento é {salarioLiquidoAposAumento:c2}");
        }
    }
}
