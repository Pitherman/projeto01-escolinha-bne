using System;

class ValorFuturo
{
    public double valorPresente;
    public double taxa;
    public int periodo;


    public double valorF()
    {
        return (valorPresente*Math.Pow((1+taxa/100), periodo));
    }


    public void tabela()
    {
        double rendimento = Math.Round(valorF(), 2);
        Console.WriteLine("\n| Taxa: "+taxa+"% | Período: "+periodo+" meses | Rendimento: R$"+rendimento+" |\n");
    }
}