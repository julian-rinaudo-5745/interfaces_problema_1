using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_problema_1
{
    public class Cola: IColleccion
    {
        private List<object> elementos;

        public List<object> Elementos { get; set; }

        public Cola() 
        {
            Elementos = new List<object>();
        }

        public bool EstaVacia()
        {
            return Elementos.Count == 0;
        }

        public object Extraer()
        {
            object elemGuardado = Elementos.First();

            Elementos.RemoveAt(0);

            return elemGuardado;
        }

        public object Primero()
        {
            return Elementos.First();
        }

        public bool Añadir(object obj)
        {
            bool fueAñadido = false;

            Elementos.Add(obj); 

            if(Elementos.IndexOf(obj) != -1)
            {
                fueAñadido = true; 
            }

            return fueAñadido;
        }
    }
}
