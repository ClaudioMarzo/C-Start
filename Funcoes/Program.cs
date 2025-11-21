#region 1. Função que calcula o fatorial de um número
// Crie uma função int Fatorial(int n) que calcula o fatorial de um número inteiro.
// Teste a função com alguns valores.

// Entrada
// Console.Write($"Informe um número: ");
// bool valido = int.TryParse(Console.ReadLine()!, out int n);

// if(valido){
//     //Processamento
//     int fatorial = Fatorial(n);
//     //Saida
//     Console.WriteLine($"O fatorial de {n} é {fatorial}");
// }else{
//     Console.WriteLine($"Valor informado inválido");
// }

// int CalcularFatorial(int n){
//     int fatorial = 1;
//     for(int x = n; x > 0; x--)
//     {
//         fatorial *= x;
//     }
//     return fatorial;
// }




#endregion

#region 2. Função que verifica se uma string é palíndrome
// Crie uma função bool EhPalindromo(string texto) 
// que retorna true se o texto for um palíndrome (lê-se igual de trás para frente), 
// ignorando espaços e diferenças entre maiúsculas/minúsculas.


// Console.Write("Digite uma frase: ");
// string frase = Console.ReadLine()!;

// if(EhPalindromo(frase))
// {
//     Console.WriteLine($"A palavra '{frase}' é um Palíndrome!!");
// }else{
//     Console.WriteLine($"A palavra '{frase}' não é um Palíndrome!!");
// }

// bool EhPalindromo(string texto) {
//     int inicio = 0, fim = texto.Length - 1;

//     while(inicio < fim){
//         if(texto[inicio] != texto[fim])
//             return false;
//         inicio++;
//         fim--;
//     }
//     return true;
// }






#endregion
 
#region Componentizando código Prática

// void ImprimirLinhas(){
//     Console.WriteLine("--------------------------------------");
// }

// double ConverterCelsiusParaFahrenheit(double temperatura){
//     return (temperatura * 9 / 5) + 32;
// }
// void ConverterFahrenheitParaCelsius(){
//     double temperatura, resultado;
//     Console.Write("Digite a temperatura em Fahrenheit: ");
//     temperatura = double.Parse(Console.ReadLine()!);
//     resultado = (temperatura - 32) * 5 / 9;
//     Console.WriteLine($"{temperatura}°F = {resultado:F2}°C");
// }
// void ConverterCelsiusParaKelvin(){
//     double temperatura, resultado;

//     Console.Write("Digite a temperatura em Celsius: ");
//     temperatura = double.Parse(Console.ReadLine()!);
//     resultado = temperatura + 273.15;
//     Console.WriteLine($"{temperatura}°C = {resultado:F2}K");
// }
// void ConverterKelvinParaCelsius(){
//     double temperatura, resultado;

//     Console.Write("Digite a temperatura em Kelvin: ");
//     temperatura = double.Parse(Console.ReadLine()!);
//     resultado = temperatura - 273.15;
//     Console.WriteLine($"{temperatura}K = {resultado:F2}°C");
// }
// string continuar;

// do
// {
//     ImprimirLinhas();
//     Console.WriteLine("Conversor de Temperatura");
//     Console.WriteLine("Escolha a opção de conversão:");
//     Console.WriteLine("1 - Celsius para Fahrenheit");
//     Console.WriteLine("2 - Fahrenheit para Celsius");
//     Console.WriteLine("3 - Celsius para Kelvin");
//     Console.WriteLine("4 - Kelvin para Celsius");
//     Console.Write("Opção: ");

//     string opcao = Console.ReadLine()!;
//     double temperatura;

//     ImprimirLinhas();
//     switch (opcao)
//     {
//         case "1": 
//             Console.Write("Digite a temperatura em Celsius: ");
//             temperatura = double.Parse(Console.ReadLine()!);
//             Console.WriteLine($"{temperatura}°C = {ConverterCelsiusParaFahrenheit(temperatura):F2}°F"); 
//         break;
//         case "2": ConverterFahrenheitParaCelsius(); break;
//         case "3": ConverterCelsiusParaKelvin(); break;
//         case "4": ConverterKelvinParaCelsius(); break;
//         default: Console.WriteLine("Opção inválida!"); break;
//     }
//     ImprimirLinhas();
//     Console.Write("Deseja fazer outra conversão? (S/N): ");
//     continuar = Console.ReadLine()!;
//     Console.WriteLine();

