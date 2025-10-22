# region Positivo e Negativo
// var numero = 10;
// Console.Write($"Vamos verificar se o número {numero} é positivo ou negativo");
// if(numero > 0)
// {
//     Console.Write("Esse número é positivo.");
// }
// else
// {
//     Console.Write("Esse número é negativo.");
// }
#endregion
#region Exemplo 01
// var numero = 1;
// if (numero < 0)
// {
//     Console.WriteLine("Negativo VERDADEIRA");
//     Console.WriteLine("Positivo VERDADEIRA");
// }
// else
// {
//     Console.WriteLine("Positivo FALSA");
//     Console.WriteLine("Negativo FALSA");
// }
#endregion
#region Esta chovendo?

// // bool estava_chovendo;
// string estava_chovendo_string;
// estava_chovendo_string = Console.ReadLine()!;

// Console.WriteLine("SAINDO DE CASA \0/");
// if (estava_chovendo_string == "SIM")
// {
//     Console.WriteLine("LEVO O GUARDA-CHUVA");
//     Console.Write("CONTINUO O PASSEIO!!");
// }
// else
// {
//     Console.Write("CONTINUO O PASSEIO!!");
// }

#endregion
#region Estruta 
// char nota = 'B';


// switch (nota)
// {
//     case 'A':
//         Console.WriteLine("Excelente!");
//         break;
//     case 'B':
//         Console.WriteLine("Muito bom!");
//         break;
//     case 'C':
//         Console.WriteLine("Bom.");
//         break;
//     default:
//         Console.WriteLine("Nota não reconhecida.");
//         break;
// }
#endregion
#region  Menus if/else

// char opcao;
// Console.WriteLine("-----Escolha uma das opções-----");
// Console.WriteLine("a) Somar número");
// Console.WriteLine("b) Subtrair número");
// Console.WriteLine("c) Multiplicar número");
// Console.WriteLine("d) Dividir número");
// opcao = Console.ReadKey().KeyChar;

// switch (opcao)
// {
//     case 'a': Console.WriteLine("Somando Número"); break;
//     case 'b': Console.WriteLine("Subtrair Número"); break;
//     case 'c': Console.WriteLine("Mult  Número"); break;
//     case 'd': Console.WriteLine("Dividir Número"); break;
//     default: Console.WriteLine("Valor inválido"); break;
// }

// if(opcao == 'a')
// {
// Console.WriteLine("Somando Número");
// }
// else if(opcao == 'b')
// {
//     Console.WriteLine("Subtrair Número");
// }
// else if(opcao == 'c')
// {
// Console.WriteLine("Mult  Número");
// }
// else if(opcao == 'd')
// {
// Console.WriteLine("Dividir Número");
// }
// else
// {
//     Console.WriteLine("O valor é invalido ao menu");
// }
#endregion
#region  Operador Ternário - Se o for maior de idade

// int idade = 10;

// string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade";

// if (idade >= 18)
// {
//     Console.WriteLine("Maior de idade");
// }
// else
// {
//     Console.WriteLine("Menor de idade");
// }
// int idade = 20;


#endregion

#region Temperaturas em Celsius - Utilizando IF/ELSE

// int temperatura;

// Console.Write("Informe um valor inteiro para representar um temperatura: ");
// temperatura = int.Parse(Console.ReadLine()!);

// if(temperatura < 0)
// {
//     Console.WriteLine("Temperatura Negativa");
// }else if (temperatura >= 0 && temperatura <= 30)
//     {
//         Console.WriteLine("Temperatura Amena");
//     }
//     else
//     {
//         Console.WriteLine("Temperatura Alta");
//     }
#endregion

#region Resultado do Número - Operador Ternário

// int numero;

// Console.Write("Informe um número inteiro: ");
// numero = int.Parse(Console.ReadLine()!);

// string resultado_numero = numero > 0 ? "positivo" :
//                           numero < 0 ? "negativo" : 
//                           numero == 0 ? "zero" : "";

// Console.WriteLine($"O tipo de número é '{resultado_numero}'!");

#endregion

#region Categoria - Switch
char opcao_menu;

Console.WriteLine("----Informe a opção desejada----");
Console.WriteLine("- A");
Console.WriteLine("- B");
Console.WriteLine("- C");
Console.WriteLine("- D");
Console.Write("Opção: ");
opcao_menu = Console.ReadKey().KeyChar;

switch (opcao_menu.ToString().ToUpper())
{
    case "A": Console.WriteLine("\nProduto Alimentício"); break;
    case "B": Console.WriteLine("\nProduto Bebida"); break;
    case "C": Console.WriteLine("\nProduto Limpeza"); break;
    case "D": Console.WriteLine("\nProduto Eletrônico"); break;
    default: Console.WriteLine("\nCategoria inválida"); break;
}
#endregion









