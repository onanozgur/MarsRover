using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Coordinates
    {
        private int _coordinateX;
        private int _coordinateY;

        public Coordinates(int coordinateX, int coordinateY)
        {
            _coordinateX = coordinateX;
            _coordinateY = coordinateY;
        }

        public Coordinates CreateNewCoordinates(int newCoordinateX, int newCoordinateY)
        {
            return new Coordinates(_coordinateX + newCoordinateX, _coordinateY + newCoordinateY);
        }

        public Boolean CheckBorderInside(Coordinates coordinates)
        {
            return IsXCoordinateInside(coordinates._coordinateX) && IsYCoordinateInside(coordinates._coordinateY);
        }

        public Boolean CheckBorderOutside(Coordinates coordinates)
        {
            return IsXCoordinateOutside(coordinates._coordinateX) && IsYCoordinateOutside(coordinates._coordinateY);
        }

        private Boolean IsXCoordinateInside(int coordinateX)
        {
            return _coordinateX <= coordinateX;
        }

        private Boolean IsYCoordinateInside(int coordinateY)
        {
            return _coordinateY <= coordinateY;
        }

        private Boolean IsXCoordinateOutside(int coordinateX)
        {
            return _coordinateX >= coordinateX;
        }

        private Boolean IsYCoordinateOutside(int coordinateY)
        {
            return _coordinateY >= coordinateY;
        }

        public string PrintCoordinates()
        {
            StringBuilder coordinate = new StringBuilder();
            coordinate.Append(_coordinateX);
            coordinate.Append(" ");
            coordinate.Append(_coordinateY);

            return coordinate.ToString();
        }
    }
}
