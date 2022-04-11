using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string pNome, int pIdade)
        {
            this.nome = pNome;
            this.idade = pIdade;
        }
        public String getNome()
        {
            return nome;
        }
        public void setNome(String Nome)
        {
            this.nome = nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int Idade)
        {
            this.idade = idade;
        }

        private void ExibirDados(string nome, int idade)
        {
            Console.WriteLine("O Nome da pessoa é: " + nome + " e sua idade é: " + idade);
        } 
    }
}
