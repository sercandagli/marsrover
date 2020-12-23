using System.Collections.Generic;
using MarsRover.Enums;
using Xunit;

namespace MarsRover.Test
{
    public class MarsRoverTests
    {
        [Theory]
        [InlineData(3,4)]
        [InlineData(4,5)]
        [InlineData(1,2)]
        public void Should_ChangeDestination_WithGivenDestinations(int x,int y)
        {
            var marsRover = new Concreates.MarsRover(1,1,Direction.East);
            var expected = new KeyValuePair<int, int>(x, y);
            marsRover.Move(expected);
            var actual = marsRover.Destination;
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(Direction.West)]
        [InlineData(Direction.North)]
        [InlineData(Direction.South)]
        public void Should_ChangeDirection_WithGivenDirections(Direction expectedDirection)
        {
            var marsRover = new Concreates.MarsRover(1,1,Direction.East);
            marsRover.Rotate(expectedDirection);
            var actual = marsRover.CurrentDirection;
            Assert.Equal(expectedDirection,actual);
        }
    }
}