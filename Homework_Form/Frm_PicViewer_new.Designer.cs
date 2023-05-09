namespace Homework_Form
{
    partial class Frm_PicViewer_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PicViewer_new));
            this.newShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newShow)).BeginInit();
            this.SuspendLayout();
            // 
            // newShow
            // 
            this.newShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newShow.Location = new System.Drawing.Point(0, 0);
            this.newShow.Name = "newShow";
            this.newShow.Size = new System.Drawing.Size(800, 529);
            this.newShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newShow.TabIndex = 0;
            this.newShow.TabStop = false;
            // 
            // Frm_PicViewer_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.newShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PicViewer_new";
            this.Text = "Frm_PicViewer_new";
            ((System.ComponentModel.ISupportInitialize)(this.newShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox newShow;
    }
}