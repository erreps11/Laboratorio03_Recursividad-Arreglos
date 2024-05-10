// Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.

int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

int filas = matriz.GetLength(0);
int columnas = matriz.GetLength(1);

//  la media
double media = matriz.Cast<int>().Average();

//  la mediana
int[] elementosOrdenados = matriz.Cast<int>().OrderBy(x => x).ToArray();
double mediana;
if (elementosOrdenados.Length % 2 == 0)
{
    mediana = (elementosOrdenados[(elementosOrdenados.Length / 2) - 1] + elementosOrdenados[elementosOrdenados.Length / 2]) / 2.0;
}
else
{
    mediana = elementosOrdenados[elementosOrdenados.Length / 2];
}

//  la desviación estándar
double sumaCuadradosDiferencias = 0;
foreach (int elemento in elementosOrdenados)
{
    sumaCuadradosDiferencias += Math.Pow(elemento - media, 2);
}
double desviacionEstandar = Math.Sqrt(sumaCuadradosDiferencias / elementosOrdenados.Length);

Console.WriteLine("Media: " + media);
Console.WriteLine("Mediana: " + mediana);
Console.WriteLine("Desviación Estándar: " + desviacionEstandar);