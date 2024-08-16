using C_BASICS.Trees;
using System;
using System.Collections.Generic;
using Xunit;

namespace C_Basics_test
{
    public class BST_Test
    {
        [Fact]
        public void PreOrder_Test()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);
            bst.Add(12);
            bst.Add(20);

            var expected = new List<int> { 10, 5, 2, 7, 15, 12, 20 };
            var result = PreOrderTraversal(bst.Root);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InOrder_Test()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);
            bst.Add(12);
            bst.Add(20);

            var expected = new List<int> { 2, 5, 7, 10, 12, 15, 20 };
            var result = InOrderTraversal(bst.Root);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void PostOrder_Test()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);
            bst.Add(12);
            bst.Add(20);

            var expected = new List<int> { 2, 7, 5, 12, 20, 15, 10 };
            var result = PostOrderTraversal(bst.Root);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAddNode()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);

            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
            Assert.False(bst.Contains(20));
        }

        [Fact]
        public void TestContainsNode()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);

            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.False(bst.Contains(100));
        }

        [Fact]
        public void TestRemoveNode()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);
            bst.Remove(5);

            Assert.False(bst.Contains(5));
            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(15));
            Assert.True(bst.Contains(2));
            Assert.True(bst.Contains(7));
        }

        [Fact]
        public void TestMirror_Tree()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);
            bst.Add(12);
            bst.Add(20);

            bst.Mirror();

            var expected = new List<int> { 20, 15, 12, 10, 7, 5, 2 };
            var result = InOrderTraversal(bst.Root);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMirror_SingleNodeTree()
        {
            var bst = new BinarySearchTree(10);

            bst.Mirror();

            var expected = new List<int> { 10 };
            var result = InOrderTraversal(bst.Root);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMirror_EmptyTree()
        {
            var bst = new BinarySearchTree(0); 
            bst.Mirror();

            var expected = new List<int>();
            var result = InOrderTraversal(bst.Root);

            Assert.Equal(expected, result);
        }

        private List<int> PreOrderTraversal(TNode node)
        {
            var result = new List<int>();
            PreOrder(node, result);
            return result;
        }

        private void PreOrder(TNode node, List<int> result)
        {
            if (node == null) return;

            result.Add(node.Data);
            PreOrder(node.Left, result);
            PreOrder(node.Right, result);
        }

        private List<int> InOrderTraversal(TNode node)
        {
            var result = new List<int>();
            InOrder(node, result);
            return result;
        }

        private void InOrder(TNode node, List<int> result)
        {
            if (node == null) return;

            InOrder(node.Left, result);
            result.Add(node.Data);
            InOrder(node.Right, result);
        }

        private List<int> PostOrderTraversal(TNode node)
        {
            var result = new List<int>();
            PostOrder(node, result);
            return result;
        }

        private void PostOrder(TNode node, List<int> result)
        {
            if (node == null) return;

            PostOrder(node.Left, result);
            PostOrder(node.Right, result);
            result.Add(node.Data);
        }
    }
}
