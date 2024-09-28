using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_BASICS.Trees
{
    public class Binary_Tree
    {

        public void PreOrder(TNode node)//root,left,right
        {
            if (node == null) return;

            Console.Write(node.Data);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
        public void PostOrder(TNode node) {//left,right,root

            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Data);
        }

        public void InOrder(TNode node)//left,root,right
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.WriteLine(node.Data);
            InOrder(node.Right);
            
        }

        public void print(TNode node)
        {
            if (node == null) return;

            Console.WriteLine(node.Data);

            print(node.Left);
            print(node.Right);
        }

       
    }
}
