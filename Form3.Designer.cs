
namespace Practice1draftForm
{
    partial class Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.startbtn = new System.Windows.Forms.Button();
            this.boardTip = new System.Windows.Forms.ToolTip(this.components);
            this.iterInfo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.startbtn.FlatAppearance.BorderSize = 0;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.startbtn.ForeColor = System.Drawing.Color.White;
            this.startbtn.Location = new System.Drawing.Point(9, 172);
            this.startbtn.Margin = new System.Windows.Forms.Padding(0);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(135, 35);
            this.startbtn.TabIndex = 2;
            this.startbtn.TabStop = false;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // boardTip
            // 
            this.boardTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.boardTip.ForeColor = System.Drawing.Color.White;
            // 
            // iterInfo_label
            // 
            this.iterInfo_label.AutoSize = true;
            this.iterInfo_label.BackColor = System.Drawing.Color.Transparent;
            this.iterInfo_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F);
            this.iterInfo_label.ForeColor = System.Drawing.Color.White;
            this.iterInfo_label.Location = new System.Drawing.Point(12, 324);
            this.iterInfo_label.Name = "iterInfo_label";
            this.iterInfo_label.Size = new System.Drawing.Size(170, 33);
            this.iterInfo_label.TabIndex = 3;
            this.iterInfo_label.Text = "Iteration Info";
            this.iterInfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.BackgroundImage = global::Practice1draftForm.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iterInfo_label);
            this.Controls.Add(this.startbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.ToolTip boardTip;
        private System.Windows.Forms.Label iterInfo_label;
    }
}