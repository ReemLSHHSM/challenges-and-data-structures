using C_BASICS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linkedlist = C_BASICS.LinkedList.LinkedList;
namespace C_Basics_test
{
    public class LinkedListTest
    {
        [Fact]
        public void Test_rotating_by_k_Zero()
        {
            //Arrange
            Node node = new Node(1);
            linkedlist list=new linkedlist();

            //Act
            list.addtoHead(node);
            list.Add_Node(2);
            list.Add_Node(3);
            list.Add_Node(4);
            list.Add_Node(5);
            list.Add_Node(6);
            list.Add_Node(7);
            list.Add_Node(8);

            list.RotateLeft(0);
           var printedlist= list.PrintList();

            var expected_output = "1 2 3 4 5 6 7 8 ";

        //Assert
        Assert.Equal(expected_output, printedlist);

        }

        [Fact]
        public void greater_than_the_list_length()
        {
            //Arrange 
            Node node=new Node(1);
            linkedlist list=new linkedlist();

            //Act
            list.addtoHead(node);
            list.Add_Node(2);
            list.Add_Node(3);
            list.Add_Node(4);
            list.Add_Node(5);
            list.Add_Node(6);


            list.RotateLeft(7);
            var result=list.PrintList();

            var expected = "2 3 4 5 6 1 ";

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
