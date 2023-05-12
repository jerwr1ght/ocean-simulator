using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1draftForm
{
    class Obstacle : Cell
    {
        public Obstacle(Coordinate aCoord) : base(aCoord)
        {
            image = Constants.ObstacleImage;
        }

        public override string ClassName() => "Obstacle";

    }
}
