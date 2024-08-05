using C_BASICS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_test
{
    public class Remove_Middle_Test
    {
        [Fact]
        public void OddSized_Test()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(4, stack.stacklength());
            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(5, stack.Pop());
        }

        [Fact]
        public void EvenSized_Test()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);

            // Act
            stack.DeleteMiddle();

            // Assert

            Assert.Equal(3, stack.stacklength());
            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(4, stack.Pop());
        }
    }
}
