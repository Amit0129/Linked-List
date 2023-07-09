using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedListBuilder<T> where T : IComparable
    {
        public Node<T> head;
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
            }
            head = node;
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
        public void Insert(int position, T data)
        {
            Node<T> newNode = new Node<T>(data);
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
        public void Remove_First()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                head = head.next;
            }
        }
        public void Remove_Last()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            Node<T> temp = head;
            if (temp.next == null)
            {
                head = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
            Console.WriteLine("Last Element remove sucessfully");
        }
        public void SearchValue(T value)
        {
            Node<T> temp = this.head;
            int found = 0;
            int count = 0;
            while (temp != null)
            {
                count++;
                if (temp.data.CompareTo(value) == 0)
                {
                    found++;
                    break;
                }
                temp = temp.next;
            }
            if (found == 1)
            {
                Console.WriteLine($"The position of value {value} is {count}");
            }
            else
            {
                Console.WriteLine("The value {0} not present in linked list.", value);
            }

        }
        public void InsertDataAfterAData(T eData,T newdata)
        {
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            Node<T> temp = head;
            int found = 0;
            int count = 0;
            while (temp != null)
            {
                count++;
                if (temp.data.CompareTo(eData)==0)
                {
                    found++;
                    break;
                }
                temp = temp.next;
            }
            Insert(count+1, newdata);
        }
        public void Remove(T value)
        {
            int position = SearchAValue(value);
            if (position == 1)
            {
                this.head = this.head.next;
            }
            else
            {
                Node<T> temp = this.head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    temp.next = temp.next.next;
                }
            }
            Console.WriteLine("Element Removed");
        }
        public void Size()
        {
            int count = 0;
            Node<T> temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size of Linked List is {0}",count);
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
        public int SearchAValue(T value)
        {
            Node<T> temp = this.head;
            int position = 0;
            int i = 0;
            while (temp != null)
            {
                i++;
                if (temp.data.CompareTo(value) == 0)
                {
                    position++;
                    break;
                }
                temp = temp.next;
            }
            return i;
        }
    }
}
