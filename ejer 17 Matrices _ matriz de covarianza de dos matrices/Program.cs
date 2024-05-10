// Escribe una función que encuentre la matriz de covarianza de dos matrices.

double[,] matrizA = {
            { 1, 2, 3 },
            { 5, 6, 7 },
            { 9, 0, 1 }
        };
double[,] matrizB = {
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 1, 2, 3 }
        };

double[,] matrizCovarianza = CalcularMatrizCovarianza(matrizA, matrizB);

Console.WriteLine("Matriz de Covarianza:");
for (int i = 0; i < matrizCovarianza.GetLength(0); i++)
{
    for (int j = 0; j < matrizCovarianza.GetLength(1); j++)
    {
        Console.Write(matrizCovarianza[i, j] + " ");
    }
    Console.WriteLine();
}

static double[,] CalcularMatrizCovarianza(double[,] matrizA, double[,] matrizB)
{
    int filas = matrizA.GetLength(0);
    int columnas = matrizA.GetLength(1);
    double[,] matrizCovarianza = new double[filas, columnas];

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            matrizCovarianza[i, j] = CalcularCovarianza(matrizA, matrizB, i, j);
        }
    }

    return matrizCovarianza;
}

static double CalcularCovarianza(double[,] matrizA, double[,] matrizB, int fila, int columna)
{
    double promedioA = 0, promedioB = 0;
    int cantidad = matrizA.GetLength(0);

    // Calcular promedios de la columna `columna`
    for (int i = 0; i < cantidad; i++)
    {
        promedioA += matrizA[i, columna];
        promedioB += matrizB[i, columna];
    }
    promedioA /= cantidad;
    promedioB /= cantidad;

    // Calcular covarianza
    double covarianza = 0;
    for (int i = 0; i < cantidad; i++)
    {
        covarianza += (matrizA[i, columna] - promedioA) * (matrizB[i, columna] - promedioB);
    }
    covarianza /= (cantidad - 1);  // Usando fórmula de covarianza muestral

    return covarianza;
}