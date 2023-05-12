
namespace Practice1draftForm
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.startbtn = new System.Windows.Forms.Button();
            this.numRows_label = new System.Windows.Forms.Label();
            this.numRows_textbox = new System.Windows.Forms.TextBox();
            this.numCols_textbox = new System.Windows.Forms.TextBox();
            this.numCols_label = new System.Windows.Forms.Label();
            this.numObstacles_textbox = new System.Windows.Forms.TextBox();
            this.numObstacles_label = new System.Windows.Forms.Label();
            this.numPrey_textbox = new System.Windows.Forms.TextBox();
            this.numPrey_label = new System.Windows.Forms.Label();
            this.numPredators_textbox = new System.Windows.Forms.TextBox();
            this.numPredators_label = new System.Windows.Forms.Label();
            this.numIterations_textbox = new System.Windows.Forms.TextBox();
            this.numIterations_label = new System.Windows.Forms.Label();
            this.numberTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.startbtn.FlatAppearance.BorderSize = 0;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.startbtn.ForeColor = System.Drawing.Color.White;
            this.startbtn.Location = new System.Drawing.Point(16, 167);
            this.startbtn.Margin = new System.Windows.Forms.Padding(0);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(200, 35);
            this.startbtn.TabIndex = 1;
            this.startbtn.TabStop = false;
            this.startbtn.Text = "Create Simulation";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.Start);
            // 
            // numRows_label
            // 
            this.numRows_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numRows_label.ForeColor = System.Drawing.Color.White;
            this.numRows_label.Location = new System.Drawing.Point(12, 36);
            this.numRows_label.Name = "numRows_label";
            this.numRows_label.Size = new System.Drawing.Size(163, 28);
            this.numRows_label.TabIndex = 3;
            this.numRows_label.Text = "Number of Rows";
            this.numRows_label.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numRows_textbox
            // 
            this.numRows_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.numRows_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numRows_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numRows_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.numRows_textbox.HideSelection = false;
            this.numRows_textbox.Location = new System.Drawing.Point(181, 36);
            this.numRows_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.numRows_textbox.MaxLength = 2;
            this.numRows_textbox.Name = "numRows_textbox";
            this.numRows_textbox.Size = new System.Drawing.Size(40, 25);
            this.numRows_textbox.TabIndex = 4;
            this.numRows_textbox.TabStop = false;
            this.numRows_textbox.Tag = "";
            this.numRows_textbox.Text = "4";
            this.numRows_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRows_textbox.WordWrap = false;
            this.numRows_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_Press);
            this.numRows_textbox.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numCols_textbox
            // 
            this.numCols_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.numCols_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCols_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numCols_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.numCols_textbox.HideSelection = false;
            this.numCols_textbox.Location = new System.Drawing.Point(449, 36);
            this.numCols_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.numCols_textbox.MaxLength = 2;
            this.numCols_textbox.Name = "numCols_textbox";
            this.numCols_textbox.Size = new System.Drawing.Size(40, 25);
            this.numCols_textbox.TabIndex = 6;
            this.numCols_textbox.TabStop = false;
            this.numCols_textbox.Tag = "";
            this.numCols_textbox.Text = "4";
            this.numCols_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCols_textbox.WordWrap = false;
            this.numCols_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_Press);
            this.numCols_textbox.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numCols_label
            // 
            this.numCols_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numCols_label.ForeColor = System.Drawing.Color.White;
            this.numCols_label.Location = new System.Drawing.Point(295, 36);
            this.numCols_label.Name = "numCols_label";
            this.numCols_label.Size = new System.Drawing.Size(151, 28);
            this.numCols_label.TabIndex = 5;
            this.numCols_label.Text = "Number of Cols";
            this.numCols_label.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numObstacles_textbox
            // 
            this.numObstacles_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.numObstacles_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numObstacles_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numObstacles_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.numObstacles_textbox.HideSelection = false;
            this.numObstacles_textbox.Location = new System.Drawing.Point(748, 36);
            this.numObstacles_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.numObstacles_textbox.MaxLength = 2;
            this.numObstacles_textbox.Name = "numObstacles_textbox";
            this.numObstacles_textbox.Size = new System.Drawing.Size(40, 25);
            this.numObstacles_textbox.TabIndex = 8;
            this.numObstacles_textbox.TabStop = false;
            this.numObstacles_textbox.Tag = "";
            this.numObstacles_textbox.Text = "3";
            this.numObstacles_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numObstacles_textbox.WordWrap = false;
            this.numObstacles_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_Press);
            this.numObstacles_textbox.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numObstacles_label
            // 
            this.numObstacles_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numObstacles_label.ForeColor = System.Drawing.Color.White;
            this.numObstacles_label.Location = new System.Drawing.Point(546, 36);
            this.numObstacles_label.Name = "numObstacles_label";
            this.numObstacles_label.Size = new System.Drawing.Size(199, 28);
            this.numObstacles_label.TabIndex = 7;
            this.numObstacles_label.Text = "Number of Obstacles";
            this.numObstacles_label.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numPrey_textbox
            // 
            this.numPrey_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.numPrey_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrey_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numPrey_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.numPrey_textbox.HideSelection = false;
            this.numPrey_textbox.Location = new System.Drawing.Point(181, 106);
            this.numPrey_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.numPrey_textbox.MaxLength = 3;
            this.numPrey_textbox.Name = "numPrey_textbox";
            this.numPrey_textbox.Size = new System.Drawing.Size(40, 25);
            this.numPrey_textbox.TabIndex = 10;
            this.numPrey_textbox.TabStop = false;
            this.numPrey_textbox.Tag = "";
            this.numPrey_textbox.Text = "3";
            this.numPrey_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPrey_textbox.WordWrap = false;
            this.numPrey_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_Press);
            this.numPrey_textbox.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numPrey_label
            // 
            this.numPrey_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numPrey_label.ForeColor = System.Drawing.Color.White;
            this.numPrey_label.Location = new System.Drawing.Point(12, 106);
            this.numPrey_label.Name = "numPrey_label";
            this.numPrey_label.Size = new System.Drawing.Size(163, 28);
            this.numPrey_label.TabIndex = 9;
            this.numPrey_label.Text = "Number of Prey";
            this.numPrey_label.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numPredators_textbox
            // 
            this.numPredators_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.numPredators_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPredators_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numPredators_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.numPredators_textbox.HideSelection = false;
            this.numPredators_textbox.Location = new System.Drawing.Point(464, 106);
            this.numPredators_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.numPredators_textbox.MaxLength = 3;
            this.numPredators_textbox.Name = "numPredators_textbox";
            this.numPredators_textbox.Size = new System.Drawing.Size(40, 25);
            this.numPredators_textbox.TabIndex = 12;
            this.numPredators_textbox.TabStop = false;
            this.numPredators_textbox.Tag = "";
            this.numPredators_textbox.Text = "3";
            this.numPredators_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPredators_textbox.WordWrap = false;
            this.numPredators_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_Press);
            this.numPredators_textbox.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numPredators_label
            // 
            this.numPredators_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numPredators_label.ForeColor = System.Drawing.Color.White;
            this.numPredators_label.Location = new System.Drawing.Point(257, 106);
            this.numPredators_label.Name = "numPredators_label";
            this.numPredators_label.Size = new System.Drawing.Size(204, 28);
            this.numPredators_label.TabIndex = 11;
            this.numPredators_label.Text = "Number of Predators";
            this.numPredators_label.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numIterations_textbox
            // 
            this.numIterations_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.numIterations_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numIterations_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numIterations_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.numIterations_textbox.HideSelection = false;
            this.numIterations_textbox.Location = new System.Drawing.Point(740, 106);
            this.numIterations_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.numIterations_textbox.MaxLength = 4;
            this.numIterations_textbox.Name = "numIterations_textbox";
            this.numIterations_textbox.Size = new System.Drawing.Size(50, 25);
            this.numIterations_textbox.TabIndex = 14;
            this.numIterations_textbox.TabStop = false;
            this.numIterations_textbox.Tag = "";
            this.numIterations_textbox.Text = "5";
            this.numIterations_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIterations_textbox.WordWrap = false;
            this.numIterations_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_Press);
            this.numIterations_textbox.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // numIterations_label
            // 
            this.numIterations_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.numIterations_label.ForeColor = System.Drawing.Color.White;
            this.numIterations_label.Location = new System.Drawing.Point(533, 106);
            this.numIterations_label.Name = "numIterations_label";
            this.numIterations_label.Size = new System.Drawing.Size(204, 28);
            this.numIterations_label.TabIndex = 13;
            this.numIterations_label.Text = "Number of Iterations";
            this.numIterations_label.MouseHover += new System.EventHandler(this.ElementsHover);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(800, 239);
            this.Controls.Add(this.numIterations_textbox);
            this.Controls.Add(this.numIterations_label);
            this.Controls.Add(this.numPredators_textbox);
            this.Controls.Add(this.numPredators_label);
            this.Controls.Add(this.numPrey_textbox);
            this.Controls.Add(this.numPrey_label);
            this.Controls.Add(this.numObstacles_textbox);
            this.Controls.Add(this.numObstacles_label);
            this.Controls.Add(this.numCols_textbox);
            this.Controls.Add(this.numCols_label);
            this.Controls.Add(this.numRows_textbox);
            this.Controls.Add(this.numRows_label);
            this.Controls.Add(this.startbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocean Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label numRows_label;
        private System.Windows.Forms.TextBox numRows_textbox;
        private System.Windows.Forms.TextBox numCols_textbox;
        private System.Windows.Forms.Label numCols_label;
        private System.Windows.Forms.TextBox numObstacles_textbox;
        private System.Windows.Forms.Label numObstacles_label;
        private System.Windows.Forms.TextBox numPrey_textbox;
        private System.Windows.Forms.Label numPrey_label;
        private System.Windows.Forms.TextBox numPredators_textbox;
        private System.Windows.Forms.Label numPredators_label;
        private System.Windows.Forms.TextBox numIterations_textbox;
        private System.Windows.Forms.Label numIterations_label;
        private System.Windows.Forms.ToolTip numberTip;
    }
}