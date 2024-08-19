﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_BASICS.Trees
{
    public class BinarySearchTree : Binary_Tree
    {
        public TNode Root;

        public BinarySearchTree(int data)
        {
            Root = new TNode(data);
        }


        public void Add(int data)
        {
            Add(data, Root);
        }

        public void Add(int data, TNode node)
        {

            if (data < node.Data)
            {
                if (node.Left != null)
                {
                    Add(data, node.Left);
                }
                else
                {
                    node.Left = new TNode(data);
                }
            }
            else
            {
                if (node.Right != null)
                {
                    Add(data, node.Right);
                }
                else
                {
                    node.Right = new TNode(data);
                }
            }

        }

        public bool Contains(int data)
        {
            TNode node = Root;
            bool exist = false;
            //while (node != null)
            //{

            //    if (node.Data == data)
            //    {

            //        exist = true;
            //        break;
            //    }
            //    else if (node.Data < data)
            //    {
            //        node = node.Right;
            //    }
            //    else
            //    {
            //        node = node.Left;
            //    }
            //}
            exist = Contains(data, Root);
            return exist;

        }
        bool exist = false;
        public bool Contains(int data, TNode node)
        {


            if (node != null && exist != true)
            {
                if (node.Data == data)
                {
                    exist = true;

                }

                else if (node.Data > data)
                {

                    Contains(data, node.Left);
                }

                else
                {
                    Contains(data, node.Right);
                }





            }
            return exist;
        }

        public void Remove(int data)
        {
            Root = Remove(Root, data);
        }

        private TNode Remove(TNode root, int data)
        {
            if (root == null)
            {
                return null;
            }

            if (data < root.Data)
            {
                root.Left = Remove(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = Remove(root.Right, data);
            }
            else
            {
                if (root.Left == null)
                {

                    return root.Right;
                }
                else if (root.Right == null)
                {

                    return root.Left;
                }

                TNode successor = GetMinValueNode(root.Right);

                root.Data = successor.Data;

                root.Right = Remove(root.Right, successor.Data);
            }

            return root;
        }

        private TNode GetMinValueNode(TNode node)
        {
            TNode current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public void Mirror(TNode node)
        {
            if (node == null)
            {
                return;
            }
            Mirror(node.Left);
            Mirror(node.Right);

            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        public void Mirror()
        {
            Mirror(Root);
        }


        int second_max = 0;
        public int? SecondMaximumValueLeft(TNode node)
        {
            if (node.Left == null)
                return null;

            if (node.Left.Right == null)
            {
                return node.Left.Data;
            }

            return SecondMaximumValueLeft(node.Left);
        }




        public int? SecondMaximumValueRight(TNode node)
        {
            if (node.Right == null)
                return null;

            if (node.Right.Left == null && node.Right.Right == null)
            {
                return node.Right.Data;
            }

  
            if (node.Right.Left != null)
            {
                TNode temp = node.Right.Left;
                while (temp.Right != null)
                {
                    temp = temp.Right;
                }
                return temp.Data;
            }
            return SecondMaximumValueRight(node.Right);
        }



        public int? SecondMaximumValue()
        {
            if (Root == null)
                return null;

            if (Root.Right != null)
            {
                return SecondMaximumValueRight(Root);
            }
            else if (Root.Left != null)
            {
                return SecondMaximumValueLeft(Root);
            }

            return null;
        }



    }
}
          
     


