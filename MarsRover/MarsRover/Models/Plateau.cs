using MarsRover.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Plateau : ISurface<Coordinates>
    {
        private Coordinates _topRightCoordinates = new Coordinates(0, 0);
        private Coordinates _bottomLeftCoordinates = new Coordinates(0, 0);

        public Plateau()
        {

        }

        public Plateau(int topRightCoordinateX, int topRightCoordinateY)
        {
            _topRightCoordinates = _topRightCoordinates.CreateNewCoordinates(topRightCoordinateX, topRightCoordinateY);
        }

        public bool CheckBorderLimits(Coordinates coordinates)
        {
            return _bottomLeftCoordinates.CheckBorderInside(coordinates) && this._topRightCoordinates.CheckBorderOutside(coordinates);
        }
    }
}
