using System;

class PessoaFisica : Padrao
{

    //Método Obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de Emprestimo para pessoa Física R$ " +(valor * 0.1));
    }

}