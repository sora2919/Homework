namespace Homework_Form
{
    partial class Frm_Methods
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
            this.labShow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnHonManyC = new System.Windows.Forms.Button();
            this.btnLongestName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btn101010 = new System.Windows.Forms.Button();
            this.btnArrayMaxMin = new System.Windows.Forms.Button();
            this.btnHowManyOddEven = new System.Windows.Forms.Button();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(140, 290);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(41, 20);
            this.labShow.TabIndex = 0;
            this.labShow.Text = "結果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "輸入隨意整數：";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(130, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 29);
            this.txtNum.TabIndex = 2;
            // 
            // btnHonManyC
            // 
            this.btnHonManyC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHonManyC.Location = new System.Drawing.Point(16, 195);
            this.btnHonManyC.Name = "btnHonManyC";
            this.btnHonManyC.Size = new System.Drawing.Size(214, 32);
            this.btnHonManyC.TabIndex = 3;
            this.btnHonManyC.Text = "陣列內的文字含有C或c的字有幾個";
            this.btnHonManyC.UseVisualStyleBackColor = true;
            this.btnHonManyC.Click += new System.EventHandler(this.btnHonManyC_Click);
            // 
            // btnLongestName
            // 
            this.btnLongestName.Location = new System.Drawing.Point(16, 239);
            this.btnLongestName.Name = "btnLongestName";
            this.btnLongestName.Size = new System.Drawing.Size(214, 32);
            this.btnLongestName.TabIndex = 3;
            this.btnLongestName.Text = "陣列內最長的名字是誰";
            this.btnLongestName.UseVisualStyleBackColor = true;
            this.btnLongestName.Click += new System.EventHandler(this.btnLongestName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(309, 107);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(214, 32);
            this.btn10.TabIndex = 3;
            this.btn10.Text = "[10,10]二維陣列-邊1、內0";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(309, 152);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(214, 32);
            this.btn01.TabIndex = 3;
            this.btn01.Text = "[10,10]二維陣列-邊0、內1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(601, 47);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(214, 32);
            this.btnSwap.TabIndex = 3;
            this.btnSwap.Text = "SWAP[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(601, 131);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(214, 32);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Sum陣列";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(601, 186);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(214, 32);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Max陣列";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(601, 241);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(214, 32);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Min陣列";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btn101010
            // 
            this.btn101010.Location = new System.Drawing.Point(309, 197);
            this.btn101010.Name = "btn101010";
            this.btn101010.Size = new System.Drawing.Size(214, 76);
            this.btn101010.TabIndex = 3;
            this.btn101010.Text = "[10,10]二維陣列\r\n1010101\r\n0101010\r\n1010101\r\n0101010";
            this.btn101010.UseVisualStyleBackColor = true;
            this.btn101010.Click += new System.EventHandler(this.btn101010_Click);
            // 
            // btnArrayMaxMin
            // 
            this.btnArrayMaxMin.Location = new System.Drawing.Point(16, 151);
            this.btnArrayMaxMin.Name = "btnArrayMaxMin";
            this.btnArrayMaxMin.Size = new System.Drawing.Size(214, 32);
            this.btnArrayMaxMin.TabIndex = 3;
            this.btnArrayMaxMin.Text = "陣列最大值/最小值";
            this.btnArrayMaxMin.UseVisualStyleBackColor = true;
            this.btnArrayMaxMin.Click += new System.EventHandler(this.btnArrayMaxMin_Click);
            // 
            // btnHowManyOddEven
            // 
            this.btnHowManyOddEven.Location = new System.Drawing.Point(16, 107);
            this.btnHowManyOddEven.Name = "btnHowManyOddEven";
            this.btnHowManyOddEven.Size = new System.Drawing.Size(214, 32);
            this.btnHowManyOddEven.TabIndex = 3;
            this.btnHowManyOddEven.Text = "統計數列中的奇偶數有幾個";
            this.btnHowManyOddEven.UseVisualStyleBackColor = true;
            this.btnHowManyOddEven.Click += new System.EventHandler(this.btnHowManyOddEven_Click);
            // 
            // btnOddEven
            // 
            this.btnOddEven.Location = new System.Drawing.Point(16, 47);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(214, 32);
            this.btnOddEven.TabIndex = 3;
            this.btnOddEven.Text = "輸入的數字為奇數偶數?";
            this.btnOddEven.UseVisualStyleBackColor = true;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // Frm_Methods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 508);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLongestName);
            this.Controls.Add(this.btnHonManyC);
            this.Controls.Add(this.btn101010);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnHowManyOddEven);
            this.Controls.Add(this.btnArrayMaxMin);
            this.Controls.Add(this.btnOddEven);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labShow);
            this.Name = "Frm_Methods";
            this.Text = "Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnHonManyC;
        private System.Windows.Forms.Button btnLongestName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btn101010;
        private System.Windows.Forms.Button btnArrayMaxMin;
        private System.Windows.Forms.Button btnHowManyOddEven;
        private System.Windows.Forms.Button btnOddEven;
    }
}