using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Practice1draftForm
{
    public class Ocean
    {
        private int _numRows;
        private int _numCols;
        private uint _numIterations;
        private int _size;
        private uint _numPrey;
        private uint _numPredators;
        private uint _numObstacles;
        private bool _isOver;

        public uint NumPrey 
        {
            get { return _numPrey; }
            set { _numPrey = value; }
        }

        public uint NumPredators
        {
            get { return _numPredators; }
            set { _numPredators = value; }
        }

        public int NumCols
        {
            get { return _numCols; }
            set { _numCols = value; }
        }
        public int NumRows
        {
            get { return _numRows; }
            set { _numRows = value; }
        }

        public uint NumObstacles
        {
            get { return _numObstacles; }
            set { _numObstacles = value; }
        }

        public bool IsOver
        {
            get => _isOver;
            set => _isOver = value;
        }


        public Random random = new Random();
        public Cell[,] cells = new Cell[Constants.MaxRows, Constants.MaxCols];
        public UI userInterface = new UI();

        public void Initialize()
        {
            _numCols = userInterface.numCols;
            _numRows = userInterface.numRows;
            _size = _numRows * _numCols;
            _numObstacles = userInterface.numObstacles;
            _numPredators = userInterface.numPredators;
            _numPrey = userInterface.numPrey;
            cells = new Cell[_numRows, _numCols];
            _numIterations = userInterface.numIterations;
            _isOver = false;

            InitCells();
            userInterface.cells = cells; // Для праці з інтерфейосм
        }
        private void InitCells()
        {
            AddEmptyCells();
            AddObstacles();
            AddPredators();
            AddPrey();

            Cell.Ocean1 = this;
        }

        private void AddEmptyCells()
        {
            for (uint row = 0; row < _numRows; row++)
            {
                for (uint col = 0; col < _numCols; col++)
                {
                    cells[row, col] = new Cell(new Coordinate(row, col));
                }
            }

        }

        private void AddObstacles()
        {
            Coordinate empty;
            for (int count = 0; count < _numObstacles; count++)
            {
                empty = GetEmptyCellCoord();
                cells[empty.Y, empty.X] = new Obstacle(empty);
            }
        }

        private void AddPredators()
        {
            Coordinate empty;
            for (int count = 0; count < _numPredators; count++)
            {
                empty = GetEmptyCellCoord();
                cells[empty.Y, empty.X] = new Predator(empty, Constants.TimeToReproduce);
            }
        }

        private void AddPrey()
        {
            Coordinate empty;
            for (int count = 0; count < _numPrey; count++)
            {
                empty = GetEmptyCellCoord();
                cells[empty.Y, empty.X] = new Prey(empty, Constants.TimeToReproduce);
            }
        }

        Coordinate GetEmptyCellCoord()
        {
            uint x, y;
            Coordinate empty = new Coordinate();

            for (int i = 0; i < _size; i++)
            {
                x = (uint)random.Next(0, (int)_numCols);
                y = (uint)random.Next(0, (int)_numRows);
                if (cells[y, x].GetImage() == Constants.DefaultImage)
                {
                    empty.X = x;
                    empty.Y = y;
                    break;
                }
            }

            return empty;
        }

        public Coordinate GetEmptyNeighborCoord(Coordinate offset)
        {
            Cell prey = new Cell(offset);
            return prey.GetNeighborWitghImage(Constants.DefaultImage).Offset;
        }

        public Coordinate GetPreyNeighborCoord(Coordinate offset)
        {
            Cell prey = new Cell(offset);
            return prey.GetNeighborWitghImage(Constants.DefaultPreyImage).Offset;
        }

        public void DisplayCells()
        {
            for (uint row = 0; row < _numRows; row++)
            {
                for (uint col = 0; col < _numCols; col++)
                {
                    userInterface.board[row, col].Image = userInterface.GetButtonImage(cells[row, col].image);
                    userInterface.board[row, col].Name = cells[row, col].Offset.ToString();
                }
            }
        }

        public string GetStats(int iteration)
        {
            string stats = $"\nIteration number: {iteration + 1}";
            stats += $"\nObstacles: {NumObstacles}";
            stats += $"\nPredators: {NumPredators}";
            stats += $"\nPrey: {NumPrey}";
            return stats;
        }

 
        public void Run()
        {
            for (int iteration = 0; iteration < _numIterations && !IsOver; iteration++)
            {
                //userInterface.iterInfo_label.Text = GetStats(iteration);
                for (uint row = 0; row < _numRows; row++)
                {
                    for (uint col = 0; col < _numCols; col++)
                    {
                        cells[row, col].Processed=false;
                    }
                }

                //DisplayStats(iteration);
                Label iterInfo_label = userInterface.iterInfo_label;
                //System.Threading.Thread.Sleep(1000);
                if ( NumPredators > 0 && NumPrey > 0  && !IsOver)
                {
                    for (uint row = 0; row < NumRows && !IsOver; row++)
                    {
                        for (uint col = 0; col < NumCols && !IsOver; col++)
                        {   
                            cells[row, col].Process();
                            DisplayCells();


                            if (iterInfo_label.InvokeRequired)
                                iterInfo_label.Invoke((MethodInvoker)delegate { iterInfo_label.Text = GetStats(iteration); });
                            else
                                iterInfo_label.Text = GetStats(iteration);

                            //MessageBox.Show($"{IsOver}");
                            System.Threading.Thread.Sleep(Constants.SleepingTime);  

                        }
                    }
                }
                else
                {
                    break;
                }
                
                /*if (iterInfo_label.InvokeRequired)
                    iterInfo_label.Invoke((MethodInvoker)delegate { iterInfo_label.Text = GetStats(iteration); });
                else
                    iterInfo_label.Text = GetStats(iteration);*/
            }
            if (!IsOver)
                MessageBox.Show("End of Simulation! Results are in the label...", "Results Info");
        }

        //public Ocean(UI ui) => userInterface = ui;

    }
}
