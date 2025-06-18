using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calcular_Salario
{
    public class Estagiario : Funcionario
    {
        public double Desconto = 0.2;
        public Estagiario(string nome, string cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {
            Nome = nome;
            Cpf = cpf;
            SalarioBase = salarioBase;
        }

        public override double CalcularSalarioFinal()
        {
            return SalarioBase - (SalarioBase * Desconto);
        }

        public override string ExibirDados()
        {
            return $"Nome: {Nome}, Estagiário | Salário Final: R${CalcularSalarioFinal()} ";
        }

    }
}