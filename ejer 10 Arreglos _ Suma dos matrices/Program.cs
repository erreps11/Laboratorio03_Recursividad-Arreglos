// Suma dos matrices de diferentes tamaños.

int[,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

int[,] matrizB = {
            { 10, 20 }
        };

int maxFilas = Math.Max(matrizA.GetLength(0), matrizB.GetLength(0));
int maxColumnas = Math.Max(matrizA.GetLength(1), matrizB.GetLength(1));

int[,] sumaMatrices = new int[maxFilas, maxColumnas];

for (int i = 0; i < maxFilas; i++)
{
    for (int j = 0; j < maxColumnas; j++)
    {
        int elementoA = i < matrizA.GetLength(0) && j < matrizA.GetLength(1) ? matrizA[i, j] : 0;
        int elementoB = i < matrizB.GetLength(0) && j < matrizB.GetLength(1) ? matrizB[i, j] : 0;
        sumaMatrices[i, j] = elementoA + elementoB;
    }
}

Console.WriteLine("Suma de las matrices:");
for (int i = 0; i < sumaMatrices.GetLength(0); i++)
{
    for (int j = 0; j < sumaMatrices.GetLength(1); j++)
    {
        Console.Write(sumaMatrices[i, j] + " ");
    }
    Console.WriteLine();
}
