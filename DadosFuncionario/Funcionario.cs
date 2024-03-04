using System;

namespace DadosFuncionario
{

    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;

        public Funcionario(string nome, double salarioBruto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
        }

        public double CalcularSalarioLiquido()
        {
            return SalarioBruto * 0.9;
        }

        public void AumentarSalario(double aumento)
        {
            SalarioBruto += aumento;
        }
    }
}
