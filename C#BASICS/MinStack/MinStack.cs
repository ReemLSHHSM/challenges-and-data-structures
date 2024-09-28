using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace C_BASICS.MinStack
{
   public class MinStack:Stack
    {
        public int GetMin()
        {
            
            int min=this.top.Data;
            MinStack stack= new MinStack();
            while (this.top.Next!=null)
            {
                if(this.top.Data< min)
                {
                    min=this.top.Data;
                }
               stack.push( this.Pop());

            }
            while (stack.top.Next != null) {
                this.push(stack.Pop());
            }
            return min;
        }
    }
}
