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
       public List<int> stacklist = new List<int>();
        public Stack(int count=0)
        {
            top = new Node();
            Count = count;
        }

        public int Count;

        public bool isEmpty()
        {
            return top == null;
        }


        public void push(int data)
        {
            Node current=new Node(data);
           
            current.Next = top;
            top = current;
           // Count++;
            stacklist.Add(top.Data);
            

            // return Count;

        }

        public int stacklength()
        {
          
            return stacklist.Count();
        }

        public int Pop()
        {
            try
            {


                if (isEmpty())
                {
                    throw new InvalidOperationException("Stack is empty.");
                }

                int data = top.Data;
                top = top.Next;
                return data;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
                throw new InvalidOperationException("Stack is empty."); ;
            }
        }

        public int Peek()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }


        public void display()
        {
            Stack stack = new Stack();
            int data;
            while (this.top.Next != null)
            {
                data = this.Pop();
                stack.push(data);

            }

            while(stack.top.Next != null)
            {
                data=stack.Pop();
                this.push(data);
                Console.WriteLine(data);

            }
        }

    }
}
