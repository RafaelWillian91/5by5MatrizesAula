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
        for (int j = 0; j < qtdLinhas; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }
    }
}

void ImprimirMatriz()
{
    for (int i = 0; i < qtdLinhas; i++)
    {
        for (int j = 0; j < qtdLinhas; j++)
        {
            Console.Write(m1[i, j] + " ");
        }

        Console.WriteLine();
    }
}

PopularMatriz();
ImprimirMatriz();