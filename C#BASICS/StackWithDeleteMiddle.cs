using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS
{
    public class StackWithDeleteMiddle : StackWithReverse
    {
        Stack stack = new Stack();


        public void DeleteMiddle()
        {
            int len = this.stacklength();
            try
            {


                if (isEmpty())
                {
                    throw new InvalidOperationException("Stack is empty.");
                }
                else
                {
                   

                    if (len % 2 == 0) {
                        int count = 0;
                        while ( count <= this.stacklength()  / 2)
                        {
                            stack.push(this.Pop());
                            count++;

                        }
                    }
                    else if(len % 2 != 0)
                    {
                         int count = 0;
                       while( count <= (this.stacklength()-1) / 2)
                        {
                            stack.push(this.Pop());
                            count++;

                        }
                    }
                    


                    stack.Pop();
                    while (stack.top.Next != null)
                    {
                        this.push(stack.Pop());
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
               
            }
        }
        }
    }

