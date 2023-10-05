using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeU4
{
    public class NodoArbol
    {
        public int Valor;
        public NodoArbol Izquierda;
        public NodoArbol Derecha;

        public NodoArbol(int valor)
        {
            Valor = valor;
            Izquierda = null;
            Derecha = null;
        }
    }
}
