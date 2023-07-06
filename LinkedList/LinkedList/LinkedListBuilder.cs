using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListBuilder<T>
    {
        public Node<T> head;
        public void AddFirst(T data)
        {
            Node<T> node= new Node<T>(data);
            if (head == null)
            {
                head= node;
            }
            else
            {
                node.next = head;
            }
            head= node;
        }
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Insert(int position,T data)
        {
            Node<T> newNode= new Node<T>(data);
            if (position <= 0)
            {
                Console.WriteLine("Position always greater than ZERO");
            }
            if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 2; i < position; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.WriteLine("The Given Position is greater than Linked List Length");
                }
            }

        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
