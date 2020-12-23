using System.Collections.Generic;

namespace MarsRover.Abstractions
{
    public interface IPlateau
    {
        bool CanStay(KeyValuePair<int,int> destination);

    }
}