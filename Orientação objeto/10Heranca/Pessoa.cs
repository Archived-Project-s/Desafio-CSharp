using System;

public class Pessoa
{
        //Atributos
        protected string nome;
        protected int idade;

        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
        }
}