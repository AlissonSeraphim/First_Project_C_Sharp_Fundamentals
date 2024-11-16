namespace desafio_1_rocketseat_fundamentos_c_sharp;

internal class Requisito_3

{
    /* 3. Crie um programa com 2 valores do tipo**`double`** já declarados ****que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
    - A média entre os dois números. */


    //const Double pi = 3.14;

    //const Double raio = 2.52;

    private static Double Somar (Double pi, Double raio) => pi + raio;

    private static Double Subtrair (Double pi, Double raio) => pi - raio;

    private static Double Multiplicar (Double pi, Double raio) => pi * raio;
    
    private static Double Dividir (Double pi, Double raio) => (raio != 0 || raio > 0) ? pi / raio : 0.00;

    private static Double MediaDeValores(Double pi, Double raio) => Somar(pi, raio) / 2;


    public static void ExibeCalculos(Double pi, Double raio)
    {
        Console.WriteLine($"Soma: {Somar(pi, raio)}");
        Console.WriteLine($"Subtração: {Subtrair(pi, raio)}");
        Console.WriteLine($"Multiplicação: {Multiplicar(pi, raio)}");
        Console.WriteLine($"Divisão: {Dividir(pi, raio)}");
        Console.WriteLine($"Média: {MediaDeValores(pi, raio)}");
    }


}
