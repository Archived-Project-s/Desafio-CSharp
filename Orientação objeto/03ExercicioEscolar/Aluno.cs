using System;

class Aluno
{

    //Atributos
    public string nome;
    public double nota1,nota2;

    //Média
    public double media()
    {
        return (nota1+nota2)/2;
    }

    //Situacao

    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    //Mensagem

    public void mensagem()
    {
        //obter media
        double obtermedia = media();

        //obter situacao
        string obtersituacao = situacao(obtermedia);

        //mensagem
        Console.WriteLine(nome + " está " + obtersituacao + " com média de " + obtermedia);

    }
}