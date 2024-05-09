// Multiplica una matriz por un número.

int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

// Definir el escalar
int escalar = 2;

// Multiplicar la matriz por el escalar
int[,] matrizResultante = MultiplicarMatrizPorEscalar(matriz, escalar);

// Imprimir la matriz resultante
Console.WriteLine("Matriz resultante después de multiplicar por " + escalar + ":");
for (int i = 0; i < matrizResultante.GetLength(0); i++)
{
    for (int j = 0; j < matrizResultante.GetLength(1); j++)
    {
        Console.Write(matrizResultante[i, j] + "\t");
    }
    Console.WriteLine();
}

static int[,] MultiplicarMatrizPorEscalar(int[,] matriz, int escalar)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    int[,] matrizResultante = new int[filas, columnas];

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            matrizResultante[i, j] = matriz[i, j] * escalar;
        }
    }

    return matrizResultante;
}