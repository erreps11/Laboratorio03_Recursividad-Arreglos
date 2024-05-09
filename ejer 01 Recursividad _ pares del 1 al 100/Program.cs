// Escribe una función recursiva que imprima los números pares del 1 al 100.

static void ImprimirPares(int n, int limite)
{
    if (n > limite)
    {
        return;  
    }

    Console.WriteLine("  " + n);  
    ImprimirPares(n + 2, limite);  
}


int inicio = 2;  
int limite = 100;  
ImprimirPares(inicio, limite);




