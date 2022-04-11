using System;

public class Imposto
{

    //Métodos
    public virtual void valeAlimentacao(double salario)
    {
            Console.WriteLine("Desconto Padrão do Vale-Alimentação R$" + (salario * 0.1));
    }
    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do Vale-Transporte R$" + (salario * 0.06));
    }
}