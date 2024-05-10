// matriz de números aleatorios de tamaño 100x100.

int filas = 10;
int columnas = 10;

Random random = new Random();

int[,] matriz = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        matriz[i, j] = random.Next(0, 100); // Genera números de 0 a 99
    }
}

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

