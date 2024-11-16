namespace desafio_1_rocketseat_fundamentos_c_sharp;

class Program
{
    static void Main(string[] args)
    {
        // Executa o primeiro requisito
        Requisito_1.MensagemBoasVindas();

        // Executa o segundo requisito
        Requisito_2.ExibeNomeCompleto();


        // Executa o terceiro requisito
            // Solicita os valores para exibição dos calculos

        Console.Write("Forneça o valor de PI: ");
        var pi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Forneça o valor do raio: ");
        var raio = Convert.ToDouble(Console.ReadLine());

        Requisito_3.ExibeCalculos(pi, raio);


        // Executa o quarto requisito
        Requisito_4.ExibeQuantidadeCaracteres();

        // Executa o quinto requisito
        Console.Write("Forneça a placa do veículo: ");

        var placaUsuario = Convert.ToString(Console.ReadLine());

        var resultadoPlaca = Requisito_5.VerificaPadraoPlacaVeiculo(placaUsuario) ? "Verdadeira" : "Falsa";

        Console.Write($"A placa é {resultadoPlaca} ");


        // Executa o sexto requisito
        Console.Write("A data atual é: ");

        Requisito_6.ExibeDataAtual();
    }
}

