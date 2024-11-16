namespace desafio_1_rocketseat_fundamentos_c_sharp;

class Requisito_4
{
    // 4. Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

    public static void ExibeQuantidadeCaracteres()
    {
        Console.Write("Forneça uma ou mais palavras aleatoria: ");
        var palavra = Console.ReadLine();

        var palavraSemEspacos = palavra?.Trim().Replace(" ", "");

        Console.WriteLine($"As palavras: {palavra} possuem {palavraSemEspacos?.Length} caracteres.");
    }
}
