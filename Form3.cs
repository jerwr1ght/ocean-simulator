using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Practice1draftForm
{
    public partial class Simulation : Form
    {
        private Ocean sim;
        private MainWindow _mw;

        public Ocean Sim
        {
            get => sim;
            set => sim = value;
        }

        public MainWindow MW
        {
            get => _mw;
            set => _mw = value;
        }

        public Simulation(Ocean ocean, MainWindow mw)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Sim = ocean; MW = mw;
            UI.BubblesPlayer = new SoundPlayer(Properties.Resources.BubbleSound);
            int ButtonsWidth = (Constants.BtnWidth + Constants.BtnMargin) * Sim.NumCols ; 
            int ButtonsHeight = (Constants.BtnHeight + Constants.BtnMargin) * Sim.NumRows;
            this.Width = ButtonsWidth + iterInfo_label.Width * 2 + startbtn.Width;
            this.Height = ButtonsHeight + iterInfo_label.Height + startbtn.Height*2; //+ 50;

            foreach (Button btn in Sim.userInterface.board) {
                this.Controls.Add(btn);
                btn.MouseHover += new EventHandler(BoardHover);
            }
            Sim.DisplayCells();

            iterInfo_label.Text = Sim.GetStats(-1);
            iterInfo_label.Top = (ButtonsHeight - iterInfo_label.Height) / 2;
            iterInfo_label.Left = ButtonsWidth + iterInfo_label.Width / 2;
            Sim.userInterface.iterInfo_label = iterInfo_label;

            startbtn.Left = (this.ClientSize.Width - startbtn.Width) / 2;
            startbtn.Top =  ButtonsHeight + startbtn.Height / 2;
            
        }

        public Simulation()
        {
            InitializeComponent();
        }

        private async void startbtn_Click(object sender, EventArgs e)
        {
            startbtn.Text = "Restart";
            startbtn.BackColor = Color.Gray;
            startbtn.Enabled = false;
            await Task.Run(() =>
            {
                Sim.Run();
            });
            startbtn.BackColor = Color.FromArgb(5, 185, 209);
            Sim.Initialize();
            startbtn.Enabled = true;
        }

        protected void BoardHover(object sender, EventArgs e)
        {
            boardTip.Show(Sim.userInterface.GetButtonInfo((Button)sender), (Button) sender);
        }

        private void Simulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            UI.BubblesPlayer.Stop();
            Sim.IsOver = true;
            MW.startbtn_Enable();
            //Sim = null;
        }
    }
}
