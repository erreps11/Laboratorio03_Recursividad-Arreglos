//  Crea una matriz de números reales. 

double[,] matriz = new double[,]
        {
            { 1.1, 2.2, 3.3 },
            { 4.4, 5.5, 6.6 },
            { 7.7, 8.8, 9.9 }
        };

// Mostrar las dimensiones de la matriz
Console.WriteLine($"Dimensiones de la matriz: {matriz.GetLength(0)}x{matriz.GetLength(1)}");

// Imprimir todos los elementos de la matriz
for (int fila = 0; fila < matriz.GetLength(0); fila++)
{
    for (int columna = 0; columna < matriz.GetLength(1); columna++)
    {
        Console.Write(matriz[fila, columna] + " ");
    }
    Console.WriteLine();  // Salto de línea después de cada fila
}
