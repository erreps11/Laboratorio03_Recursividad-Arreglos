// Escribe una función que encuentre la submatriz de mayor suma de una matriz.

int[,] matriz = {
            {1, 2, -1, -4, -20},
            {-8, -3, 4, 2, 1},
            {3, 8, 10, 1, 3},
            {-4, -1, 1, 7, -6}
        };

var resultado = MaxSumSubmatrix(matriz);
Console.WriteLine("Máxima suma de submatriz: " + resultado);

static int MaxSumSubmatrix(int[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    int maxSum = int.MinValue;

    for (int filaInicio = 0; filaInicio < filas; filaInicio++)
    {
        int[] sumaTemporal = new int[columnas];

        for (int filaFin = filaInicio; filaFin < filas; filaFin++)
        {
            for (int col = 0; col < columnas; col++)
            {
                sumaTemporal[col] += matriz[filaFin, col];
            }

            int maxKadane = Kadane(sumaTemporal);
            maxSum = Math.Max(maxSum, maxKadane);
        }
    }

    return maxSum;
}

// Algoritmo de Kadane para encontrar la máxima suma de un subarray
static int Kadane(int[] arr)
{
    int maxLocal = arr[0];
    int maxGlobal = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        maxLocal = Math.Max(arr[i], maxLocal + arr[i]);
        maxGlobal = Math.Max(maxGlobal, maxLocal);
    }

    return maxGlobal;
}
