using System.Collections.Generic;
using MarsRover.Enums;

namespace MarsRover.Abstractions
{
    public abstract class Rover
    {
        public  KeyValuePair<int, int> Destination { get; protected set; }
        public  Direction CurrentDirection { get; protected set; }
    }
}