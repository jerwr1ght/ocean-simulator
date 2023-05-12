using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1draftForm
{
    public class Prey : Cell
    {
        protected int timeToReproduce;

        protected override Cell Reproduce(Coordinate anOffset)
        {
            Ocean1.NumPrey++;
            return new Prey(anOffset, Constants.TimeToReproduce);
        }

        public Prey(Coordinate anOffset, int timeToBreed) : base(anOffset)
        {
            Offset = anOffset;
            timeToReproduce = timeToBreed;
            image = Constants.DefaultPreyImage;
            Processed = true;
        }
        
        public override void Process()
        {
            if (Processed == false)
            {
                Coordinate off_temp = Offset; // Тимчасова змінна, що зберігає Offset перед переміщенням

                MoveFrom(Offset, Ocean1.GetEmptyNeighborCoord(Offset));

                if (timeToReproduce-- <= 0 && Offset != off_temp)
                {
                    AssignCellAt(off_temp, Reproduce(off_temp)); // Заміна того великого if з кодом. Якщо умова виконується, на старому Offset буде новий об'єкт Prey 
                    timeToReproduce = Constants.TimeToReproduce;
                }
                Processed = true;
            }
        }

        public override string ClassName() => "Prey";

        public override string ToString()
        {
            return base.ToString()+$"Time to reproduce: {timeToReproduce}\n";
        }
    }
}
