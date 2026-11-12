using System.Security.Cryptography;

Console.WriteLine("*****************Matriz********************");

Console.Write("Quantidade de linhas: ");
int qtdLinhas = int.Parse(Console.ReadLine());

Console.Write("Quantidade de colunas: ");
int qtdColunas = int.Parse(Console.ReadLine());

int[,] m1 = new int[qtdLinhas, qtdColunas];

void PopularMatriz()
{
    for (int i = 0; i < qtdLinhas; i++)
    {
        for (int j = 0; j < qtdColunas; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }
    }
}

void ImprimirMatriz()
{
    Console.WriteLine("Matriz original:");

    for (int i = 0; i < qtdLinhas; i++)
    {
        for (int j = 0; j < qtdColunas; j++)
        {
            Console.Write(m1[i, j] + " ");
        }

        Console.WriteLine();
    }
}

void ImprimirMatrizInversa()
{
    Console.WriteLine("Matriz inversa:");

    for (int i = qtdLinhas - 1; i >= 0; i--)
    {
        for (int j = qtdColunas - 1; j >= 0; j--)
        {
            Console.Write(m1[i, j] + " ");
        }

        Console.WriteLine();
    }
}

PopularMatriz();
ImprimirMatriz();
ImprimirMatrizInversa();