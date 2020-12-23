using System;
using MarsRover.Enums;

namespace MarsRover
{
    public class CommandManager
    {
        private readonly Direction[] Directions;

        public CommandManager()
        {
            Directions = new Direction[4]{Direction.North,Direction.East,Direction.South,Direction.West};
        }


        public Direction RotationStep(Direction currentDirection, Way way)
        {
            var directionIndex = Array.IndexOf(Directions, currentDirection);
            if(directionIndex == -1)
                throw new Exception("Undefined direction");
            switch (way)
            {
                case Way.Left:
                    directionIndex--;
                    break;
                case Way.Right:
                    directionIndex++;
                    break;
                default:
                    throw new Exception("Undefined way");
            }
            
            if (directionIndex < 0)
                directionIndex = Directions.Length - 1;
            else if (directionIndex == Directions.Length)
                directionIndex = 0;

            return Directions[directionIndex];
        }
        
        public (int, int) MoveStep(Direction currentDirection)
        {
            return currentDirection switch
            {
                Direction.North => (0,1),
                Direction.East => (1,0),
                Direction.South => (0,-1),
                Direction.West => (-1,0),
                _ => throw new Exception("Undefined direction")
            };
        }
        
    }
}