using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "549.879.157-20");
            carlos.Nome = "Carlos";
            
            carlos.AumentarSalario();


            Console.WriteLine("Novo salário do Carlos " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.658.148-32");
            roberta.Nome = "Roberta";

            Console.WriteLine(roberta.CPF);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);


            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("novo salário de Roberta " + roberta.Salario);

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());


            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
