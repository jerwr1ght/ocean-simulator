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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            // Центруємо лого
            logo.Left = (this.ClientSize.Width - logo.Width) / 2;
            logo.Top = (this.ClientSize.Height - logo.Height) / 2;


            // Змінюємо максимальну кількість рядків та стовпчиків в залежності від роздільної здатності монітору
            Rectangle screen = Screen.FromControl(this).Bounds;
            Constants.MaxCols = (screen.Width / 64) * Constants.BtnWidthPercents / 100;
            Constants.MaxRows = (screen.Height / 64) * Constants.BtnHeightPercents / 100;
        }

        private void load_timer_Tick(object sender, EventArgs e) // Робота із завантаженням
        {
            Panel bar = this.smallbar; Timer timer = this.load_timer;
            bar.Width += 5;
            if (bar.Width >= this.ClientSize.Width)
            {
                MainWindow mw = new MainWindow(this);
                timer.Stop();
                mw.Show();
                this.Hide(); 
            }
        }

    }
}
