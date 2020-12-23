using System.Collections.Generic;

namespace MarsRover.Abstractions
{
    public interface IMovable
    {
        void Move(KeyValuePair<int,int> newDestination);
    }
}