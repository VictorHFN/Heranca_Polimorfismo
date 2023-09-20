using ExemproHeranca;

class Progam
{

    static void Main(string[] arg)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        n1.Nome = "João da Silva";
        n1.Sexo = 'M';

        FuncionarioN2 n2 = new FuncionarioN2();
        n2.Nome = "Joaquim Fino";
        n2.Sexo = 'F';
        n2.Idade = 66;
    
        Console.WriteLine("Nome do funcionário é " + n1.Nome + "O sexo é " + n1.Sexo);
        Console.WriteLine("\nA comissão é " +n1.participacaoLucro().ToString());

        Console.WriteLine("---------------------------------------------------------\n");
        Console.WriteLine("O nome do funcionário é " + n2.Nome + "O sexo é " + n2.Sexo);
        Console.WriteLine("\nA idade é " + n2.Idade);
        Console.WriteLine("\nA comissão é "+n2.participacaoLucro().ToString());
    }
}