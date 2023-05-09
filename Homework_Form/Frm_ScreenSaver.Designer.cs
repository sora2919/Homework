namespace Homework_Form
{
    partial class Frm_ScreenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ScreenSaver));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.picUsa = new System.Windows.Forms.PictureBox();
            this.timerStop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUsa)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // picUsa
            // 
            this.picUsa.Image = ((System.Drawing.Image)(resources.GetObject("picUsa.Image")));
            this.picUsa.Location = new System.Drawing.Point(0, -2);
            this.picUsa.Name = "picUsa";
            this.picUsa.Size = new System.Drawing.Size(201, 270);
            this.picUsa.TabIndex = 0;
            this.picUsa.TabStop = false;
            // 
            // timerStop
            // 
            this.timerStop.Tick += new System.EventHandler(this.timerStop_Tick);
            // 
            // Frm_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picUsa);
            this.Name = "Frm_ScreenSaver";
            this.Text = "Frm_ScreenSaver";
            this.Load += new System.EventHandler(this.Frm_ScreenSaver_Load);
            this.MouseHover += new System.EventHandler(this.Frm_ScreenSaver_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picUsa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picUsa;
        private System.Windows.Forms.Timer timerStop;
    }
}