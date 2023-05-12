using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1draftForm
{
    public partial class MainWindow : Form
    {
        protected Loading LoadingMenu { get; set; }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadingMenu.Close();
        }


        public MainWindow()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public MainWindow(Loading loadmenu)
        {
            InitializeComponent();
            LoadingMenu = loadmenu;
            startbtn.Left = (this.ClientSize.Width - startbtn.Width) / 2;
            startbtn.Top = this.ClientSize.Height - startbtn.Height * 2;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;

        }


        private void OnlyNum_Press(object sender, KeyPressEventArgs e) // Для полів, де можуть бути тільки числа
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int TextBox_GetNum(TextBox sender) {
            int res;
            if (!int.TryParse(sender.Text, out res))
                return -1;

            return res;
        }

        private void ElementsHover(object sender, EventArgs e)
        {
            string objName = ((Control)sender).Name;
            int tipMinNum = 0, tipMaxNum = 0;

            if (objName.Contains("Rows"))
            {
                tipMinNum = Constants.MinRows;
                tipMaxNum = Constants.MaxRows;
            }
            else if (objName.Contains("Cols"))
            {
                tipMinNum = Constants.MinCols;
                tipMaxNum = Constants.MaxCols;
            }
            else if (objName.Contains("Obstacles"))
            {
                tipMinNum = Constants.MinNumObstacles;
                tipMaxNum = Constants.DefaultNumObstacles;
            }
            else if (objName.Contains("Prey"))
            {
                tipMinNum = Constants.MinNumPrey;
                tipMaxNum = Constants.DefaultNumPrey;
            }
            else if (objName.Contains("Predators"))
            {
                tipMinNum = Constants.MinNumPredators;
                tipMaxNum = Constants.DefaultNumPredators;
            }
            else
            {
                tipMinNum = Constants.MinNumIterations;
                tipMaxNum = Constants.DefaultNumIterations;
            }

            numberTip.Show($"More than or equal {tipMinNum} and less than or equal {tipMaxNum}", (Control) sender);

        }

        public void startbtn_Enable()
        {
            startbtn.BackColor = Color.FromArgb(5, 185, 209);
            startbtn.Enabled = true;
        }

        private void Start(object sender, EventArgs e)
        {
            Ocean MyOcean = new Ocean();

            if (MyOcean.userInterface.TryToSetData(TextBox_GetNum(numRows_textbox),
                TextBox_GetNum(numCols_textbox), (uint) TextBox_GetNum(numObstacles_textbox),
                (uint) TextBox_GetNum(numPrey_textbox), (uint) TextBox_GetNum(numPredators_textbox),
                (uint) TextBox_GetNum(numIterations_textbox), MyOcean.cells))
            {
                MyOcean.Initialize();
                Simulation sim = new Simulation(MyOcean, this);
                startbtn.BackColor = Color.Gray;
                startbtn.Enabled = false;
                //sim.Sim.Initialize();
                sim.Show();
            }
            
        }
    }
}
