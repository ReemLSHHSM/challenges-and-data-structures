﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BASICS
{
    public class Node
    {
        public int Data {  get; set; }
        public Node Next { get; set; }

        

        public Node() {
           
            this.Next = null;
        }

        public Node(int data) { 
        
        this.Data = data;
            this.Next = null;
        }
    }
}
