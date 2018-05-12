using Queues;
using FluentAssertions;
using Xunit;

namespace Queues.Tests
{
    public class DequeTests
    {
        [Fact]
        public void Capacity()
        {
            // given
            int capacity = 8;
            int[] arr = {1, 2, 3, 4, 5};

            // when
            var d = new Deque<int>(arr);

            // then
            d.Capacity.Should().Be(capacity);
        }

        [Fact]
        public void CustomCapacity()
        {
            // given
            int capacity = 8;

            // when
            var d = new Deque<int>(capacity);

            // then
            d.Capacity.Should().Be(capacity);
        }

        [Fact]
        public void QueueCount_SingleItem()
        {
            // given
            int[] arr = { 1 };
            // when
            var d = new Deque<int>(arr);

            // then
            d.Count.Should().Be(1);
        }

        [Fact]
        public void QueueCount_FirstRangeItems()
        {
            // given
            int[] arr = {1, 2, 3, 4, 5};

            // when
            var d = new Deque<int>(arr);

            // then
            d.Count.Should().Be(5);
        }

        [Fact]
        public void QueueCount_RangeItems()
        {
            // given
            int[] arrFront = {5, 4, 3, 2, 1};
            int[] arrBack = {6, 7, 8, 9, 10};

            // when
            var d = new Deque<int>(arrBack, arrFront);

            // then
            d.Count.Should().Be(10);
        }

        [Fact]
        public void AddFirst_SingleItem()
        {
            // given
            int number = 5;
            var d = new Deque<int>();

            // when
            d.AddFirst(number);

            // then
            d.Count.Should().Be(1);
        }

        [Fact]
        public void AddFirst_RangeItems()
        {
            // given
            int[] arr = {1, 2, 3, 4, 5};
            var d = new Deque<int>();

            // when
            d.AddFirst(arr);

            // then
            d.Count.Should().Be(arr.Length);
        }

        [Fact]
        public void AddLast_SingleItem()
        {
            // given
            int number = 5;
            var d = new Deque<int>();

            // when
            d.AddLast(number);

            // then
            d.Count.Should().Be(1);
        }

        [Fact]
        public void AddLast_RangeItems()
        {
            // given
            int[] arr = {1, 2, 3, 4, 5};
            var d = new Deque<int>();

            // when
            d.AddLast(arr);

            // then
            d.Count.Should().Be(arr.Length);
        }
    }   
}