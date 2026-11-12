using System.Security.Cryptography;

           Console.WriteLine("*****************Matriz Original********************");

int[,] matriz = new int[3, 5];

int[,] matrizInvertida = new int[5, 3];

int[,] matrizEspelhada = new int[3, 5];

void PopularMatriz()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }
    }
}

void MatrizInvertida()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrizInvertida[j, i] = matriz[i, j];
        }
    }
}

void MatrizEspelhada()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrizEspelhada[i, j] = matriz[i, 4 - j];
        }
    }
}

void ImprimirMatriz()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(matriz[i, j] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine("***********Matriz invertida**************");

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(matrizInvertida[i, j] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine("************Matriz Espelhada****************");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(matrizEspelhada[i, j] + " ");
        }

        Console.WriteLine();
    }
}

PopularMatriz();
MatrizInvertida();
MatrizEspelhada();
ImprimirMatriz();