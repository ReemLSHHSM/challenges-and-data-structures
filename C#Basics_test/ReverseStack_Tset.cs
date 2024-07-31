using C_BASICS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_test
{
    public class ReverseStack_Tset
    {
        [Fact]
        public void MultipleElements_Test()
        {
            // Arrange
            var stack = new StackWithReverse();
            stack.push(1);
            stack.push(2);
            stack.push(3);

            

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.Peek());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
        }

        [Fact]
        public void OneElement_Test()
        {
            // Arrange
            var stack = new StackWithReverse();
            stack.push(1);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.Peek());
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void EmptyStack_Test()
        {
            // Arrange
            var stack = new StackWithReverse();

            // Act & Assert
            bool answer = false;

            Assert.Equal(stack.ReverseStack(),answer);
        }


    }
}
