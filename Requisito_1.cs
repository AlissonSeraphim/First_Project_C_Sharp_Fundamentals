namespace desafio_1_rocketseat_fundamentos_c_sharp;

class Requisito_1
{
    // 1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
    public static void MensagemBoasVindas()
    {
        Console.Write("Por favor, insira seu nome completo: ");

        var MensagemInicial = $"Olá, {Console.ReadLine()}! Seja muito bem-vindo!";

        Console.WriteLine(MensagemInicial);
    }
}
