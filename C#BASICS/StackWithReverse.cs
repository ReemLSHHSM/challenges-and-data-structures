using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS
{
    public class StackWithReverse:Stack
    {
        Queue queue=new Queue();
          public int count = 0;
        public bool ReverseStack()
        {
            try
            {


                if (top.Next != null)
                {
                    while (top.Next != null)
                    {
                        int data = this.Pop();

                        queue.Enqueue(data);
                    }

                    while (!queue.IsEmpty())
                    {
                        int data = queue.Dequeue();
                        this.push(data);
                    }
                }
            }

            catch (Exception ex)
            {
              
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
                throw new InvalidOperationException("Stack is empty."); ;
            }

            bool result=this.isEmpty();
            return result;
        }
    }
}
