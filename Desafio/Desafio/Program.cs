using System;

namespace Desafio
{
    class Desafio
    {

        static int Main(string[] args)
        {
            // Banco do Brasil e Senai
            // Orev, Full Agile e Competence Center
            // Gabriel Amorim Martins Gonçalves

            int opcao;
            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Entrar no programa?");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Entrar");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 0;
                    Console.WriteLine("\nO valor digitado não é um inteiro... Fechando Programa...");
                    Console.ReadLine();
                }
                switch (opcao)
                {
                    case 1:
                        Calcula();
                        break;
                    default:
                        Console.WriteLine("\nOpção invalida (O programa apenas aceita 0 ou 1)");
                        break;
                }
            } while (opcao != 0) ;
return 0;
        }

        static void Calcula()
{
    try
    {
        Console.WriteLine("\nDigite a quantidade de lados:");
        string ladosstr = Console.ReadLine();
        Console.WriteLine("\nDigite o comprimento do lados:");
        string compstr = Console.ReadLine();
        double area = 0;
        int lados = 0;
        float comp = 0f;

        if (!int.TryParse(ladosstr, out lados) || !float.TryParse(compstr, out comp))
        {
            throw new Exception($"\nO valor digitado não é um inteiro...");
        }

        if (lados < 3)
        {
            throw new Exception($"\nA figura deve ter mais de 2 lados.");
        }
        else if (lados == 3)
        {
            area = areaTriangulo(comp);
            Console.WriteLine($"\nÁrea = {area:F2}");
        }
        else if (lados == 4)
        {
            area = Math.Pow(comp, 2);
            Console.WriteLine($"\nÁrea = {area:F2}");
        }
        else
        {
            area = lados * areaTriangulo(comp);
            Console.WriteLine($"\nÁrea = {area:F2}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(string.Format("Não foi possível executar o cálculo: {0}", ex.Message));
    }
}

static double areaTriangulo(float comp)
{
    float baseTriangulo = comp;
    double altura = (comp * Math.Sqrt(3)) / 2;

    return (baseTriangulo * altura) / 2;
}
    }
}
