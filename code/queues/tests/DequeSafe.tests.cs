using System;
using Queues;
using FluentAssertions;
using Xunit;

namespace Queues.Tests
{
    public class DequeSafeTests
    {
        [Fact]
        public void AddFirst_SingleItem()
        {
            // given
            int number = 5;
            var d = new DequeSafe<int>();

            // when
            d.Prepend(number);

            // then
            d.Count.Should().Be(1);
        }
    }   
}