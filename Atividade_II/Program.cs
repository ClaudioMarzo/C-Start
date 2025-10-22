// ATIVIDADE II

#region Questão 1 - Perímetro e área de triângulo (fórmula de Heron)
// Console.WriteLine("Questão 1");
// Console.Write("Digite o lado a: ");
// double a = double.Parse(Console.ReadLine());
// Console.Write("Digite o lado b: ");
// double b = double.Parse(Console.ReadLine());
// Console.Write("Digite o lado c: ");
// double c = double.Parse(Console.ReadLine());

// double p = (a + b + c) / 2;
// double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
// double perimetro = a + b + c;

// Console.WriteLine($"Perímetro: {perimetro:F3}");
// Console.WriteLine($"Área: {area:F3}");
// Console.WriteLine();
#endregion

#region Questão 2 - Salário bruto
// Console.WriteLine("Questão 2");
// Console.Write("Horas trabalhadas (float): ");
// float horas = float.Parse(Console.ReadLine());
// Console.Write("Valor da hora (decimal): ");
// decimal valorHora = decimal.Parse(Console.ReadLine());

// decimal salario = (decimal)horas * valorHora;
// Console.WriteLine($"Salário bruto: {salario:F2}");
// Console.WriteLine();
#endregion

#region Questão 3 - Distância percorrida
// Console.WriteLine("Questão 3");
// Console.Write("Velocidade (km/h - double): ");
// double velocidade = double.Parse(Console.ReadLine());
// Console.Write("Tempo (horas - double): ");
// double tempo = double.Parse(Console.ReadLine());

// double distancia = velocidade * tempo;
// Console.WriteLine($"Distância percorrida: {distancia}");
// Console.WriteLine();
#endregion

#region Questão 4 - Volume da esfera
// Console.WriteLine("Questão 4");
// Console.Write("Raio da esfera (int): ");
// int raio = int.Parse(Console.ReadLine());

// double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
// Console.WriteLine($"Volume da esfera: {volume:F4}");
// Console.WriteLine();
#endregion

#region Questão 5 - Conversão Fahrenheit para Celsius
// Console.WriteLine("Questão 5");
// Console.Write("Temperatura em Fahrenheit (float): ");
// float fahrenheit = float.Parse(Console.ReadLine());

// float celsius = (fahrenheit - 32) * 5 / 9;
// Console.WriteLine($"Temperatura em Celsius: {celsius:F2}");
// Console.WriteLine();
#endregion

#region Questão 6 - Média ponderada
// Console.WriteLine("Questão 6");
// Console.Write("Nota 1 (double): ");
// double n1 = double.Parse(Console.ReadLine());
// Console.Write("Nota 2 (double): ");
// double n2 = double.Parse(Console.ReadLine());
// Console.Write("Nota 3 (double): ");
// double n3 = double.Parse(Console.ReadLine());
// Console.Write("Nota 4 (double): ");
// double n4 = double.Parse(Console.ReadLine());

// double media = (n1 * 1 + n2 * 2 + n3 * 3 + n4 * 4) / 10;
// Console.WriteLine($"Média ponderada: {media:F2}");
// Console.WriteLine();
#endregion

#region Questão 7 - Imposto sobre valor decimal
// Console.WriteLine("Questão 7");
// Console.Write("Valor em reais (decimal): ");
// decimal valor = decimal.Parse(Console.ReadLine());

// decimal imposto = valor * 0.07m;
// decimal valorFinal = valor + imposto;
// Console.WriteLine($"Imposto (7%): {imposto:F2}");
// Console.WriteLine($"Valor final: {valorFinal:F2}");
// Console.WriteLine();
#endregion

#region Questão 8 - Conversão de segundos para h/m/s
Console.WriteLine("Questão 8");
Console.Write("Segundos (int): ");
int segundos = int.Parse(Console.ReadLine()!);

int horasConv = segundos / 3600;
int minutosConv = segundos % 3600 / 60;
int segundosRestantes = segundos % 60;

Console.WriteLine($"Horas: {horasConv}, Minutos: {minutosConv}, Segundos: {segundosRestantes}");
Console.WriteLine();
#endregion

#region Questão 9 - Hipotenusa
// Console.WriteLine("Questão 9");
// Console.Write("Lado a (double): ");
// double ladoA = double.Parse(Console.ReadLine());
// Console.Write("Lado b (double): ");
// double ladoB = double.Parse(Console.ReadLine());

// double hipotenusa = Math.Sqrt(ladoA * ladoA + ladoB * ladoB);
// Console.WriteLine($"Hipotenusa: {hipotenusa:F3}");
// Console.WriteLine();
#endregion

#region Questão 10 - Velocidade média km/h
// Console.WriteLine("Questão 10");
// Console.Write("Distância (metros - float): ");
// float distanciaMetros = float.Parse(Console.ReadLine());
// Console.Write("Tempo (segundos - float): ");
// float tempoSegundos = float.Parse(Console.ReadLine());

// double velocidadeMedia = (distanciaMetros / 1000) / (tempoSegundos / 3600);
// Console.WriteLine($"Velocidade média: {velocidadeMedia:F2} km/h");
// Console.WriteLine();
#endregion