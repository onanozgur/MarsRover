using MarsRover.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Direction : IDirection
    {
        private int _sizeOfCoordinateX;
        private int _sizeOfCoordinateY;
        private string _currentDirection;

        public Direction()
        {
            _sizeOfCoordinateX = 0;
            _sizeOfCoordinateY = 0;
            _currentDirection = string.Empty;
        }

        public Direction(string currentDirection, int sizeOfCoordinateX, int sizeOfCoordinateY)
        {
            _currentDirection = CheckDirection(currentDirection);
            _sizeOfCoordinateX = sizeOfCoordinateX;
            _sizeOfCoordinateY = sizeOfCoordinateY;
        }

        public int GetCoordinatesXByDirection()
        {
            if (_currentDirection == DirectionDescription.North.ToString() || _currentDirection == DirectionDescription.South.ToString())
                _sizeOfCoordinateX = 0;
            else if (_currentDirection == DirectionDescription.East.ToString())
                _sizeOfCoordinateX = 1;
            else if (_currentDirection == DirectionDescription.West.ToString())
                _sizeOfCoordinateX = -1;

            return _sizeOfCoordinateX;
        }

        public int GetCoordinatesYByDirection()
        { 
            if (_currentDirection == DirectionDescription.East.ToString() || _currentDirection == DirectionDescription.West.ToString())
                _sizeOfCoordinateY = 0;
            else if (_currentDirection == DirectionDescription.North.ToString())
                _sizeOfCoordinateY = 1;
            else if (_currentDirection == DirectionDescription.South.ToString())
                _sizeOfCoordinateY = -1;

            return _sizeOfCoordinateY;
        }

        public string CheckDirection(string currentDirectionChar)
        {
            if (currentDirectionChar == "N")
                return DirectionDescription.North.ToString();
            else if (currentDirectionChar == "E")
                return DirectionDescription.East.ToString();
            else if (currentDirectionChar == "W")
                return DirectionDescription.West.ToString();
            else if (currentDirectionChar == "S")
                return DirectionDescription.South.ToString();
            else
                return string.Empty;
        }

        public void RotateLeft()
        {
            if (_currentDirection == DirectionDescription.North.ToString())
                 _currentDirection = DirectionDescription.West.ToString();
            else if (_currentDirection == DirectionDescription.East.ToString())
                _currentDirection = DirectionDescription.North.ToString();
            else if (_currentDirection == DirectionDescription.West.ToString())
                _currentDirection = DirectionDescription.South.ToString();
            else if (_currentDirection == DirectionDescription.South.ToString())
                _currentDirection = DirectionDescription.East.ToString();
        }

        public void RotateRight()
        {
            if (_currentDirection == DirectionDescription.North.ToString())
                _currentDirection = DirectionDescription.East.ToString();
            else if (_currentDirection == DirectionDescription.East.ToString())
                _currentDirection = DirectionDescription.South.ToString();
            else if (_currentDirection == DirectionDescription.West.ToString())
                _currentDirection = DirectionDescription.North.ToString();
            else if (_currentDirection == DirectionDescription.South.ToString())
                _currentDirection = DirectionDescription.West.ToString();
        }

        public string PrintDirection()
        {
            if (_currentDirection == DirectionDescription.North.ToString())
                return "N";
            else if (_currentDirection == DirectionDescription.East.ToString())
                return "E";
            else if (_currentDirection == DirectionDescription.West.ToString())
                return "W";
            else if (_currentDirection == DirectionDescription.South.ToString())
                return "S";
            else
                return string.Empty;
        }

        public enum DirectionDescription
        {
            North,
            West,
            East,
            South
        }
    }
}
