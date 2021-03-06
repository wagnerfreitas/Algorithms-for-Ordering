﻿using NUnit.Framework;

namespace MetodosDeOrdenecao.Testes
{
    [TestFixture]
    public class DadoMetodosDeOrdenacao
    {
        private int[] vetor;
        private MetodosDeOrdenacao metodos;
        private int[] vetorOrdenado;

        [SetUp]
        public void Cenario()
        {
            vetor = new[] { 2, 1, 7, 6, 7, 15, 3, 8, 4, 5, 9 };
            metodos = new MetodosDeOrdenacao();
            vetorOrdenado = new[] { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 15 };
        }

        [Test]
        public void PossoOrdenarUsandoBubbleSort()
        {
            metodos.BubbleSort(vetor);

            Assert.True(SaoIguais(vetor, vetorOrdenado));
        }

        [Test]
        public void PossoOrdenarUsandoBubbleSortWithFlag()
        {
            metodos.BubbleSortWithFlag(vetor);

            Assert.True(SaoIguais(vetor, vetorOrdenado));
        }

        [Test]
        public void PossoOrdenarUsandoInsertionSort()
        {
            metodos.InsertionSort(vetor);

            Assert.True(SaoIguais(vetor, vetorOrdenado));
        }

        [Test]
        public void PossoOrdenarUsandoSelectionSort()
        {
            metodos.SelectionSort(vetor);

            Assert.True(SaoIguais(vetor, vetorOrdenado));
        }

        [Test]
        public void PossoOrdenarUsandoOShellSort()
        {
            metodos.ShellSort(vetor);

            Assert.True(SaoIguais(vetor, vetorOrdenado));
        }

        [Test]
        public void PossoOrdenarUsandoMergeSort()
        {
            const int inicio = 0;
            var fim = vetor.Length - 1;

            metodos.MergeSort(vetor, inicio, fim);

            Assert.True(SaoIguais(vetor, vetorOrdenado));
        }

        [Test]
        public void PossoOrdenarUsandoOQuickSort()
        {
            const int inicio = 0;
            var fim = vetor.Length - 1;

            metodos.QuickSort(vetor, inicio, fim);

            Assert.True(SaoIguais(vetor, vetorOrdenado));
        }

        private bool SaoIguais(int[] vetor1, int[] vetor2)
        {
            var saoIguais = false;

            for (var i = 0; i < vetor.Length; i++)
            {
                saoIguais = vetor1[i] == vetor2[i];
            }

            return saoIguais;
        }
    }
}