// } while (continuar.Equals("S", StringComparison.OrdinalIgnoreCase));

// Console.WriteLine("Programa encerrado.");

#endregion

// ------------------- ATIVIDADE -------------------------

#region Olá Mundo

// void ExibirMensagem(){
//   Console.WriteLine("Olá, mundo!");  
// } 

// ExibirMensagem();
#endregion

#region Exibir Saudação Personalizada

// void ExibirSaudacao(string mensagem){
//     Console.WriteLine($"Olá, {mensagem}");
// }

// ExibirSaudacao(mensagem: "Cláudio");
#endregion

#region Retornar Número Aleatório

// int GerarNumeroAleatorio(){
//     Random random = new Random();
//     return random.Next(1, 100);
// }

// Console.WriteLine($"O número aleatório gerado foi: {GerarNumeroAleatorio()}");
#endregion

#region Calcular o Quadrado de um número

// int GerarQuadradoDoNumero(int numero){
//     return numero * numero;
// }

// int numeroInformado = 8;
// Console.WriteLine($"O quadrado do número {numeroInformado} é {GerarQuadradoDoNumero(numero: numeroInformado)}");

#endregion

#region Somar dois números

// int SomarDoisNumeros(int a, int b){
//     return a + b;
// }

// int numeroI = 3, numeroII = 6;

// Console.WriteLine($"A soma de '{numeroI}' e '{numeroII}' é '{SomarDoisNumeros(a: numeroI, b: numeroII)}'");
#endregion

#region Calcular Fatorial de um número

// int CalcularFatorial(int n){
//     int fatorial = 1;
//     for(int i = n; i > 1; i--){
//         fatorial *= i;
//     }
//     return fatorial;
// }

// int fatorial = 5;

// Console.WriteLine($"O fatorial de {fatorial} é {CalcularFatorial(fatorial)}");
#endregion

#region Inverter uma String

// string InverterString(string palavra)
// {
//     string palavraInvertida = "";  
//     int tamanhoPalavra = palavra.Length - 1;

//     for (int i = tamanhoPalavra ; i >= 0; i--)
//     {
//         palavraInvertida += palavra[i];  
//     }

//     return palavraInvertida;
// }

// string palavra = "Amor";
// Console.WriteLine($"A forma invertida da palavra '{palavra}' é '{InverterString(palavra)}'");
#endregion

#region Verificar Palindromo

bool VerificarPalindromo(string palavra){
    int tamanhoPalavra = palavra.Length - 1;
    int inicial = 0, final = tamanhoPalavra;

    while(inicial < final){
        if(palavra[inicial] != palavra[final])
            return false;
        inicial++;
        final--;
    }
    return true;
}

string palavra = "ARARA";

if (VerificarPalindromo(palavra))
{
    Console.WriteLine($"A palavra '{palavra}' é um Palíndromo");
}else{
    Console.WriteLine($"A palavra '{palavra}' não é um Palíndromo");
}
    
#endregion

#region Encontrar o Maior em um array

// int MaiorNumeroDaLista(int[] numero ){
//     int tamanho = numero.Length ;
//     int maior = 0;

//     for(int i = 0; i < tamanho; i++){
//         if(numero[i] > maior)
//             maior = numero[i];
//     }
//     return maior;
// }

// int[] numero = [10002,1,1,1,100,1000];

// Console.WriteLine($"O maior número da lista é {MaiorNumeroDaLista(numero)}");

#endregion

#region Contar a Ocorrência de um Caractere em uma String

int OcorrenciaDeUmCaractere(string palavra, char buscarCaractere)
{
    int tamanhoPalavra = palavra.Length;
    int quantidadeOcorrencias = 0;
    string palavraTratada = palavra.ToLower();
    char caractereTratado = char.ToLower(buscarCaractere);

    for (int i = 0; i < tamanhoPalavra; i++)
    {
        if (palavraTratada[i] == caractereTratado)
            quantidadeOcorrencias++;
    }
    return quantidadeOcorrencias;
}

string palavra = "piap";
// string palavra = "Pneumoultramicroscopicossilicovulcanoconiótico";
char buscarCaractere = 'p';

Console.WriteLine($"A quantidade de ocorrências de '{buscarCaractere}' é {OcorrenciaDeUmCaractere(palavra, buscarCaractere)}!");
#endregion