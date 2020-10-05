using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Abstract
{
    public interface ISurface<TEntity> where TEntity : class
    {
        bool CheckBorderLimits(TEntity entities);
    }
}
