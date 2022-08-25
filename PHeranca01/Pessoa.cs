using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca01
{

    internal class Pessoa
    {
        private String Nome;
        private DateTime DataNasc;
        private String Cpf;

        //Método construtor. 
        public Pessoa()
        {

        }
        public string getNome()
        {
            return Nome;
        }

        private void setNome(String nome)
        {
            Nome = nome;
        }

        public DateTime getDataNasc()
        {
            return DataNasc;
        }

        private void setDataNasc(DateTime dataNasc)
        {
            DataNasc = dataNasc;
        }

        public string getCpf()
        {
            return Cpf;
        }

        private void setCpf(String cpf)
        {
            Cpf = cpf;
        }

        //Método sobrescreve o ToString da classe Object.
        public override string ToString()
        {
            return "Nome: " + Nome + "\nData de Nascimento: " + DataNasc.ToLongDateString() + "\nCPF: " + Cpf;   
        }
        
        //Método RegistraPessoa só pode ser chamado pela suas classes filhas.
        protected void RegistraPessoa()
        {
            Console.Write("Digite seu nome: ");
            setNome(Console.ReadLine());

            Console.Write("Digite sua data de nascimento: ");
            setDataNasc(DateTime.Parse(Console.ReadLine()));

            Console.Write("Digite seu CPF: ");
            setCpf(Console.ReadLine()); 
        }

    }
}
