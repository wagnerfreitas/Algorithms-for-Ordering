﻿using System;

namespace MetodosDeOrdenecao
{
    public class MetodosDeOrdenacao
    {
        public int[] BubbleSort(int[] vetor)
        {
            for (var i = 1; i < vetor.Length; i++)
            {
                for (var j = 0; j < vetor.Length - i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        var swap = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = swap;
                    }
                }
            }

            return vetor;
        }

        public int[] BubbleSortWithFlag(int[] vetor)
        {
            var i = 1;
            bool flag;

            do
            {
                flag = false;
                for (var j = 0; j < vetor.Length - i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        var swap = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = swap;

                        flag = true;
                    }
                }

                i++;
            } while (flag);

            return vetor;
        }

        public int[] InsertionSort(int[] vetor)
        {
            for (var i = 0; i < vetor.Length; i++)
            {
                var pivo = vetor[i];

                var j = i - 1;

                while (j >= 0 && vetor[j] > pivo)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = pivo;
            }

            return vetor;
        }

        public int[] SelectionSort(int[] vetor)
        {
            for (var i = 0; i < vetor.Length - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[min])
                        min = j;
                }
                var swap = vetor[i];
                vetor[i] = vetor[min];
                vetor[min] = swap;
            }

            return vetor;
        }

        public int[] ShellSort(int[] vetor)
        {
            var hlistas = 1;
            while (hlistas < vetor.Length)
                hlistas = 3 * hlistas + 1;
            do
            {
                hlistas = (int)Math.Floor(hlistas / 3d);
                for (var i = 0; i < vetor.Length; i++)
                {
                    var pivo = vetor[i];
                    var j = i - hlistas;
                    while (j >= 0 && vetor[j] > pivo)
                    {
                        vetor[j + hlistas] = vetor[j];
                        j = j - hlistas;
                    }
                    vetor[j + hlistas] = pivo;
                }
            } while (hlistas > 1);

            return vetor;
        }

        public int[] MergeSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                var meio = (int)Math.Floor((inicio + fim) / 2d);
                if (inicio < meio)
                    MergeSort(vetor, inicio, meio);
                if (meio + 1 < fim)
                    MergeSort(vetor, meio + 1, fim);

                MergeVetores(vetor, inicio, meio, fim);
            }

            return vetor;
        }

        public int[] QuickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                var particao = Particao(vetor, inicio, fim);
                if (inicio < particao - 1)
                    QuickSort(vetor, inicio, particao - 1);
                else if (particao + 1 < fim)
                    QuickSort(vetor, particao + 1, fim);
            }

            return vetor;
        }

        private static int Particao(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[inicio], i = inicio + 1, j = fim;
            while (i <= j)
            {
                while (i <= j && vetor[i] <= pivo)
                    i++;
                while (vetor[j] > pivo)
                    j--;
                if (i <= j)
                {
                    var swap = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = swap;
                    i++; j--;
                }
            }
            var troca = vetor[inicio];
            vetor[inicio] = vetor[j];
            vetor[j] = troca;

            return j;
        }

        private static void MergeVetores(int[] vetor, int inicio, int meio, int fim)
        {
            int i = inicio, j = meio + 1, k = 0;
            var vetorAux = new int[fim - inicio];
            while (i <= meio && j <= fim)
            {
                if (vetor[i] <= vetor[j])
                {
                    vetorAux[k] = vetor[i];
                    i++;
                }
                else
                {
                    vetorAux[k] = vetor[j];
                    j++;
                }
                k++;
            }
            if (i <= meio)
            {
                for (j = meio; j >= i; j--)
                    vetor[fim - meio + j] = vetor[j];
            }
            for (i = 0; i < k; i++)
                vetor[inicio + i] = vetorAux[i];
        }
    }
}