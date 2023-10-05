using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeU4
{
    internal class Program
    {
        static void RecorridoInOrden(NodoArbol raiz)
        {
            if (raiz != null)
            {
                RecorridoInOrden(raiz.Izquierda);
                Console.Write(raiz.Valor + " ");
                RecorridoInOrden(raiz.Derecha);
                
            }
        }
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            arbol.Insertar(50);
            arbol.Insertar(30);
            arbol.Insertar(70);
            arbol.Insertar(20);
            arbol.Insertar(40);
            arbol.Insertar(60);
            arbol.Insertar(80);

            Console.WriteLine("Recorrido InOrden del Árbol:");
            RecorridoInOrden(arbol.Raiz);
            Console.WriteLine();

            int numeroBuscado = 40;
            if (arbol.Buscar(numeroBuscado))
            {
                Console.WriteLine($"{numeroBuscado} se encuentra en el árbol.");
            }
            else
            {
                Console.WriteLine($"{numeroBuscado} no se encuentra en el árbol.");
            }

            int numeroEliminar = 30;
            arbol.Eliminar(numeroEliminar);
            Console.WriteLine($"Elemento {numeroEliminar} eliminado.");

            Console.WriteLine("Recorrido InOrden después de la eliminación:");
            RecorridoInOrden(arbol.Raiz);
            Console.WriteLine();
            Console.ReadKey();
        }
    
    }
}
