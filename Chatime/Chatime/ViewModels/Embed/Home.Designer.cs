namespace Chatime.ViewModels.Embed
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SliderBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SliderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SliderBox
            // 
            this.SliderBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SliderBox.Location = new System.Drawing.Point(0, 0);
            this.SliderBox.Name = "SliderBox";
            this.SliderBox.Size = new System.Drawing.Size(662, 354);
            this.SliderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SliderBox.TabIndex = 0;
            this.SliderBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SliderBox);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(662, 354);
            ((System.ComponentModel.ISupportInitialize)(this.SliderBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox SliderBox;
    }
}
