#region Analise
// int contador = 0;

// for (int i = 0; i < 10; i++)
// {
//     if (i % 3 == 0)
//         continue;
//     Console.WriteLine(i);
//     contador++;
// }
// Console.WriteLine($"O contador tem a quantidade {contador}");
#endregion
#region 01
// int numero = int.Parse(Console.ReadLine()!);

// for (int i = 1; i <=10; i++)
// {
//     Console.WriteLine($"{i} x {numero} = {i * numero}");
// }
#endregion

#region 02
// int numero, soma = 0;
// do
// {
//     numero = int.Parse(Console.ReadLine()!);
//     soma += numero;
// } while (numero != 0);
// Console.WriteLine($"A soma de número é {soma}");

#endregion

#region  03

// int numero = int.Parse(Console.ReadLine()!);
// int fatorial=1;
// for (int i = numero; i > 0; i--)
// {
//     fatorial *= i;
// }
Console.Write("Digite um número inteiro não negativo para calcular o fatorial: ");
bool valido = int.TryParse(Console.ReadLine(), out int numero);
if (!valido || numero < 0)
{
    Console.WriteLine("Entrada inválida. Digite um inteiro não negativo.");
}
else
{
    long fatorial = 1;
    for (int i = numero; i > 1; i--)
    {
        fatorial *= i;
    }
    Console.WriteLine($"{numero}! = {fatorial}");
}

#endregion

#region 04

// string palavra = Console.ReadLine()!;
// int contador = 0;
// string vogais = "aeiou";
// for (int i = 0; i < palavra.Length; i++)
// {
// char isVogal = char.ToLower(palavra[0]);
//     if(isVogal == 'a' || isVogal == 'e' || isVogal == 'i' || isVogal == 'o' || isVogal == 'u' )
//         contador++;
// }
// foreach (char isVogal in palavra)
// {
//     if(vogais.Contains(isVogal))
//         contador++;
// }
// Console.WriteLine($"A palabra {palavra} tem {contador} vogais");
#endregion

#region 05
// Escreva um programa que peça ao usuário um número inteiro positivo 'n' e 
// imprima um pirâmide de asteriscos com 'n' linhas
// Exemplo
// n = 4
//    *
//   ***
//  *****
// *******

// int n;

// n = int.Parse(Console.ReadLine()!);
// for (int x = 0; x < n; x++)
// {
//     for (int y = 0; y < n - x - 1; y++)
//     {
//         Console.Write(" ");
//     }
//     for (int z = 0; z < x * 2 + 1; z++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
#endregion
