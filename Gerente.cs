using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcular_Salario
{
    public class Gerente : Funcionario
    {
        public double Bonus = 2000;

        public Gerente(string nome, string cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {
            Nome = nome;
            Cpf = cpf;
            SalarioBase = salarioBase;
        }

        public override double CalcularSalarioFinal()
        {
            return SalarioBase + Bonus;
        }

        public override string ExibirDados()
        {
            return $"Nome: {Nome}, Gerente | Salário Final: R${CalcularSalarioFinal()} ";
        }
    }
}