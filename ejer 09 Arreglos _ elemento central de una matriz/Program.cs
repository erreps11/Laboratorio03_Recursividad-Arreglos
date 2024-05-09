// Accede al elemento central de una matriz.

int[,] matrizImpar = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

// Acceder al elemento central de una matriz 3x3
int centroImpar = matrizImpar[1, 1]; // Indices (1,1)
Console.WriteLine($"Elemento central de la matriz impar: {centroImpar}");

// Matriz con dimensión par (4x4)
int[,] matrizPar = new int[,]
{
            { 10, 20, 30, 40 },
            { 50, 60, 70, 80 },
            { 90, 100, 110, 120 },
            { 130, 140, 150, 160 }
};

// Acceder al elemento central de una matriz 4x4
// Puedes elegir uno o más elementos "centrales", aquí elegimos el elemento en (1,1)
int centroPar = matrizPar[1, 1];
Console.WriteLine($"Elemento central de la matriz par (una opción): {centroPar}");

// También podríamos considerar (1,2), (2,1) y (2,2) como centrales
Console.WriteLine("Elementos centrales de la matriz par:");
Console.WriteLine($"{matrizPar[1, 1]} {matrizPar[1, 2]}");
Console.WriteLine($"{matrizPar[2, 1]} {matrizPar[2, 2]}");