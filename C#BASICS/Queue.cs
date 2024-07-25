using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS
{
    public class Queue
    {
        Node front = new Node();
        Node back = new Node();

        public Queue()
        {

            front = back = null;

        }

        public bool IsEmpty()
        {
           return front == null;
        }

        public void Enqueue(int data)
        {
            Node newData = new Node(data);
            if (IsEmpty())
            {
                front = newData;
               
            }

            else
            {
                back.Next = newData;
            }

            back = newData;
            Console.WriteLine(back.Data);

        }

        public int Dequeue()
        {
            if (IsEmpty())
            {

                throw new InvalidOperationException("Queue is empty");
            }

            int poped_data = front.Data;
            front = front.Next;
            if (front == null)
            {
                back = null;
            }

            return poped_data;
        }

        public int Peek()
        {
            return front.Data;
        }
    }
}
