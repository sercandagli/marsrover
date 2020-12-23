using System.Collections.Generic;
using MarsRover.Abstractions;
using MarsRover.Enums;

namespace MarsRover.Concreates
{
    public class MarsRover : Rover,IMovable,IRotatable
    {
        public MarsRover(int xAxis, int yAxis, Direction startingDirection)
        {
            Destination = new KeyValuePair<int, int>(xAxis,yAxis);
            CurrentDirection = startingDirection;
        }
        
        public void Move(KeyValuePair<int,int> newDestination)
        {
            //There can be individual processes before go to new destination. 
            Destination = newDestination;
        }

        public void Rotate(Direction newDirection)
        {
            //There can be individual processes before rotate
            CurrentDirection = newDirection;
        }

    
    }
}