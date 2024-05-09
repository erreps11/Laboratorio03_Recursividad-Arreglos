// Escribe una función recursiva que imprima la tabla de multiplicar del n.

static void ImprimirTablaMultiplicar(int n, int multiplicador)
{
    if (multiplicador > 10)
    {
        return; 
    }

    Console.WriteLine($"   {n} x {multiplicador} = {n * multiplicador}");  
    ImprimirTablaMultiplicar(n, multiplicador + 1);  
}

Console.Write("Ingrese el número n para imprimir su tabla de multiplicar: ");
int n = int.Parse(Console.ReadLine());  
ImprimirTablaMultiplicar(n, 1);