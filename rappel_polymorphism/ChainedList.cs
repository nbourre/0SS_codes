using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_rappel_polymorphism
{
    /// <summary>
    /// Exemple de polymorphisme paramétrique
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ChainedList<T>
    {
        class Node<T>
        {
            T elem;
            public Node<T> Next { get; set; }

            public Node(T e)
            {
                elem = e;
            }
        }

        private Node<T> head;
        private Node<T> current;

        public ChainedList(T _head)
        {
            head = new Node<T>(_head);
            current = head;
        }

        public void AddToList(T next)
        {
            current.Next = new Node<T>(next);
            current = current.Next;
        }
    }
}
