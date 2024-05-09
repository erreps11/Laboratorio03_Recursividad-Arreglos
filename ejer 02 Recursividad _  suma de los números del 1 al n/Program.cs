// Escribe una función recursiva que imprima la suma de los números del 1 al n.

static int SumaRecursiva(int n)
{
    if (n == 1)
    {
        return 1;  
    }
    else
    {
        return n + SumaRecursiva(n - 1); 
    }
}

Console.Write("Ingrese el número n: ");
int n = int.Parse(Console.ReadLine());  
int resultado = SumaRecursiva(n); 
Console.WriteLine($"La suma de los números del 1 al {n} es: {resultado}");  

