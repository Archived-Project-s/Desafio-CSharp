using System;

class PessoaJuridica : Padrao
{

    //Método Obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de Emprestimo para pessoa Juridica R$ " +(valor * 0.2));
    }

}