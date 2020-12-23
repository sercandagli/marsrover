using System.Collections.Generic;
using System.Linq;
using MarsRover.Abstractions;

namespace MarsRover.Concreates
{
    public class MarsPlateau : IPlateau
    {
        private List<KeyValuePair<int,int>> Coordinates { get; set; }

        public MarsPlateau(int topRightX,int topRightY)
        {
            PopulateCoordinates(topRightX,topRightY);
        }

        public bool CanStay(KeyValuePair<int,int> destination)
        {
            return Coordinates.Any(x => x.Key == destination.Key && x.Value == destination.Value);
        }

        private void PopulateCoordinates(int xAxis, int yAxis)
        {
            Coordinates = new List<KeyValuePair<int, int>>();
            for (var x = 0; x <= xAxis; x++)
            {
                for (var y = 0; y < yAxis; y++)
                {
                    Coordinates.Add(new KeyValuePair<int, int>(x,y));
                }
            }
        }
    }
}