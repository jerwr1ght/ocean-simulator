using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Practice1draftForm
{
    public class Constants
    {
        public const int MinNumObstacles = 1;
        public const int DefaultNumObstacles = 75;
        public const int MinNumPredators = 1;
        public const int DefaultNumPredators = 20;
        public const int MinNumPrey = 1;
        public const int DefaultNumPrey = 150;
        public const int MinNumIterations = 1;
        public const int DefaultNumIterations = 1000;
        public const int numNeighbors = 4;
        public const int TimeToReproduce = 6;
        public const int TimeToFeed = 6;
        public const int SleepingTime = 150;

        public const char DefaultImage = '-';
        public const char DefaultPreyImage = 'f';
        public const char DefaultPredImage = 'S';
        public const char ObstacleImage = '#';

        // Для кнопок поля
        public const int BtnMargin = 10;
        public const int BtnPadding = 10;
        public const int BtnWidth = 64;
        public const int BtnHeight = 64;
        public const int BtnWidthPercents = 60;
        public const int BtnHeightPercents = 60;
        public static int MaxRows = 25;
        public static int MaxCols = 70;
        public const int MinRows = 2;
        public const int MinCols = 2;




    }
}
