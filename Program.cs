using System;

class Program
{
    static void Main()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;
        double total = sp +rj + mg + es + outros;

        double porcentagemsp = ((100/total) * sp);
        double porcentagemrj = ((100 / total) * rj);
        double porcentagemmg = ((100 / total) * mg);
        double porcentagemes = ((100 / total) * es);
        double porcentagemOutros = ((100 / total) * outros);

        Console.WriteLine("Porcentagem de SP é: " + porcentagemsp + "%");
        Console.WriteLine("Porcentagem de RJ é: " + porcentagemrj + "%");
        Console.WriteLine("Porcentagem de MG é: " +porcentagemmg + "%");
        Console.WriteLine("Porcentagem ES é: " + porcentagemes + "%");
        Console.WriteLine("Porcentagem de outros estados é: " + porcentagemOutros + "%");

    }
}
