using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS.Trees
{
    public class TNode
    {

        public int Data { get; set; }
        public TNode Right { get; set; }
        public TNode Left { get; set; }

        public TNode(int data) { this.Data = data; }

    }
}
