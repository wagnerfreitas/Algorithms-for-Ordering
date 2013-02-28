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
    }
}