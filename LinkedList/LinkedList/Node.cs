using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public Node<T> next;
        public T data;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
