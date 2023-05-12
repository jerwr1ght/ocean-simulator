using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Practice1draftForm
{
    public class Cell
    {

        public static Ocean Ocean1;
        public char image = Constants.DefaultImage;
        public Random random = new Random();
        private Coordinate _offset;

        //public UI userInterface = new UI();
        public bool Processed { get; set; } = false;

        public Coordinate Offset
        {
            get { return _offset; }
            protected set { _offset = value; } 
        }
        protected Cell GetCellAt(int y, int x)
        {
            return Ocean1.cells[y, x];
        }

        protected void AssignCellAt(Coordinate aCoord, Cell aCell)
        {
            Ocean1.cells[aCoord.Y, aCoord.X] = aCell;
        }

        public Cell GetNeighborWitghImage(char anImage)
        {
            Cell[] neighbors = new Cell[Constants.numNeighbors];
            int count = 0;

            if (North().GetImage() == anImage)
            {
                neighbors[count++] = North();
            }
            
            if (South().GetImage() == anImage)
            {
                neighbors[count++] = South();
            }
            
            if (East().GetImage() == anImage)
            {
                neighbors[count++] = East();
            }
            
            if (West().GetImage() == anImage)
            {
                neighbors[count++] = West();
            }

            if (count==0)
            {
                return this;
            }
            else
            {
                return neighbors[Ocean1.random.Next(0, count)];
            }
        }

        protected Cell North()
        {
            uint yvalue = (Offset.Y > 0) ? (Offset.Y - 1) : (uint)(Ocean1.NumRows - 1);
            return Ocean1.cells[yvalue, Offset.X];

            //return Ocean1.cells[Offset.Y - 1, Offset.X];
        }

        protected Cell South()
        {
            //uint yvalue;

            //yvalue = (Offset.Y + 1) % (uint)Ocean1.NumRows;
            //return Ocean1.cells[yvalue, Offset.X];
            
            uint yvalue = (Offset.Y + 1 < Ocean1.NumRows) ? (Offset.Y + 1) : 0;           
            return Ocean1.cells[yvalue, Offset.X];

        }

        protected Cell East()
        {
            //uint xvalue;

            //xvalue = (Offset.X + 1) % (uint)Ocean1.NumCols;
            //return Ocean1.cells[Offset.Y, xvalue];
            
            uint xvalue = (Offset.X+1 < Ocean1.NumCols) ? (Offset.X + 1) : 0;
            return Ocean1.cells[Offset.Y, xvalue];
        }

        protected Cell West()
        {
            uint xvalue = (Offset.X > 0) ? (Offset.X - 1) : (uint)(Ocean1.NumCols - 1);
            return Ocean1.cells[Offset.Y, xvalue];

            //return Ocean1.cells[Offset.Y, Offset.X - 1];
        }

        protected virtual Cell Reproduce(Coordinate anOffset)
        {
            return this;
        }

        public Cell(Coordinate offset) 
        { 
            image = Constants.DefaultImage;
            _offset = offset;
        }
   
        public char GetImage() => image;

        public void Display()
        {
            Console.Write(image);
        }

        public virtual void Process()
        {

        }

        protected virtual void MoveFrom(Coordinate from, Coordinate to)
        {
            if (from!=to) {
                Offset = to;
                AssignCellAt(from, new Cell(from));
                UI.BubblesPlayer.Play();
                AssignCellAt(to, this);         
                System.Threading.Thread.Sleep(3000);

            }
        }

        public virtual string ClassName() => "Cell";

        public override string ToString()
        {
            return $"Object type: {ClassName()}\nOffset: {Offset.ToString()}\n";
        }
    }
}
