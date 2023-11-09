

namespace CursoAlgoritmosYEstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 5 };
            Node second = new Node() { Value = 1 };

            first.Next = second;

            Node third = new Node() { Value = 3 };
            second.Next = third;

            PrintOutLinkedList(first);

            Console.Read();
        }


        private static void PrintOutLinkedList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

    }
}

