using System;

namespace PHeranca01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Aluno aluno = new Aluno();

            funcionario.RegistraFuncinario();
            Console.WriteLine(funcionario.ToString());

            aluno.RegistraAluno();
            Console.WriteLine(aluno.ToString());
        }
    }
}
