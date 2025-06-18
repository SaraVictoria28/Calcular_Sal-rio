using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calcular_Salario
{
    public class FuncionariComum : Funcionario

    {
        public FuncionariComum(string nome, string cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {
            Nome = nome;
            Cpf = cpf;
            SalarioBase = salarioBase;
        }

        public override double CalcularSalarioFinal()
        {
            return SalarioBase;
        }

        public override string ExibirDados()
        {
            return $"Nome: {Nome}, Comun | Salário Final: R${CalcularSalarioFinal()} ";
        }

    }
}