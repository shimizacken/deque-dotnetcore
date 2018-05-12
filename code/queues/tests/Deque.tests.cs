using Queues;
using FluentAssertions;
using Xunit;

namespace Queues.Tests
{
    public class DequeTests
    {
        [Fact]
        public void QueueCount()
        {
            // given
            int[] arrFront = {5, 4, 3, 2, 1};
            int[] arrBack = {6, 7, 8, 9, 10};

            // when
            var deque = new Deque<int>(arrBack, arrFront);

            // then
            deque.Count.Should().Be(10);
        }

        
    }   
}