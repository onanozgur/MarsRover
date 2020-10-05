using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Abstract
{
    public interface IVehicle
    {
        void RotateLeft();

        void RotateRight();

        void Move();

        string CurrentLocation();
    }
}
