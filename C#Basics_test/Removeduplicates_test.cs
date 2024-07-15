using C_BASICS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_test
{
    public class Removeduplicates_test
    {


        [Fact]
        public void Test_noduplicates()
        {
            //Assign
            LinkedList list = new LinkedList(new Node(1));
            list.addtoHead(new Node(3));
            list.addtoHead(new Node(2));

            //Act
            string output=list.RemoveDuplicate();

            //Assert
            Assert.Equal(output, "2 3 1 ");
        }

        [Fact]
        public void only_duplicate()
        {
            //Assign
            LinkedList list = new LinkedList(new Node(1));
            list.addtoHead(new Node(3));
            list.addtoHead(new Node(2));
            list.addtoHead(new Node(2));
            list.addtoHead(new Node(3));
            //Act
            string output = list.RemoveDuplicate();

            //Assert
            Assert.Equal(output, "3 2 1 ");
        }

        [Fact]
        public void singlenode_test()
        {
            //Assign
            LinkedList list = new LinkedList(new Node(1));
            list.addtoHead(new Node(1));
            list.addtoHead(new Node(1));
            list.addtoHead(new Node(1));
            list.addtoHead(new Node(1));
            //Act
            string output = list.RemoveDuplicate();

            //Assert
            Assert.Equal(output, "1 ");
        }
    }
}
