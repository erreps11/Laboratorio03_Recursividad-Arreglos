// SEscribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.

static void ImprimirLinea(int inicio, int fin)
{
    if (inicio > fin)
    {
        return;  
    }
    Console.Write(inicio + " ");  
    ImprimirLinea(inicio + 1, fin);  
}

static void ImprimirPiramideInvertida(int nivelActual, int nivelesTotales)
{
    if (nivelActual < 1)
    {
        return;  
    }
    Console.Write(new string(' ', (nivelesTotales - nivelActual)));
    ImprimirLinea(1, nivelActual);  
    Console.WriteLine();  
    ImprimirPiramideInvertida(nivelActual - 1, nivelesTotales);  
}

Console.Write("Ingrese el número n para la altura de la pirámide invertida: ");
int n = int.Parse(Console.ReadLine());  
ImprimirPiramideInvertida(n, n);
