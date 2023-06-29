//inversão de diagonais
int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

System.Console.WriteLine("Matriz normal:");

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

InverterDiagonais(matriz);
Console.WriteLine("");



System.Console.WriteLine("Matriz com diagonais invertidas: ");

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

static void InverterDiagonais(int[,] matriz)
{
    int tamanho = matriz.GetLength(0);

    for (int i = 0; i < tamanho / 2; i++)
    {
        int temp = matriz[i, i];
        matriz[i, i] = matriz[tamanho - i - 1, tamanho - i - 1];
        matriz[tamanho - i - 1, tamanho - i - 1] = temp;

        temp = matriz[i, tamanho - i - 1];
        matriz[i, tamanho - i - 1] = matriz[tamanho - i - 1, i];
        matriz[tamanho - i - 1, i] = temp;
    }
}

Console.WriteLine("==================================================");


int[,] matrizA = {
            {1, 2, 3, 2},
            {4, 2, 3, 2},
            {2, 2, 3, 2},
            {1, 2, 3, 2}
        };

int[,] submatrizB = {
            {2, 3},
            {2, 3}
        };

int quantidade = ContarSubmatriz(matrizA, submatrizB);
Console.WriteLine("A submatriz B ocorre {0} vezes na matriz A.", quantidade);

static int ContarSubmatriz(int[,] matrizA, int[,] submatrizB)
{
    int quantidade = 0;
    int linhasA = matrizA.GetLength(0);
    int colunasA = matrizA.GetLength(1);
    int linhasB = submatrizB.GetLength(0);
    int colunasB = submatrizB.GetLength(1);

    for (int i = 0; i <= linhasA - linhasB; i++)
    {
        for (int j = 0; j <= colunasA - colunasB; j++)
        {
            if (VerificarSubmatriz(matrizA, submatrizB, i, j))
            {
                quantidade++;
            }
        }
    }

    return quantidade;
}

static bool VerificarSubmatriz(int[,] matrizA, int[,] submatrizB, int linhaInicio, int colunaInicio)
{
    int linhasB = submatrizB.GetLength(0);
    int colunasB = submatrizB.GetLength(1);

    for (int i = 0; i < linhasB; i++)
    {
        for (int j = 0; j < colunasB; j++)
        {
            if (matrizA[linhaInicio + i, colunaInicio + j] != submatrizB[i, j])
            {
                return false;
            }
        }
    }

    return true;
}












