namespace Homework_Form
{
    partial class Frm_Student_Grade
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtxtShow = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScoreChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreEng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScoreMath = new System.Windows.Forms.TextBox();
            this.btnAddInput = new System.Windows.Forms.Button();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.btnSumUp = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtxtAll = new System.Windows.Forms.RichTextBox();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(65, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 29);
            this.txtName.TabIndex = 2;
            // 
            // rtxtShow
            // 
            this.rtxtShow.Location = new System.Drawing.Point(208, 16);
            this.rtxtShow.Name = "rtxtShow";
            this.rtxtShow.Size = new System.Drawing.Size(652, 349);
            this.rtxtShow.TabIndex = 3;
            this.rtxtShow.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文：";
            // 
            // txtScoreChi
            // 
            this.txtScoreChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreChi.Location = new System.Drawing.Point(65, 81);
            this.txtScoreChi.Name = "txtScoreChi";
            this.txtScoreChi.Size = new System.Drawing.Size(114, 29);
            this.txtScoreChi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "英文：";
            // 
            // txtScoreEng
            // 
            this.txtScoreEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreEng.Location = new System.Drawing.Point(65, 135);
            this.txtScoreEng.Name = "txtScoreEng";
            this.txtScoreEng.Size = new System.Drawing.Size(114, 29);
            this.txtScoreEng.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "數學：";
            // 
            // txtScoreMath
            // 
            this.txtScoreMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreMath.Location = new System.Drawing.Point(65, 189);
            this.txtScoreMath.Name = "txtScoreMath";
            this.txtScoreMath.Size = new System.Drawing.Size(114, 29);
            this.txtScoreMath.TabIndex = 2;
            // 
            // btnAddInput
            // 
            this.btnAddInput.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddInput.Location = new System.Drawing.Point(29, 248);
            this.btnAddInput.Name = "btnAddInput";
            this.btnAddInput.Size = new System.Drawing.Size(140, 33);
            this.btnAddInput.TabIndex = 4;
            this.btnAddInput.Text = "加入學生資料";
            this.btnAddInput.UseVisualStyleBackColor = true;
            this.btnAddInput.Click += new System.EventHandler(this.btnAddInput_Click);
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRandom.Location = new System.Drawing.Point(29, 287);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(140, 33);
            this.btnAddRandom.TabIndex = 4;
            this.btnAddRandom.Text = "隨機儲存資料";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            this.btnAddRandom.Click += new System.EventHandler(this.btnAddRandom_Click);
            // 
            // btnSumUp
            // 
            this.btnSumUp.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSumUp.Location = new System.Drawing.Point(29, 326);
            this.btnSumUp.Name = "btnSumUp";
            this.btnSumUp.Size = new System.Drawing.Size(140, 33);
            this.btnSumUp.TabIndex = 4;
            this.btnSumUp.Text = "各科統計";
            this.btnSumUp.UseVisualStyleBackColor = true;
            this.btnSumUp.Click += new System.EventHandler(this.btnSumUp_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(29, 435);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtxtAll
            // 
            this.rtxtAll.Location = new System.Drawing.Point(208, 371);
            this.rtxtAll.Name = "rtxtAll";
            this.rtxtAll.Size = new System.Drawing.Size(652, 153);
            this.rtxtAll.TabIndex = 3;
            this.rtxtAll.Text = "";
            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20.Location = new System.Drawing.Point(29, 474);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(140, 33);
            this.btnRandom20.TabIndex = 4;
            this.btnRandom20.Text = "隨機加入20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // Frm_Student_Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 536);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtScoreChi);
            this.Controls.Add(this.txtScoreEng);
            this.Controls.Add(this.txtScoreMath);
            this.Controls.Add(this.btnAddInput);
            this.Controls.Add(this.btnAddRandom);
            this.Controls.Add(this.btnSumUp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.rtxtAll);
            this.Controls.Add(this.rtxtShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Student_Grade";
            this.Text = "btnStudent_Grade";
            this.Load += new System.EventHandler(this.Frm_Student_Grade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtxtShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScoreChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreEng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScoreMath;
        private System.Windows.Forms.Button btnAddInput;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.Button btnSumUp;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox rtxtAll;
        private System.Windows.Forms.Button btnRandom20;
    }
}