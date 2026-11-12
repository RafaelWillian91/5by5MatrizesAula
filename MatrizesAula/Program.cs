using System.Security.Cryptography;


Console.WriteLine("********MATRIZ***********");

int[,] m1 = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        m1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
    }
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(m1[i, j] + " ");
    }

    Console.WriteLine();
}