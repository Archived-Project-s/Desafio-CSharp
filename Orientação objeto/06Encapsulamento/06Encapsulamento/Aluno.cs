using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    class Aluno
    {
        //Atributos 
        double nota1, nota2;

        // Média 
        private double media()
        {
            return (nota1 + nota2) / 2;
        }
        // Mensagem
        public void mensagem()
        {
            Console.WriteLine("Informe a primeira Nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a segunda Nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a media é " + media()); 
        }
    }
}
