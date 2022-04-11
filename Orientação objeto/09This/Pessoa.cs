using System;

public class Pessoa
{
    // Atributo

    private string nome = "Jorge";

    // Construtor

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}