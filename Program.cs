using System;

namespace NovoTesouroPerdido
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
           

            Console.WriteLine("Digite os valores da matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int CaminhoA = matriz[0, 0] + matriz[0, 1] + matriz[0, 2] + matriz[1, 2] + matriz[2, 2];
            int CaminhoB = matriz[0, 0] + matriz[0, 1] + matriz[1, 1] + matriz[1, 2] + matriz[2, 2];
            int CaminhoC = matriz[0, 0] + matriz[0, 1] + matriz[1, 1] + matriz[2, 1] + matriz[2, 2];
            int CaminhoD = matriz[0, 0] + matriz[1, 0] + matriz[1, 1] + matriz[1, 2] + matriz[2, 2];
            int CaminhoE = matriz[0, 0] + matriz[1, 0] + matriz[2, 0] + matriz[2, 1] + matriz[2, 2];

            int MaiorSoma = CaminhoA;

            if (CaminhoB > CaminhoA);
            MaiorSoma = CaminhoB;

            if (CaminhoC > CaminhoB);
            MaiorSoma = CaminhoC;

            if (CaminhoD > CaminhoC);
            MaiorSoma = CaminhoD;

            if (CaminhoE > CaminhoD);
            MaiorSoma = CaminhoE;

            Console.WriteLine("O caminho com o maior tesouro é: " + MaiorSoma);


        }
    }
}
