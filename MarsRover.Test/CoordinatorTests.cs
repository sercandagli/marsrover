using MarsRover.Concreates;
using Xunit;

namespace MarsRover.Test
{
    public class CoordinatorTests
    {
        [Theory]
        [InlineData(5, 5, 1, 2, 'N', "LMLMLMLMM", 1, 3, 'N')]
        [InlineData(5, 5, 3, 3, 'E', "MMRMMRMRRM", 5, 1, 'E')]
        public void Should_MoveCorrectlyWithGivenValues(int plateauX,int plateauY,int roverX,int roverY,char roverDirection,string command,int expectedX,int expectedY,char expectedDirection)
        {
            var coordinator = new Coordinator(plateauX,plateauY);
            var expected = (expectedX, expectedY, expectedDirection);
            var actual =coordinator.ProcessMarsRoverProblem(roverX, roverY, roverDirection, command);
            Assert.Equal(expected,actual);
        }
    }
}