// Escribe una función que encuentre el elemento máximo de una matriz.

int[,] matriz = {
            {1, 3, 5},
            {7, 0, 2},
            {9, 6, 4}
        };

// Encontrar el máximo utilizando la función definida
int maximo = EncontrarMaximo(matriz);

Console.WriteLine("El elemento máximo de la matriz es: " + maximo);

static int EncontrarMaximo(int[,] matriz)
{
    return matriz.Cast<int>().Max();
}
