namespace desafio_1_rocketseat_fundamentos_c_sharp;

class Requisito_6
{
    /* 6. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso. */

    public static void ExibeDataAtual()
    {
        var dataAtual = DateTime.Now;
        Console.WriteLine($"Data completa: {dataAtual}");
        Console.WriteLine($"Data no formato '16/11/2024': {dataAtual.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Hora no formato de 24 horas: {dataAtual.ToString("HH:mm:ss")}");
        Console.WriteLine($"Data com o mês por extenso: {dataAtual.ToString("dd/MMMM/yyyy")}");
    }

}
