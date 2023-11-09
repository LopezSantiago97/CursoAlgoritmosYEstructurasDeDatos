using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoAlgoritmosYEstructurasDeDatos
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }


        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            // Guardamos el HEAD actual en una variable temporal
            Node<T> tmp = Head;

            // Cambiamos el HEAD al nodo que queremos agregar a la lista
            Head = node;

            // Seteamos la referencia del nuevo HEAD para que apunte al antiguo HEAD
            Head.Next = tmp;

            // Aumentamos el Count para reflejar el cambio
            Count++;

            // Caso especial: Cuando hay un solo elemento en la lista, ese elemento es el HEAD y el TAIL
            if (Count == 1)
                Tail = Head;
        }
    }
}
