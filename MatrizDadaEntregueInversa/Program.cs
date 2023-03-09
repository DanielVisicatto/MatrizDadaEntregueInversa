int[,] matrizOriginal = new int[3, 3];
int[,] matrizInvertida = new int[3, 3];

Popular();

Imprimir(matrizOriginal);
Inverter(matrizOriginal);
Imprimir(matrizInvertida);

void Popular()
{
    Console.WriteLine("Digite os valores para a posição separados por espaço:");
    for (int i = 0; i < 3; i++)
    {        
        string[] entradas = Console.ReadLine().Split(' ');

        matrizOriginal[i, 0] = int.Parse(entradas[0]);
        matrizOriginal[i, 1] = int.Parse(entradas[1]);
        matrizOriginal[i, 2] = int.Parse(entradas[2]);
    }
}
int[,] Inverter(int[,] matriz)
{
    //for (int l = 0; l < matrizOriginal.GetLength(0); l++)
    //{
    //    for (int c = 0; c < matrizOriginal.GetLength(1); c++)
    //    {
    //        matriz[l, c] = matrizOriginal[matrizOriginal.GetLength(0)
    //            - l - 1, matrizOriginal.GetLength(1) - c - 1];
    //    }
    //}
    for ( int l = 0, l2 = matriz.GetLength(0) -1; l < matriz.GetLength(0); l++, l2--)
    {
        for (int c = 0, c2 = matriz.GetLength(1) -1; c < matriz.GetLength(1); c++, c2--)
        {
            matrizInvertida[l2, c2] = matriz[l, c]; 
        }
    }
    return matrizInvertida;
}
void Imprimir(int[,] matriz)
{
    Console.WriteLine();
    for (int linha = 0; linha <3; linha++)
    {
        for (int coluna = 0; coluna < 3; coluna++)
        {
            Console.Write("{0} ", matriz[linha, coluna]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}