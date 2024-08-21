using interfaces_problema_1;
using System;

namespace interfaces_problema_1
{
    
    public class Pila : IColleccion
    {
        private object[] elementos;
        private int contador;

        public object[] Elementos { get; set; }
        public int Contador { get; set; }

        public Pila(int tamaño) 
        {
            Elementos = new object[tamaño];
            Contador = 0;
        }

        public bool EstaVacia()
        {
            return Contador == 0;
        }

        public object Extraer() 
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista no tiene elementos");
            }

            object ultimoElem = Elementos[Elementos.Length - 1];

            //for (int i = 0; i < Elementos.Length - 1; i++)
            //{
            //    Elementos[i] = Elementos[i + 1]; //1,2,3
                                                 
            //}

            Elementos[Elementos.Length - 1] = null;

            Contador--;

            return ultimoElem;
        }

        public bool Añadir(object obj)
        {
            bool fueAñadido = false;

            Elementos[Contador] = obj;

            if (Elementos[Contador] == obj)
            {
                fueAñadido = true;
            }

            Contador++;

            return fueAñadido;
        }

        public object Primero()
        {
            return Elementos[0];
        }
    }
}
