using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca01
{
    // Classe Aluno extende da classe Pessoa
    internal class Aluno : Pessoa
    {
        private int Registro;
        private DateTime DataMatricula;

        //Método construtor. 
        public Aluno()
        {

        }

        public int getRegistro()
        {
            return Registro;    
        }

        private void setRegistro(int registro)
        {
            Registro = registro;    
        }

        public DateTime getDataMatricula()
        {
            return DataMatricula;
        }

        private void setDataMatricula(DateTime dataMatricula)
        {
            DataMatricula = dataMatricula;  
        }

        //Método usa o ToString da classe pai como base e implementa os atributos da classe Aluno
        public override string ToString()
        {
            return "\n" + base.ToString() + "\nRegistro: " + Registro + "\nData da Matrícula: " + DataMatricula.ToLongDateString() + "\n";
        }

        //Método para registrar o aluno
        public void RegistraAluno()
        {
            Console.WriteLine(">>> REGISTRO DE ALUNO <<<\n");
            RegistraPessoa();

            Console.Write("Digite o número do registro do aluno: ");
            setRegistro(int.Parse(Console.ReadLine()));

            Console.Write("Digite a data da matrícula: ");
            setDataMatricula(DateTime.Parse(Console.ReadLine()));
        }
    }
}
