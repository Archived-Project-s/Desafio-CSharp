using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando Obj Pessoa
            Pessoa a = new Pessoa();

            a.altura = 1.69;
            a.peso = 47;
            a.mensagem();
            Console.ReadLine();
        }
    }
}
