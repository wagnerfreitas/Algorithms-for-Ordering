namespace MetodosDeOrdenecao
{
    public class MetodosDeOrdenacao
    {
        public int[] BubbleSort(int[] vetor)
        {
            for (var i = 1; i < vetor.Length - 1; i++)
            {
                for (var j = 0; j < vetor.Length - 1 - i; j++)
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
    }
}