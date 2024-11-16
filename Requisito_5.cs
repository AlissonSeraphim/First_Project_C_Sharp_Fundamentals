namespace desafio_1_rocketseat_fundamentos_c_sharp;

class Requisito_5
{
    /* 5. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário. */

    public static bool VerificaPadraoPlacaVeiculo(string? placa)
    {
        if (string.IsNullOrWhiteSpace(placa))
        {
            Console.WriteLine("Placa inválida");
            return false;
        }

        var hasValidLength = placa.Length == 7;

        var hasFirstThreeCharsAsLetters = char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]);

        var hasLastFourCharsAsNumbers = char.IsDigit(placa[3]) && char.IsDigit(placa[4]) && char.IsDigit(placa[5]) && char.IsDigit(placa[6]);

        var isPlacaValida = hasValidLength && hasFirstThreeCharsAsLetters && hasLastFourCharsAsNumbers;

        return isPlacaValida;
    }
}
