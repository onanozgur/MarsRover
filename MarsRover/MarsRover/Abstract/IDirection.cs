using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Abstract
{
    public interface IDirection
    {
        void RotateRight();

        void RotateLeft();

        string PrintDirection();
    }
}
