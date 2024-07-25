using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_BASICS;

namespace C_Basics_test
{
    public class stack_queue_test
    {


        [Fact]
        public void AddNodeToStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.push(10);

            // Assert
            Assert.False(stack.isEmpty());
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void RemoveNodeFromStack()
        {
            // Arrange
            var stack = new Stack();
            stack.push(10);
            stack.push(20);

            // Act
            int poppedValue = stack.Pop();

            // Assert
            Assert.Equal(20, poppedValue);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void IsEmpty()
        {
            // Arrange
            var stack = new Stack();

            // Act & Assert
            Assert.True(stack.isEmpty());
        }

        //Queue testing
        [Fact]
        public void TestEnqueue()
        {
            // Arrange
            var queue = new Queue();

            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Assert
            Assert.Equal(1, queue.Peek()); 
           
        }

        [Fact]
        public void TestDequeue()
        {
            // Arrange
            var queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Act
            int dequeuedValue = queue.Dequeue();

            // Assert
            Assert.Equal(1, dequeuedValue); 
             
           
        }

        [Fact]
        public void TestIsEmpty()
        {
            // Arrange
            var queue = new Queue();

            // Act & Assert
            Assert.True(queue.IsEmpty()); //before adding anything

            queue.Enqueue(1);
            Assert.False(queue.IsEmpty()); //after adding

            queue.Dequeue();
            Assert.True(queue.IsEmpty()); //after poping
        }

    }
}
