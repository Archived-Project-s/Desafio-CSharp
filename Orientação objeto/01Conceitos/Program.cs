using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar objetos

            Pessoa obj = new Pessoa();

            obj.nome = "Gabriel";
            obj.idade = 20;
            obj.mensagem();
        }
    }
}
