using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeU4
{
    public class ArbolBinario
    {
        public NodoArbol Raiz;

        public ArbolBinario()
        {
            Raiz = null;
        }

        public void Insertar(int valor)
        {
            Raiz = InsertarRec(Raiz, valor);
        }

        private NodoArbol InsertarRec(NodoArbol raiz, int valor)
        {
            if (raiz == null)
            {
                return new NodoArbol(valor);
            }

            if (valor < raiz.Valor)
            {
                raiz.Izquierda = InsertarRec(raiz.Izquierda, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecha = InsertarRec(raiz.Derecha, valor);
            }

            return raiz;
        }

        public bool Buscar(int valor)
        {
            return BuscarRec(Raiz, valor);
        }

        private bool BuscarRec(NodoArbol raiz, int valor)
        {
            if (raiz == null)
            {
                return false;
            }

            if (raiz.Valor == valor)
            {
                return true;
            }

            if (valor < raiz.Valor)
            {
                return BuscarRec(raiz.Izquierda, valor);
            }
            else
            {
                return BuscarRec(raiz.Derecha, valor);
            }
        }

        public void Eliminar(int valor)
        {
            Raiz = EliminarRec(Raiz, valor);
        }

        private NodoArbol EliminarRec(NodoArbol raiz, int valor)
        {
            if (raiz == null)
            {
                return raiz;
            }

            if (valor < raiz.Valor)
            {
                raiz.Izquierda = EliminarRec(raiz.Izquierda, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecha = EliminarRec(raiz.Derecha, valor);
            }
            else
            {
                if (raiz.Izquierda == null)
                {
                    return raiz.Derecha;
                }
                else if (raiz.Derecha == null)
                {
                    return raiz.Izquierda;
                }

                raiz.Valor = MinimoValor(raiz.Derecha);
                raiz.Derecha = EliminarRec(raiz.Derecha, raiz.Valor);
            }

            return raiz;
        }

        private int MinimoValor(NodoArbol nodo)
        {
            int minValor = nodo.Valor;
            while (nodo.Izquierda != null)
            {
                minValor = nodo.Izquierda.Valor;
                nodo = nodo.Izquierda;
            }
            return minValor;
        }
    }
}
