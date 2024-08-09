using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_BASICS.MinStack;
namespace C_Basics_test
{
    public class MinStackTest
    {

        [Fact]
        public void test_min()
        {
            //Arrange
           MinStack stack = new MinStack();
            stack.push(2);
            stack.push(3);
            stack.push(-1);
            stack.push(5);

            // Act
            int min =stack.GetMin();

            //Assert
            Assert.Equal(-1, min);

        }

        [Fact]
        public void Test_popping()
        {
            //Arrange
            MinStack stack = new MinStack();
            stack.push(2);
            stack.push(3);
            stack.push(-1);
            stack.push(5);

            //Act
            stack.Pop();
            int min = -1;

            //Assert
            Assert.Equal(stack.GetMin(), min);
        }

        [Fact]
        public void Test_pushing()
        {
            //Arrange
            MinStack stack = new MinStack();
            stack.push(2);
            stack.push(3);
            stack.push(-1);
            stack.push(5);

            //Act
            stack.push(-2);
            int min = -2;

            //Assert
            Assert.Equal(stack.GetMin(), min);
        }

    }
}
