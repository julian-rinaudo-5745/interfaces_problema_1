using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_problema_1
{
    public interface IColleccion 
    {
        public bool EstaVacia();

        public object Extraer();

        public object Primero();

        public bool Añadir(object obj);
    }
}
