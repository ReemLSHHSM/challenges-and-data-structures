using C_BASICS;
using C_BASICS.Trees;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

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

        [Fact]
        public void TestFindingSecondMaximumValue()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(20);
            bst.Add(15);

            var secondMax = bst.SecondMaximumValue();

            Assert.Equal(15, secondMax);
        }

        [Fact]
        public void TestTreeWithFewerThanTwoUniqueValues()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(10);
            bst.Add(10);

            var secondMax = bst.SecondMaximumValue();

            Assert.Null(secondMax);
        }

        [Fact]
        public void TestTreeWithNegativeValues()
        {
            var bst = new BinarySearchTree(-10);
            bst.Add(-20);
            bst.Add(-5);
            bst.Add(-15);

            var secondMax = bst.SecondMaximumValue();

            Assert.Equal(-10, secondMax);
        }

        [Fact]
        public void test_positive()
        {
            //Arrange
            var bst = new BinarySearchTree(-10);
            bst.Root = new TNode(9);
            bst.Root.Left = new TNode(8);
            bst.Root.Right = new TNode(12);
            bst.Root.Left.Left = new TNode(3);
            bst.Root.Left.Right = new TNode(7);
            bst.Root.Right.Left = new TNode(17);
            bst.Root.Right.Right = new TNode(23);
            bst.Root.Left.Left.Right = new TNode(4);

            //Act
           int sum= bst.LeafSum();
            int expected_sum = 51;

            //Assert
            Assert.Equal(expected_sum, sum);
        }

        public void test_negative()
        {
            //Arrange
            var bst = new BinarySearchTree(-9);
            bst.Root.Left = new TNode(-8);
            bst.Root.Right = new TNode(-12);
            bst.Root.Left.Left = new TNode(-3);
            bst.Root.Left.Right = new TNode(-7);
            bst.Root.Right.Left = new TNode(-17);
            bst.Root.Right.Right = new TNode(-23);
            bst.Root.Left.Left.Right = new TNode(-4);

            //Act
            int expectedSum = -4 + -7 + -17 + -23;
            int actualSum = bst.LeafSum();

            //Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void Largest_Level_Value()
        {
            BinarySearchTree bst = new BinarySearchTree(5);
            bst.Add(13);
            bst.Add(7);
            bst.Add(3);
            bst.Add(7);
            bst.Add(12);
            bst.Add(20);
            bst.Add(1);
            bst.Add(4);
            bst.Add(11);

            List<int> expected = new List<int> { 5, 13, 20, 11 };
            List<int> actual = bst.LargestLevelValue();

            Assert.Equal(expected, actual);
        }

        private string CaptureConsoleOutput(Action action)
        {
            using (var consoleOutput = new StringWriter()) // 1. Create a StringWriter to capture the output of the console
            {
                Console.SetOut(consoleOutput); // 2. Redirect Console output to the StringWriter
                action(); // 3. Execute the action (in this case, calling tree.PrintRightView())=>the action is a delegate
                return consoleOutput.ToString().Trim(); // 4. Return the captured output as a string 
            }
        }


        [Fact]
        public void PrintRightView()
        {
            //Arrange 
            BinarySearchTree tree = new BinarySearchTree(2);
            tree.Root.Left = new TNode(3);
            tree.Root.Right = new TNode(5);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Right.Right = new TNode(6);
            tree.Root.Left.Left.Right = new TNode(7);

            //Act 
            string output = CaptureConsoleOutput(() => tree.PrintRightView());

            // Assert
            Assert.Equal("2 5 6 7", output);

        }

        [Fact]
        public void RightSkewedTree()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree(10);
            tree.Root.Right = new TNode(20);
            tree.Root.Right.Right = new TNode(30);
            tree.Root.Right.Right.Right = new TNode(40);
            //Act
            string output= CaptureConsoleOutput(() => tree.PrintRightView());
            //Assert
            Assert.Equal("10 20 30 40", output);
        }

        [Fact]
        public void MaxNodesLevel()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree(1);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(3);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Left.Right = new TNode(5);
            tree.Root.Right.Right = new TNode(6);
            tree.Root.Left.Left.Left = new TNode(7);

            //Act
            int level=tree.FindMaxNodesLevel();
            
            //Assert
            Assert.Equal(2, level);
        }

        [Fact]
        public void MaxNodesLevelSame()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree(1);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(3);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Right.Right = new TNode(5);
   
            //Act
            int level = tree.FindMaxNodesLevel();

            //Assert
            Assert.Equal(1, level);
        }


    }
}
