using C_BASICS;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using System.Xml.Linq;

namespace C_Basics_test
{
    public class UnitTest1
    {
        //Testing when Arr2's length is bigger than Arr1's
        // [Fact]
        //public void big_arr2()
        //{

        //    //Assign 
        //    var arr1 = new int[] { 1, 2, 3,8 ,9,0,4};
        //    var arr2 = new int[] { 45, 4, 3,8,9,22,22,22,22 };
        //    var common = new int[] { 4,3,8,9};
        //    //Act
        //    C_BASICS.Program program= new C_BASICS.Program();

        //    var result= program.CommonElements(arr1, arr2);

        //    //Assert
        //    Assert.Equal(result,common);

        //}

        //Testing when Arr1's length is bigger than Arr2's
        //[Fact]
        //public void big_arr1()
        //{

        //    //Assign 
        //    var arr1 = new int[] { 1, 2, 3, 4 };
        //    var arr2 = new int[] { 45, 4};
        //    var common = new int[] {4};
        //    //Act
        //    C_BASICS.Program program = new C_BASICS.Program();

        //    var result = program.CommonElements(arr1, arr2);

        //    //Assert
        //    Assert.Equal(result, common);

        //}

        ////Testing when Arr1's length equals Arr2's
        //[Fact]
        //public void length_equal()
        //{

        //    //Assign 
        //    var arr1 = new int[] { 1, 4 };
        //    var arr2 = new int[] { 45, 4 };
        //    var common = new int[] { 4 };
        //    //Act
        //    C_BASICS.Program program = new C_BASICS.Program();

        //    var result = program.CommonElements(arr1, arr2);

        //    //Assert
        //    Assert.Equal(result, common);

        //}


        [Fact]
        public void test_revers()
        {
            //Assign 
            //test1
            string sent1 = "csharp is programming language";
            string test1 = "language programming is csharp";

            // test2

            string sent2 = "Reverse the words in this sentence";
            string test2 = "sentence this in words the Reverse";

            // test3

            string sent3 = "challenges and data structures";
            string test3 = "structures data and challenges";

            //Act
            //Reverse_Words reverse_Words =new Reverse_Words();
            string result1 = Reverse_Words.ReverseWords(sent1);
            string result2 = Reverse_Words.ReverseWords(sent2);
            string result3 = Reverse_Words.ReverseWords(sent3);

            //Assert
            Assert.Equal(test1, result1);
            Assert.Equal(test2, result2);
            Assert.Equal(test3, result3);

        }

        [Fact]
        public void RemoveNode()
        {
            // Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            LinkedList list = new LinkedList(node1);
            list.addtoHead(node2);
            list.addtoHead(node3);

            // Act
            list.Remove(1);

            // Assert
            Assert.NotNull(list);
            Assert.Equal(3, list.Head.Data);
            Assert.Equal(2, list.Head.Next.Data);
            Assert.Null(list.Head.Next.Next);
        }

        //[Fact]
        //public void DisplayLinkedListContents()
        //{
        //    // Arrange
        //    Node node1 = new Node(1);
        //    Node node2 = new Node(2);
        //    Node node3 = new Node(3);
        //    LinkedList list = new LinkedList(node1);
        //    list.addtoHead(node2);
        //    list.addtoHead(node3);

        //    using (var sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);

        //        // Act
        //        list.Display();

        //        // Assert
        //        var result = sw.ToString().Trim();
        //        Assert.Equal("3\r\n2\r\n1", result);
        //    }
        //}
    }
}