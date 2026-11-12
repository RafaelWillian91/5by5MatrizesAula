using System.Security.Cryptography;

Console.WriteLine("*****************Matriz Original********************");



int[,] matriz = new int[3,5];
int[,] matrizInvertida = new int [5,3]; 
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
    
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrizInvertida[i, j] = matriz[j, i];
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

    Console.WriteLine("*****************Matriz Invertida********************");

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(matrizInvertida[i, j] + " ");
        }

        Console.WriteLine();
    }
}


PopularMatriz();
MatrizInvertida();
ImprimirMatriz();