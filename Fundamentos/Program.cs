#region Meu primeiro Programa em C#
//Console.WriteLine("Hello, World!");
#endregion

#region Tipos de Váriaveis
/*

// Texto (string): Armazena sequências de caracteres.
string nome = "Claudio"; // Exemplos: "João", "Maria", "Carlos"

// Inteiro (int): Armazena números inteiros (sem casas decimais).
int numero = 10; // Exemplos: 10, 25, 30, 1000, -50
int idade; // Declaração sem valor inicial
int idade02 = 30; // Declaração com valor inicial

// Ponto flutuante (double): Armazena números reais (com casas decimais).
double peso; // Exemplos: 10.5, 25.0, 30.14, 1000.99, -50.75
double altura = 1.75; // Exemplos: 1.5, 2.0, 3.14, -0.75
double altura02 = 1; // Também pode ser inteiro

// Booleano (bool): Armazena valores verdadeiro ou falso.
bool estudante; // Exemplos: true (verdadeiro), false (falso)
bool estudante02 = true; // Inicializado como verdadeiro
bool estudante03 = false; // Inicializado como falso
bool valor = 2 < 3; // Resultado de uma expressão lógica

// Caractere (char): Armazena um único caractere.
char letra = 'A'; // Exemplos: 'A', 'b', '1', '@'

// Exemplos de uso:
// Console.WriteLine(nome);
// Console.WriteLine(idade02);
// Console.WriteLine(altura);
// Console.WriteLine(estudante03);
// Console.WriteLine(letra);

*/
#endregion

#region Entrada e Saída de Dados

/*
- Para ler dados do usuário, utilizamos o método Console.ReadLine().
- Para imprimir dados na tela, utilizamos o método Console.WriteLine().

Exemplo de Leitura e Impressão de Dados tipos String:
Console.WriteLine("Digite seu nome: "); // Imprime uma mensagem solicitando o nome
string nome = Console.ReadLine(); // Lê o nome digitado pelo usuário
Console.WriteLine("Olá, " + nome + "!"); // Imprime uma saudação personalizada

Exemplo de Leitura e Impressão de Dados tipos Inteiro:
Console.WriteLine("Digite sua idade: "); // Imprime uma mensagem solicitando a idade
int idade = int.Parse(Console.ReadLine()); // Lê a idade digitada e converte
Console.WriteLine("Você tem " + idade + " anos."); // Imprime a idade do usuário

*/
#endregion

#region Operadores Aritméticos


// - Operadores Aritméticos em C#:
//   + : Adição
//   - : Subtração
//   * : Multiplicação
//   / : Divisão
//   % : Módulo (resto da divisão)
//   ++ : Incremento (adiciona 1)
//   -- : Decremento (subtrai 1)

// Exemplos:


#endregion

#region Exercícios Práticos
/*
1. Crie um programa que solicite ao usuário seu nome e idade, 
e depois imprima uma mensagem personalizada.

2. Crie um programa que leia dois números inteiros e imprima a 
soma, subtração, multiplicação e divisão desses números.

3. Crie um programa que leia o raio de um círculo e calcule a 
área (A = π * r²) e o perímetro (P = 2 * π * r).

4. Crie um programa que leia a temperatura em Celsius e 
converta para Fahrenheit (F = C * 9/5 + 32).

*/
#endregion

#region Imprimir nome e idade
/*
string nomeDoUsuario;
int idadeDoUsuario;

Console.Write("Digite seu nome: ");
nomeDoUsuario = Console.ReadLine()!;
Console.Write("Digite sua idade:");
idadeDoUsuario = int.Parse(Console.ReadLine()!);

Console.Write($"Seu nome é {nomeDoUsuario} e sua idade é {idadeDoUsuario} anos.");
*/
#endregion

#region Ler dois números e aplicar operações aritméticas
/*
int numero01 = 10, numero02 = 20;

Console.WriteLine($"A soma entre {numero01} e {numero02} é: {numero01 + numero02}");
Console.WriteLine($"A subtração entre {numero01} e {numero02} é: {numero01 - numero02}");
Console.WriteLine($"A multiplicação entre {numero01} e {numero02} é: {numero01 * numero02}");
Console.WriteLine($"A divisão entre {numero01} e {numero02} é: {numero01 / numero02}");
Console.WriteLine($"O módulo entre {numero01} e {numero02} é: {numero01 % numero02}");
*/
#endregion

#region Q1 - Somar dois números inteiros✅
/*
// tipo tela + nome dela + alguma valor(opcional)
//Criação de variáveis
int primeiro_Numero, segundo_Numero, somarNumeros;

//Entrada
Console.Write("Digite um número inteiro: ");
primeiro_Numero = int.Parse(Console.ReadLine()!);

Console.Write("Digite um segundo número inteiro: ");
segundo_Numero = int.Parse(Console.ReadLine()!);
//Processamento
somarNumeros = primeiro_Numero + segundo_Numero;
//Saida
Console.Write($"A soma dos dois número é {somarNumeros}");
*/
#endregion

#region Q2 - Somar dois números 1º float e 2º double✅
/*
//Declaração de variáveis
float primeiroNumero;
double segundoNumero, soma;
//Entrada
Console.Write("Digite um número float: ");
primeiroNumero = float.Parse(Console.ReadLine()!);
Console.Write("Digite um número double: ");
segundoNumero = double.Parse(Console.ReadLine()!);
//Processamento
soma = primeiroNumero + segundoNumero;
//Saída
Console.WriteLine($"A soma entre {primeiroNumero} e {segundoNumero} é: {soma:F2}");
*/

#endregion

#region Q3 - Ler um char e imprimri qual caractere foi lido✅
/*
char unicoCaractere;
//Entrada
Console.Write("Digite um caractere: ");
//unicoCaractere = char.Parse(Console.ReadLine()!);
unicoCaractere = Console.ReadKey().KeyChar;
//Saída
Console.WriteLine($"\nO caractere digitado foi: {unicoCaractere}");
*/
#endregion

#region Q4 - Ler nome completo do usuário✅
/*
string nomeCompleto;
//Entrada
Console.Write("Digite seu nome completo: ");
nomeCompleto = Console.ReadLine()!;
//Saída
Console.WriteLine($"Seu nome completo é: {nomeCompleto}");
*/
#endregion

#region Q5 - Ler dois números decimais e imprimir a soma com duas casas decimais✅
/*
decimal primeiroNumero, segundoNumero, multiplicacao;

//Entrada
Console.Write("Digite um número decimal: ");
primeiroNumero = decimal.Parse(Console.ReadLine()!);
Console.Write("Digite outro número decimal: ");
segundoNumero = decimal.Parse(Console.ReadLine()!);

//Processamento
multiplicacao = primeiroNumero * segundoNumero;

//Saída
Console.WriteLine($"A multiplicação entre {primeiroNumero} e {segundoNumero} é: {multiplicacao:F2}");
*/
#endregion