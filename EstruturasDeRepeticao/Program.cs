#region Estruturas de Repetição

// int tabuada = 5;

// for(int n=0; n<=10; n++)
// {
//     Console.WriteLine($"{tabuada} * {n} = {tabuada * n}");
// }
#endregion

#region While

// int numero;
// Console.WriteLine("Digite um número positivo:");
// numero = int.Parse(Console.ReadLine()!);

// while (numero <= 0)
// {
//  Console.WriteLine("Número inválido! Digite um número positivo:");
//  numero = int.Parse(Console.ReadLine()!);
// }

#endregion

#region Do While

// char opcao;
// char continuar;

// do
// {
//     Console.WriteLine("---------------------------");
//     Console.WriteLine(" Escolha a opção");
//     Console.WriteLine("a) Somar");
//     Console.WriteLine("b) Subtração");
//     Console.WriteLine("Opção: ");
//     opcao = Console.ReadKey().KeyChar;

//     switch (opcao)
//     {
//         case 'a': Console.WriteLine("Somando Número"); break;
//         case 'b': Console.WriteLine("Subtraindo número"); break;
//         default: Console.WriteLine("Opção inválida"); break;
//     }
//     Console.WriteLine("---------------------------");
//     Console.WriteLine("Você deseja continuar?\na) Sim \nb) Não");
//     continuar = Console.ReadKey().KeyChar;
// } while (continuar == 'a');

#endregion

#region Fatorial de um número

// int fatorial, resultado = 1;

// Console.Write("Informa um número positivo: ");
// fatorial = int.Parse(Console.ReadLine()!);
// if (fatorial > 0)
// {
//     // for (int i = fatorial; i > 0; i--)
//     // {
//     //     Console.Write($"{i} ");
//     //     resultado *= i;
//     // }
//     for (int i = 1; i <= fatorial; i++)
//     {
//         Console.Write($"{i} ");
//         resultado *= i;
//     }
//     Console.WriteLine($"\nO fatorial é: {resultado}");
// }
// else
// {
//     Console.Write("Informe um número positivo");
// }

#endregion

#region Coleções String

// List<string> nomes = ["Alice", "Bob", "Claudio", "Matheus", "Felipe", "Devany", "Rael"];

// foreach (var nome in nomes)
// {
//     Console.WriteLine(nome);
// }

#endregion

#region Verificar se o número é par em coleções

// List<int> numeros = [1, 2, 3, 4, 34, 545, 66, 6666, 7777];
// int quantidadePares = 0;
// int limite = numeros.Count;
// for (int i = 0; i <= limite; i++)
// {
//     if (i % 2 == 0)
//     {
//        foreach (int numero in numeros)
//         {
//             if (numero % 2 == 0)
//             {
//                 Console.Write($"{numero} ");
//                 quantidadePares++;
//             }
//         }     
//     }
// }

// Console.Write($"\n A quantidade de Pares é: {quantidadePares}");
#endregion

#region Multiplos de 3, 5, 3 e 5.
// for(int i = 1; i <=50; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//         continue;
//     }
//     if (i % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//         continue;
//     }
//     if( i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//         continue;
//     }
//     Console.WriteLine(i);
// }
#endregion

#region Array e ignorar a que contém inicial 'A'

// string[] frutas = { "Maçã", "Banana", "Abacaxi", "Laranja", "Amora" };

// foreach (string fruta in frutas)
// {
//     if (fruta[0] == 'A')
//         continue;
//     // if (fruta.StartsWith('A'))
//     //     continue;
//     // if (fruta.StartsWith("A", StringComparison.OrdinalIgnoreCase))
//     //     continue;
//     Console.WriteLine(fruta);
// }
#endregion

#region Misturando Estruturas

// List<int> numeros= [];
// int soma = 0, quantidade = 5;

// for(int i = 0; i < quantidade; i++)
// {
//     numeros.Add(int.Parse(Console.ReadLine()!));
// }

// foreach (int numero in numeros)
// {
//     soma += numero;
// }

// Console.WriteLine("A média dos números é: " + soma/quantidade);
#endregion

#region 
int[] numeros = new int[5];
int soma = 0, quantidade = numeros.Length;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine()!);
}

foreach(int numero in numeros)
{
    soma += numero;
}
Console.WriteLine($"A média dos número é: {soma / quantidade}" );

#endregion

#region  Contagem regressiva

// int numero;

// numero = int.Parse(Console.ReadLine()!);
// do
// {
//     Console.WriteLine(numero);
//     numero--;
// } while (numero > -1);

#endregion