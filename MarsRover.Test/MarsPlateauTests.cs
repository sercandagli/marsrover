using System.Collections.Generic;
using MarsRover.Concreates;
using Xunit;

namespace MarsRover.Test
{
    public class MarsPlateauTests
    {
        [Theory]
        [InlineData(5,5,6,4,false)]
        [InlineData(8,8,-1,9,false)]
        [InlineData(-5,-5,2,3,false)]
        public void Should_ReturnFalse_When_GivenCoordinatesAreOutOfPlateau(int x,int y,int givenX,int givenY, bool expected)
        {
            var marsPlateau = new MarsPlateau(x,y);
            var actual = marsPlateau.CanStay(new KeyValuePair<int, int>(givenX,givenY));
            Assert.Equal(expected,actual);
        }
    }
}