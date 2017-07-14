using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLoja.Control
{
    public class QuickSort<T>
        where T : IComparable<T>
    {
        public void sort(List<T> lista, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = particionar(lista, inicio, fim);
                sort(lista, inicio, meio -1);
                sort(lista, meio + 1, fim);
            }
        }

        private int particionar(List<T> lista, int inicio, int fim)
        {
            T pivo = lista.ElementAt(inicio);
            int esquerda = inicio + 1;
            int direita = fim;

            while(esquerda <= direita)
            {
                if (lista[esquerda].CompareTo(pivo) <= 0)
                    esquerda += 1;
                else if (lista[direita].CompareTo(pivo) > 0)
                    direita -= 1;
                else
                {
                    T aux = default(T);
                    aux = lista.ElementAt(esquerda);
                    lista[esquerda] = lista[direita];
                    lista[direita] = aux;
                    esquerda++;
                    direita--;
                }


            }

            lista[inicio] = lista[direita];
            lista[direita] = pivo;

            return direita;
        }
    }
}
