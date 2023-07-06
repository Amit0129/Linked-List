﻿using System;
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