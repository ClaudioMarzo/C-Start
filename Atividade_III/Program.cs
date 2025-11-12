using System.IO.Compression;

int n;

n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    for (int z = 0; z < n - i - 1; z++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i * 2 + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}