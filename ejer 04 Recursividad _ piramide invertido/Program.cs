// SEscribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.

static void ImprimirLinea(int inicio, int fin)
{
    if (inicio > fin)
    {
        return;  // Detiene la impresión cuando se ha llegado al final de la línea
    }
    Console.Write(inicio + " ");  // Imprime el número actual y un espacio
    ImprimirLinea(inicio + 1, fin);  // Recursión para el siguiente número en la misma línea
}

static void ImprimirPiramideInvertida(int nivelActual, int nivelesTotales)
{
    if (nivelActual < 1)
    {
        return;  // Condición de parada de la recursión cuando se alcanza el nivel superior
    }
    // Imprime espacios para centrar los números (opcional)
    Console.Write(new string(' ', (nivelesTotales - nivelActual)));
    ImprimirLinea(1, nivelActual);  // Llama a la función para imprimir los números de la línea
    Console.WriteLine();  // Nueva línea después de terminar la línea actual
    ImprimirPiramideInvertida(nivelActual - 1, nivelesTotales);  // Recursión para la siguiente línea de la pirámide
}

Console.Write("Ingrese el número n para la altura de la pirámide invertida: ");
int n = int.Parse(Console.ReadLine());  // Leer n del usuario
ImprimirPiramideInvertida(n, n);
