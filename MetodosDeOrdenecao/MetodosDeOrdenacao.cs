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
    }
}