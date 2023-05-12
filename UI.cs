using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Practice1draftForm
{
    public class UI
    {
        public int numRows;
        public int numCols;
        public uint numIterations;
        public int size;
        public uint numPrey;
        public Rectangle screen;

        public uint numPredators { get; set; }
        public uint numObstacles;

        public Button[,] board; // Кнопки з зображенням клітинок
        public Cell[,] cells; // Клітинки
        public Label iterInfo_label; // Інформація про ітерацію
        private static SoundPlayer _bubblesPlayer; // Звук бульбашок

        public static SoundPlayer BubblesPlayer
        {
            get => _bubblesPlayer;
            set => _bubblesPlayer = value;
        }

        private bool IsNumLimitsError(string name, int num, int min, int max)
        {
            if (num >= min && num <= max)
                return false;

            MessageBox.Show($"Your number in \"{name}\" is less than {min} or greater than {max}", "Number Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            return true;
        }

        public bool TryToSetData(int tb_numRows, int tb_numCols, 
            uint tb_numObstacles, uint tb_numPrey, 
            uint tb_numPredators, uint tb_numIterations, 
            Cell[,] cells)
        {

            if (IsNumLimitsError("Number of Rows", tb_numRows, Constants.MinRows, Constants.MaxRows))
                return false;        
            numRows = tb_numRows;

            if (IsNumLimitsError("Number of Cols", tb_numCols, Constants.MinCols, Constants.MaxCols))
                return false;
            numCols = tb_numCols;

            size = numRows * numCols;

            if (IsNumLimitsError("Number of Obstacles", (int) tb_numObstacles, 0, Constants.DefaultNumObstacles))
                return false;
            numObstacles = tb_numObstacles;

            if (IsNumLimitsError("Number of Prey", (int) tb_numPrey, 0, Constants.DefaultNumPrey))
                return false;
            numPrey = tb_numPrey;

            if (IsNumLimitsError("Number of Predators", (int)tb_numPredators, 0, Constants.DefaultNumPredators))
                return false;
            numPredators = tb_numPredators;

            if (IsNumLimitsError("Number of Iterations", (int)tb_numIterations, 1, Constants.DefaultNumIterations))
                return false;
            numIterations = tb_numIterations;

            SetBoard();

            this.cells = cells;

            return true;
        }

        private void SetBoard()
        {
            board = new Button[numRows, numCols];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Button btn = new Button();
                    btn.AutoSize = false;
                    btn.Size = new Size(Constants.BtnWidth, Constants.BtnHeight);
                    btn.Location = new Point(j *(Constants.BtnWidth + Constants.BtnPadding), i * (Constants.BtnHeight + Constants.BtnPadding));
                    btn.Left = btn.Location.X + Constants.BtnMargin;
                    btn.Top = btn.Location.Y + Constants.BtnMargin;

                    //btn.Image = Image.FromFile("E:\\c# coding\\Practice1draftForm\\logomin.png");
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btn.BackColor = Color.Transparent;
                    btn.TabStop = false;

                    //btn.BackColor = Color.White;
                    //btn.FlatAppearance.BorderColor = Color.FromArgb(5, 185, 209);
                    board[i, j] = btn;
                }
            }

        }

        public Bitmap GetButtonImage(char image)
        {
            switch (image)
            {
                case Constants.ObstacleImage:
                    return Properties.Resources.obstacle;
                case Constants.DefaultPreyImage:
                    return Properties.Resources.prey;
                case Constants.DefaultPredImage:
                    return Properties.Resources.predator;
                default:
                    return Properties.Resources.logomin;
            }
        }

        public Cell GetButtonCell(Button btn)
        {
            foreach (Cell item in cells)
            {
                if (item.Offset.ToString() == btn.Name)
                    return item;
            }

            return null;
        }

        public string GetButtonInfo(Button btn)
        {
            return !(GetButtonCell(btn) is null) ? GetButtonCell(btn).ToString() : "None";
        }


    }
}
