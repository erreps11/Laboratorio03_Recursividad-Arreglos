// Calcula la media de los elementos de una matriz. 

int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

double media = CalcularMedia(matriz);
Console.WriteLine("La media de los elementos de la matriz es: " + media);

static double CalcularMedia(int[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    int totalElementos = filas * columnas;
    int suma = 0;

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            suma += matriz[i, j];
        }
    }

    return (double)suma / totalElementos;
}