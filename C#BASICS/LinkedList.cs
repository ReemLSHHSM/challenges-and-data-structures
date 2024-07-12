using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS
{
    public class LinkedList
    {

        public Node Head ;

        public LinkedList(Node head)
        {
            this.Head = head;
        }

        //Adding node at the beginning of the list
        public void addtoHead(Node node)
        {
            node.Next = Head;
            Head = node;
        }


        //Deleting a certain data
        public void Remove(int data)
        {
            if (Head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }

        
            if (Head.Data == data)
            {
                Head = Head.Next; 
                return;
            }

          
            Node current = Head;
            Node previous = null;

            while (current != null && current.Data != data)
            {
                previous = current;
                current = current.Next;
            }

         
            if (current == null)
            {
                Console.WriteLine("Node with data not found.", data);
                return;
            }

          
            previous.Next = current.Next;
        }


        //Display all elemints
        public void Display()
        {
            Node node = Head;
            if (Head != null) {

                while (node != null)
                {

                    Console.WriteLine(node.Data);
                    node = node.Next;
                }
            }
            else
            {
                Console.WriteLine("Linked List is empty");
            }
        }
        public bool Includes(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
    }
}