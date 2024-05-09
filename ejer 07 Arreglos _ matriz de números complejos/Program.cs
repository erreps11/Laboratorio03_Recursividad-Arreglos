// Crea una matriz de números complejos.

using System.Numerics;

Complex[,] matrizCompleja = new Complex[2, 2];

// Inicializar la matriz con números complejos
matrizCompleja[0, 0] = new Complex(1.0, 2.0);  // Complejo 1.0 + 2.0i
matrizCompleja[0, 1] = new Complex(3.0, 4.0);  // Complejo 3.0 + 4.0i
matrizCompleja[1, 0] = new Complex(5.0, 6.0);  // Complejo 5.0 + 6.0i
matrizCompleja[1, 1] = new Complex(7.0, 8.0);  // Complejo 7.0 + 8.0i

// Imprimir la matriz de números complejos
Console.WriteLine("Matriz de Números Complejos:");
for (int i = 0; i < matrizCompleja.GetLength(0); i++)
{
    for (int j = 0; j < matrizCompleja.GetLength(1); j++)
    {
        Console.Write($"{matrizCompleja[i, j]} \t");
    }
    Console.WriteLine(); 
}