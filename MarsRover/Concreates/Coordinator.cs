using System;
using System.Collections.Generic;
using MarsRover.Enums;

namespace MarsRover.Concreates
{
    public class Coordinator
    {
        private readonly MarsPlateau _plateu;

        public Coordinator(int plateauTopRightX, int plateauTopRightY)
        {
            //Plateau can be created with Factory Pattern for different shapes such as triangle 
            _plateu = new MarsPlateau(plateauTopRightX,plateauTopRightY);
        }
        public (int,int,char)  ProcessMarsRoverProblem(int roverX, int roverY,
            char roverDirection, string command)
        {
            //Rover can be created with Abstract Factory Pattern for different abilities (Maybe there are an rovers which can fly)
            var rover = new MarsRover(roverX,roverY,GetDirection(roverDirection));
            
            var commandManager = new CommandManager();

            foreach (var unitCommand in command)
            {
                var commandType = GetCommand(unitCommand);
                if (commandType.GetType() == typeof(Direction))
                {
                    var moveStep = commandManager.MoveStep(rover.CurrentDirection);
                    var newDestination = new KeyValuePair<int, int>(rover.Destination.Key + moveStep.Item1,rover.Destination.Value + moveStep.Item2);
                    //check for if there is a destination which plateau has 
                    if(_plateu.CanStay(newDestination))
                        rover.Move(newDestination);
                    else
                        throw new Exception("Rover cannot go there");
                }else if (commandType.GetType() == typeof(Way))
                {
                    var newWay = commandManager.RotationStep(rover.CurrentDirection, (Way) commandType);
                    rover.Rotate(newWay);
                }
            }
            
            return (rover.Destination.Key, rover.Destination.Value, rover.CurrentDirection.ToString()[0]);
        }


        private  Direction GetDirection(char c)
        {
            return c switch
            {
                'N' => Direction.North,
                'E' => Direction.East,
                'S' => Direction.South,
                'W' => Direction.West,
                _ => throw new Exception("Undefined direction")
            };
        }


        private object GetCommand(char ch)
        {
            return ch switch
            {
                'L' => Way.Left,
                'R' => Way.Right,
                'M' => Direction.None,
                _ => throw new Exception("Undefined command")
            };
        }
    }
}