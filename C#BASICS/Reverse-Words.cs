using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS
{
    public class Reverse_Words
    {
      
        public static string ReverseWords(string sent) {

           var arr= sent.Split(' ');
            string rev = "";
            for(int i=arr.Length-1;i>=0;i--) {
                rev += arr[i];
                if (i > 0)
                {
                    rev += " ";
                }
               
            }
            sent = rev;
            return sent;
        }
    }
}
