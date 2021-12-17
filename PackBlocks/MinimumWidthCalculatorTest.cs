using System;
using FluentAssertions;
using Xunit;

namespace PackBlocks
{
    public class MinimumWidthCalculatorTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 1, 3, 3 }, 2, 6)]
        [InlineData(new int[] { 2, 3, 1, 1, 1 }, 2, 5)]
        [InlineData(new int[] { 2, 3, 1, 1 }, 2, 5)]
        [InlineData(new int[] { 2, 3, 1, 1 }, 3, 3)]
        [InlineData(new int[] { 2, 3, 1, 1 }, 4, 3)]
        [InlineData(new int[] { 2, 3, 1, 1, 1, 1 }, 4, 3)] 
        public void PackBlocksTest(int[] blocks, int height, int assertedMinimumWidth)
        {
            var calculator = new MinimumWidthCalculator();

            var calculatedMinimumWidth = calculator.PackBlock(blocks, height);

            calculatedMinimumWidth.Should().Be(assertedMinimumWidth);
        }
    }
}
