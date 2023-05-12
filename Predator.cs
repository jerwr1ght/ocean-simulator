using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1draftForm
{
    public class Predator : Prey
    {
        protected uint timeToFeed;

        protected override Cell Reproduce(Coordinate anOffset)
        {
            Ocean1.NumPredators++;
            return new Predator(anOffset, Constants.TimeToReproduce);
        }

        public Predator(Coordinate aCoord, int timeToBreed): base(aCoord, timeToBreed)
        {
            timeToReproduce = timeToBreed;
            timeToFeed = Constants.TimeToFeed;
            image = Constants.DefaultPredImage;
            Processed = true;
        }

        
        public override void Process()
        {
            if (Processed == false)
            {
                if (timeToFeed-- > 0)
                {
                        Coordinate preyLocation = Ocean1.GetPreyNeighborCoord(Offset);
                        Coordinate off_temp = Offset; // Тимчасова змінна, що зберігає Offset перед переміщенням

                        if (preyLocation != Offset)
                        {
                            MoveFrom(Offset, preyLocation);
                            timeToFeed = Constants.TimeToFeed;
                            Ocean1.NumPrey--; // Тут цього не було, тож кількість здобичі не зменшувалась
                    }
                        else if (Ocean1.GetEmptyNeighborCoord(Offset) != Offset) {
                            MoveFrom(Offset, Ocean1.GetEmptyNeighborCoord(Offset));
                        }

                        if (timeToReproduce-- <= 0 && Offset != off_temp) // Заміна того великого if з кодом. Якщо умова виконується, на старому Offset буде новий об'єкт Predator 
                        {
                            AssignCellAt(off_temp, Reproduce(off_temp));
                            timeToReproduce = Constants.TimeToReproduce;
                        }

                }
                else
                {
                    AssignCellAt(Offset, new Cell(Offset));
                    Ocean1.NumPredators--;
                }
                Processed = true;
            }
        }

        public override string ClassName() => "Predator";

        public override string ToString()
        {
            return base.ToString() + $"Time to feed: {timeToFeed}";
        }
    }
}
