using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1draftForm
{
    public class Coordinate
    {
        public uint X { get; set; }
        public uint Y { get; set; }

        public Coordinate(uint aY, uint aX )
        {
            X = aX;
            Y = aY;
        }
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }


        // Усе, що нижче, для того, щоб реалізувати == та != для порівняння екземплярів класу Coordinate

        public static bool operator ==(Coordinate c1, Coordinate c2) => c1.Equals(c2);
        public static bool operator !=(Coordinate c1, Coordinate c2) => !c1.Equals(c2);
        public override bool Equals(object obj) => obj.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();
        public override string ToString() => $"[{X};{Y}]";


    }
}
