namespace desafio_1_rocketseat_fundamentos_c_sharp;
class Requisito_2
{
    // 2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
    public static void ExibeNomeCompleto ()
    {

        Console.Write("Forneça seu primeiro nome: ");

        var primeiroNome = Console.ReadLine();

        Console.Write("Forneça seu segundo nome: ");

        var segundoNome = Console.ReadLine();


        Console.WriteLine("Seu nome completo:" + " " + primeiroNome + " " + segundoNome);
    }

}
