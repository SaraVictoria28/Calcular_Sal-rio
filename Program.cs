// See https://aka.ms/new-console-template for more information

using System;
using Calcular_Salario;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>
            {
                new Gerente("Ana", "147.258.369-12", 5000.00),
                new Estagiario("João", "69.258.147-33", 1920.00),
                new FuncionariComum("Carlos", "123.456.789-00",3000.00)
            };

            foreach ( var empregado in funcionario)
            {
                empregado.ToString();
            }
        }
    }
}