// Crea una matriz de matrices.

int[,][,] matrizDeMatrices = new int[2, 2][,];

// Inicializar cada matriz en la matriz de matrices
matrizDeMatrices[0, 0] = new int[,] { { 1, 2 }, { 3, 4 } };
matrizDeMatrices[0, 1] = new int[,] { { 5, 6 }, { 7, 8 } };
matrizDeMatrices[1, 0] = new int[,] { { 9, 10 }, { 11, 12 } };
matrizDeMatrices[1, 1] = new int[,] { { 13, 14 }, { 15, 16 } };

// Imprimir la matriz de matrices
Console.WriteLine("Matriz de Matrices:");
for (int i = 0; i < matrizDeMatrices.GetLength(0); i++)
{
    for (int j = 0; j < matrizDeMatrices.GetLength(1); j++)
    {
        Console.WriteLine($"Elemento [{i}, {j}]:");
        ImprimirMatriz(matrizDeMatrices[i, j]);
        Console.WriteLine();
    }
}

static void ImprimirMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($"{matriz[i, j]} \t");
        }
        Console.WriteLine();
    }
}
