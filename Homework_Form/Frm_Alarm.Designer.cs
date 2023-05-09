namespace Homework_Form
{
    partial class Frm_Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Alarm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labNowTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSet = new System.Windows.Forms.CheckBox();
            this.matxtTimeSet = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // labNowTime
            // 
            this.labNowTime.Font = new System.Drawing.Font("Cascadia Code Light", 14F);
            this.labNowTime.Location = new System.Drawing.Point(129, 55);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(350, 37);
            this.labNowTime.TabIndex = 0;
            this.labNowTime.Text = "NowTime";
            this.labNowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSet);
            this.groupBox1.Controls.Add(this.matxtTimeSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // chkSet
            // 
            this.chkSet.AutoSize = true;
            this.chkSet.Location = new System.Drawing.Point(159, 143);
            this.chkSet.Name = "chkSet";
            this.chkSet.Size = new System.Drawing.Size(81, 19);
            this.chkSet.TabIndex = 2;
            this.chkSet.Text = "Set Alarm";
            this.chkSet.UseVisualStyleBackColor = true;
            this.chkSet.CheckedChanged += new System.EventHandler(this.chkSet_CheckedChanged);
            // 
            // matxtTimeSet
            // 
            this.matxtTimeSet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matxtTimeSet.Location = new System.Drawing.Point(126, 90);
            this.matxtTimeSet.Mask = "00時00分00秒";
            this.matxtTimeSet.Name = "matxtTimeSet";
            this.matxtTimeSet.RejectInputOnFirstFailure = true;
            this.matxtTimeSet.Size = new System.Drawing.Size(143, 29);
            this.matxtTimeSet.TabIndex = 1;
            this.matxtTimeSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matxtTimeSet.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alarm Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set your time.";
            // 
            // Frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labNowTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Alarm";
            this.Text = "ALARM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labNowTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox matxtTimeSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSet;
    }
}