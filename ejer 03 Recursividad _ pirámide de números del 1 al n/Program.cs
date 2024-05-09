// Escribe una función recursiva que imprima la pirámide de números del 1 al n.

using System;

static void ImprimirLinea(int inicio, int final)
{
    if (inicio > final)
    {
        return;  
    }
    Console.Write(inicio + " ");  
    ImprimirLinea(inicio + 1, final);  
}

static void ImprimirPiramide(int currentLevel, int totalLevels)
{
    if (currentLevel > totalLevels)
    {
        return;  
    }

    Console.Write(new string(' ', (totalLevels - currentLevel));
    ImprimirLinea(1, currentLevel);  
    Console.WriteLine();  
    ImprimirPiramide(currentLevel + 1, totalLevels); 
}

Console.Write("Ingrese el número n para la altura de la pirámide: ");
int n = int.Parse(Console.ReadLine());  
ImprimirPiramide(1, n);
