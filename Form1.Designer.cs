
namespace Practice1draftForm
{
    partial class Loading
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.smallbar = new System.Windows.Forms.Panel();
            this.load_timer = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smallbar
            // 
            this.smallbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.smallbar.Location = new System.Drawing.Point(0, 436);
            this.smallbar.Name = "smallbar";
            this.smallbar.Size = new System.Drawing.Size(108, 14);
            this.smallbar.TabIndex = 2;
            // 
            // load_timer
            // 
            this.load_timer.Enabled = true;
            this.load_timer.Interval = 10;
            this.load_timer.Tick += new System.EventHandler(this.load_timer_Tick);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.logo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.Image = global::Practice1draftForm.Properties.Resources.logomin;
            this.logo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(258, 116);
            this.logo.TabIndex = 0;
            this.logo.Text = "Ocean Simulator";
            this.logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.smallbar);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Panel smallbar;
        public System.Windows.Forms.Timer load_timer;
    }
}

