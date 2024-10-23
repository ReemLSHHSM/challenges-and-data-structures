using System;
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

        public int LeafSum()
        {
            return LeafSum(Root);
        }

        public int LeafSum(TNode node)
        {
            if (node == null) return 0;

            if (node.Left == null && node.Right == null)
            {
                return node.Data;
            }

            return LeafSum(node.Left) + LeafSum(node.Right);
        }

        public List<int> LargestLevelValue()
        {
            List<int> largestValues = new List<int>();
            if (Root == null) return largestValues;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxLevelValue = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    TNode node = queue.Dequeue();
                    maxLevelValue = Math.Max(maxLevelValue, node.Data);

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                largestValues.Add(maxLevelValue);
            }

            return largestValues;
        }

        public void PrintRightView()
        {
            if (Root == null) return;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();

                    if (i == levelSize - 1)
                    {
                        Console.Write(currentNode.Data + " ");
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }
        }


        public int FindMaxNodesLevel()
        {
            if (Root == null) return -1;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);
            int maxNodes = 0;
            int levelWithMaxNodes = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int nodeCount = queue.Count;
                if (nodeCount > maxNodes)
                {
                    maxNodes = nodeCount; 
                    levelWithMaxNodes = currentLevel;
                }

                for (int i = 0; i < nodeCount; i++)
                {
                    TNode node = queue.Dequeue();
                    if (node.Left != null) queue.Enqueue(node.Left);
                    if (node.Right != null) queue.Enqueue(node.Right);
                }

                currentLevel++; 
            }

            return levelWithMaxNodes; 
        }

       
    }



}

          
     


