namespace Homework
{
    partial class Frm_MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainForm));
            this.splTop = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splLeft = new System.Windows.Forms.SplitContainer();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnOXGame = new System.Windows.Forms.Button();
            this.btnPictureViewer = new System.Windows.Forms.Button();
            this.btnScreen_Saver = new System.Windows.Forms.Button();
            this.btnForDoWhile = new System.Windows.Forms.Button();
            this.btnMyClac = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnStudent_Grade = new System.Windows.Forms.Button();
            this.btnStudent_Struct = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splTop)).BeginInit();
            this.splTop.Panel1.SuspendLayout();
            this.splTop.Panel2.SuspendLayout();
            this.splTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splLeft)).BeginInit();
            this.splLeft.Panel1.SuspendLayout();
            this.splLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // splTop
            // 
            this.splTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splTop.Location = new System.Drawing.Point(0, 0);
            this.splTop.Name = "splTop";
            this.splTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splTop.Panel1
            // 
            this.splTop.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splTop.Panel1.BackgroundImage")));
            this.splTop.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splTop.Panel1.Controls.Add(this.label1);
            // 
            // splTop.Panel2
            // 
            this.splTop.Panel2.Controls.Add(this.splLeft);
            this.splTop.Size = new System.Drawing.Size(1050, 561);
            this.splTop.SplitterDistance = 80;
            this.splTop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "C#作業";
            // 
            // splLeft
            // 
            this.splLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splLeft.Location = new System.Drawing.Point(0, 0);
            this.splLeft.Name = "splLeft";
            // 
            // splLeft.Panel1
            // 
            this.splLeft.Panel1.AutoScroll = true;
            this.splLeft.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splLeft.Panel1.BackgroundImage")));
            this.splLeft.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splLeft.Panel1.Controls.Add(this.btnAlarm);
            this.splLeft.Panel1.Controls.Add(this.btnOXGame);
            this.splLeft.Panel1.Controls.Add(this.btnPictureViewer);
            this.splLeft.Panel1.Controls.Add(this.btnScreen_Saver);
            this.splLeft.Panel1.Controls.Add(this.btnForDoWhile);
            this.splLeft.Panel1.Controls.Add(this.btnMyClac);
            this.splLeft.Panel1.Controls.Add(this.btnMethod);
            this.splLeft.Panel1.Controls.Add(this.btnStudent_Grade);
            this.splLeft.Panel1.Controls.Add(this.btnStudent_Struct);
            this.splLeft.Panel1.Controls.Add(this.btnPOS);
            this.splLeft.Panel1.Controls.Add(this.btnLoan);
            this.splLeft.Panel1.Controls.Add(this.btnHello);
            // 
            // splLeft.Panel2
            // 
            this.splLeft.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splLeft.Panel2.BackgroundImage")));
            this.splLeft.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splLeft.Size = new System.Drawing.Size(1050, 477);
            this.splLeft.SplitterDistance = 296;
            this.splLeft.TabIndex = 0;
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.Transparent;
            this.btnAlarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlarm.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAlarm.Location = new System.Drawing.Point(0, 275);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(296, 25);
            this.btnAlarm.TabIndex = 14;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnOXGame
            // 
            this.btnOXGame.BackColor = System.Drawing.Color.Transparent;
            this.btnOXGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOXGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOXGame.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOXGame.Location = new System.Drawing.Point(0, 250);
            this.btnOXGame.Name = "btnOXGame";
            this.btnOXGame.Size = new System.Drawing.Size(296, 25);
            this.btnOXGame.TabIndex = 13;
            this.btnOXGame.Text = "OX GAME";
            this.btnOXGame.UseVisualStyleBackColor = false;
            this.btnOXGame.Click += new System.EventHandler(this.btnOXGame_Click);
            // 
            // btnPictureViewer
            // 
            this.btnPictureViewer.BackColor = System.Drawing.Color.Transparent;
            this.btnPictureViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPictureViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPictureViewer.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPictureViewer.Location = new System.Drawing.Point(0, 225);
            this.btnPictureViewer.Name = "btnPictureViewer";
            this.btnPictureViewer.Size = new System.Drawing.Size(296, 25);
            this.btnPictureViewer.TabIndex = 12;
            this.btnPictureViewer.Text = "PictureViewer";
            this.btnPictureViewer.UseVisualStyleBackColor = false;
            this.btnPictureViewer.Click += new System.EventHandler(this.btnPictureViewer_Click);
            // 
            // btnScreen_Saver
            // 
            this.btnScreen_Saver.BackColor = System.Drawing.Color.Transparent;
            this.btnScreen_Saver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreen_Saver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScreen_Saver.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnScreen_Saver.Location = new System.Drawing.Point(0, 200);
            this.btnScreen_Saver.Name = "btnScreen_Saver";
            this.btnScreen_Saver.Size = new System.Drawing.Size(296, 25);
            this.btnScreen_Saver.TabIndex = 9;
            this.btnScreen_Saver.Text = "Screen Saver";
            this.btnScreen_Saver.UseVisualStyleBackColor = false;
            this.btnScreen_Saver.Click += new System.EventHandler(this.btnScreen_Saver_Click);
            // 
            // btnForDoWhile
            // 
            this.btnForDoWhile.BackColor = System.Drawing.Color.Transparent;
            this.btnForDoWhile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForDoWhile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnForDoWhile.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForDoWhile.Location = new System.Drawing.Point(0, 175);
            this.btnForDoWhile.Name = "btnForDoWhile";
            this.btnForDoWhile.Size = new System.Drawing.Size(296, 25);
            this.btnForDoWhile.TabIndex = 8;
            this.btnForDoWhile.Text = "ForDoWhile";
            this.btnForDoWhile.UseVisualStyleBackColor = false;
            this.btnForDoWhile.Click += new System.EventHandler(this.btnForDoWhile_Click);
            // 
            // btnMyClac
            // 
            this.btnMyClac.BackColor = System.Drawing.Color.Transparent;
            this.btnMyClac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyClac.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMyClac.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMyClac.Location = new System.Drawing.Point(0, 150);
            this.btnMyClac.Name = "btnMyClac";
            this.btnMyClac.Size = new System.Drawing.Size(296, 25);
            this.btnMyClac.TabIndex = 7;
            this.btnMyClac.Text = "MyClac";
            this.btnMyClac.UseVisualStyleBackColor = false;
            this.btnMyClac.Click += new System.EventHandler(this.btnMyClac_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.BackColor = System.Drawing.Color.Transparent;
            this.btnMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMethod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMethod.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMethod.Location = new System.Drawing.Point(0, 125);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(296, 25);
            this.btnMethod.TabIndex = 6;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = false;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnStudent_Grade
            // 
            this.btnStudent_Grade.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent_Grade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent_Grade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStudent_Grade.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudent_Grade.Location = new System.Drawing.Point(0, 100);
            this.btnStudent_Grade.Name = "btnStudent_Grade";
            this.btnStudent_Grade.Size = new System.Drawing.Size(296, 25);
            this.btnStudent_Grade.TabIndex = 4;
            this.btnStudent_Grade.Text = "Student_Grade";
            this.btnStudent_Grade.UseVisualStyleBackColor = false;
            this.btnStudent_Grade.Click += new System.EventHandler(this.btnStudent_Grade_Click);
            // 
            // btnStudent_Struct
            // 
            this.btnStudent_Struct.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent_Struct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent_Struct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStudent_Struct.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudent_Struct.Location = new System.Drawing.Point(0, 75);
            this.btnStudent_Struct.Name = "btnStudent_Struct";
            this.btnStudent_Struct.Size = new System.Drawing.Size(296, 25);
            this.btnStudent_Struct.TabIndex = 3;
            this.btnStudent_Struct.Text = "Student_Struct";
            this.btnStudent_Struct.UseVisualStyleBackColor = false;
            this.btnStudent_Struct.Click += new System.EventHandler(this.btnStudent_Struct_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.Transparent;
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPOS.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPOS.Location = new System.Drawing.Point(0, 50);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(296, 25);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.BackColor = System.Drawing.Color.Transparent;
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoan.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoan.Location = new System.Drawing.Point(0, 25);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(296, 25);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.Transparent;
            this.btnHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHello.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(0, 0);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(296, 25);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.splTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MainForm";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splTop.Panel1.ResumeLayout(false);
            this.splTop.Panel1.PerformLayout();
            this.splTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splTop)).EndInit();
            this.splTop.ResumeLayout(false);
            this.splLeft.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splLeft)).EndInit();
            this.splLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splTop;
        private System.Windows.Forms.SplitContainer splLeft;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnStudent_Grade;
        private System.Windows.Forms.Button btnStudent_Struct;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnOXGame;
        private System.Windows.Forms.Button btnPictureViewer;
        private System.Windows.Forms.Button btnScreen_Saver;
        private System.Windows.Forms.Button btnForDoWhile;
        private System.Windows.Forms.Button btnMyClac;
        private System.Windows.Forms.Label label1;
    }
}

