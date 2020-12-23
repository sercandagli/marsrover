using MarsRover.Enums;

namespace MarsRover.Abstractions
{
    public interface IRotatable
    {
        void Rotate(Direction newDirection);
    }
}