using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS
{
    public class Stack
    {

       public Node top;
        public Stack()
        {
            top = new Node();

        }


        public bool isEmpty()
        {
            return top == null;
        }


        public void push(int data)
        {
            Node current=new Node(data);
           
            current.Next = top;
            top = current;
            Console.WriteLine(top.Data);


        }

        public int Pop()
        {
            if (isEmpty() ||top==null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public int Peek()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }
    }
}
