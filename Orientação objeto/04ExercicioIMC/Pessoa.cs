using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Pessoa
    {
        //Atributos
        public double altura, peso;

        //Calculo
        public double calculo()
        {
            return peso / (altura * altura);
        }
        //Situacao
        public string situacao(double imc)
        {
            // Variavel
            string retorno = "";

            //Condicional
            if (imc < 18.5)
            {
                retorno = "Abaixo do Peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                retorno = "Peso Normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                retorno = "Acima do Peso";
            }
            else if (imc >= 30 && imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if (imc >= 35 && imc < 40)
            {
                retorno = "Obesidade II";
            }
            else if (imc >= 40)
            {
                retorno = "Obesidade III";
            }

            //Retorno
            return retorno;
        }

        public void mensagem()
        {
            //obter calculo
            double ObterCalculo = calculo();

            //obter situacao
            string ObterSituacao = situacao(ObterCalculo);

            Console.WriteLine("Seu IMC é de " + ObterCalculo + "\n sua situação é " + ObterSituacao);
        }
    }
}
