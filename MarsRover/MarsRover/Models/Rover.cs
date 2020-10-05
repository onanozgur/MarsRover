using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Rover
    {
        private Coordinates _currentCoordinates;
        private Direction _currentDirection;
        private Plateau _plateau;

        public Rover()
        {

        }

        public Rover(Plateau plateau, Direction direction, Coordinates coordinates)
        {
            _plateau = plateau;
            _currentDirection = direction;
            _currentCoordinates = coordinates;
        }

        public string CurrentLocation()
        {
            return $"{_currentCoordinates.PrintCoordinates()} { _currentDirection.PrintDirection()}";   
        }

        public void RotateLeft()
        {
            _currentDirection.RotateLeft();
        }

        public void RotateRight()
        {
            _currentDirection.RotateRight();
        }

        public void Move()
        {
            Coordinates newCoordinatesAfterMove = _currentCoordinates.CreateNewCoordinates(_currentDirection.GetCoordinatesXByDirection(), _currentDirection.GetCoordinatesYByDirection());

            if(_plateau.CheckBorderLimits(newCoordinatesAfterMove))
            {
                _currentCoordinates = newCoordinatesAfterMove;
            }
        }
    }
}
