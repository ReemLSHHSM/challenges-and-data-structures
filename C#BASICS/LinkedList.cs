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
        public string PrintList()
        {
            string eliments = "";
            Node node = Head;
            if (Head != null) {

                while (node != null)
                {

                    Console.WriteLine(node.Data);
                    eliments += node.Data+" ";
                    node = node.Next;
                }
            }
            else
            {
                Console.WriteLine("Linked List is empty");
            }
            return eliments;
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

        public string RemoveDuplicate()
        {
            Node current = Head;

            try
            {


                while (current != null)
                {
                    Node pointer = current;
                    while (pointer.Next != null)
                    {

                        if (pointer.Next.Data == current.Data)
                        {
                            pointer.Next = pointer.Next.Next;
                        }
                        else
                        {
                            pointer = pointer.Next;
                        }

                    }
                    current = current.Next;
                }

              string eliments= PrintList();
                return eliments;

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("A null reference exception occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            return "";
        }

        public void MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            if (list1.Head == null)
            {
                list1.Head = list2.Head;
                return;
            }
            else if (list2.Head == null)
            {
                return;
            }

            Node dummy = new Node(0);
            Node current = dummy;

            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data < current2.Data)
                {
                    current.Next = current1;
                    current1 = current1.Next;
                }
                else
                {
                    current.Next = current2;
                    current2 = current2.Next;
                }
                current = current.Next;
            }

            if (current1 != null)
            {
                current.Next = current1;
            }
            else
            {
                current.Next = current2;
            }

            list1.Head = dummy.Next;

            PrintList();
        }



    }
}