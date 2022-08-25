using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca01
{
    //Classe Funcionario extende da classe Pessoa.
    internal class Funcionario : Pessoa
    {
        private String NumPis;
        private float Salario;
        private String Setor;

        //Método construtor. 
        public Funcionario()
        {

        }

        public String getNumPis()
        {
            return NumPis;  
        }

        private void setNumPis(String numPis)
        {
            NumPis = numPis;
        }

        public float getSalario()
        {
            return Salario; 
        }

        private void setSalario(float salario)
        {
            Salario = salario;  
        }

        public String getSetor()
        {
            return Setor;
        }

        private void setSetor(String setor)
        {
            Setor = setor;  
        }

        //Método usa o ToString da classe pai como base e implementa os atributos da classe Funcionário.
        public override string ToString()
        {
            return "\n" + base.ToString() + "\nNúmero PIS: " + NumPis + "\nSalário: R$" + Salario + "\nSetor: " + Setor + "\n";
        }

        //Método para registrar o funcionário.
        public void RegistraFuncinario()
        {
            Console.WriteLine(">>> REGISTRO DE FUNCIONÁRIO <<<\n");

            RegistraPessoa();

            Console.Write("Digite o número do PIS: ");
            setNumPis(Console.ReadLine());

            Console.Write("Digite o salário do funcionário: R$");
            setSalario(float.Parse(Console.ReadLine()));

            Console.Write("Digite o setor do funcionário: ");
            setSetor(Console.ReadLine());
        }
    }
}
