using MarsRover.Enums;
using Xunit;

namespace MarsRover.Test
{
    public class CommandManagerTests
    {
        [Theory]
        [InlineData(Direction.North,0,1)]
        [InlineData(Direction.East,1,0)]
        [InlineData(Direction.South,0,-1)]
        [InlineData(Direction.West,-1,0)]
        public void ShouldReturnCorrectMoveSteps(Direction direction,int xDirection,int yDirection)
        {
            var commandManager = new CommandManager();
            var actual = commandManager.MoveStep(direction);
            var expected = (xDirection, yDirection);
            Assert.Equal(expected, actual);
        }
        
        
        [Theory]
        [InlineData(Direction.North,Way.Left,Direction.West)]
        [InlineData(Direction.North,Way.Right,Direction.East)]
        [InlineData(Direction.East,Way.Left,Direction.North)]
        [InlineData(Direction.East,Way.Right,Direction.South)]
        [InlineData(Direction.South,Way.Left,Direction.East)]
        [InlineData(Direction.South,Way.Right,Direction.West)]
        [InlineData(Direction.West,Way.Left,Direction.South)]
        [InlineData(Direction.West,Way.Right,Direction.North)]
        public void ShouldReturnCorrectRotationSteps(Direction direction,Way way,Direction expectedDirection)
        {
            var commandManager = new CommandManager();
            var actual = commandManager.RotationStep(direction,way);
            Assert.Equal(expectedDirection, actual);
        }
    }
}
