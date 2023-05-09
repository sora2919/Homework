namespace Homework
{
    partial class Frm_HelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloForm));
            this.labCName = new System.Windows.Forms.Label();
            this.labEName = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labStarSign = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtStarSign = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCName
            // 
            this.labCName.AutoSize = true;
            this.labCName.BackColor = System.Drawing.Color.Transparent;
            this.labCName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCName.ForeColor = System.Drawing.Color.AliceBlue;
            this.labCName.Location = new System.Drawing.Point(132, 82);
            this.labCName.Name = "labCName";
            this.labCName.Size = new System.Drawing.Size(162, 24);
            this.labCName.TabIndex = 0;
            this.labCName.Text = "中　文　姓　名：";
            // 
            // labEName
            // 
            this.labEName.AutoSize = true;
            this.labEName.BackColor = System.Drawing.Color.Transparent;
            this.labEName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEName.ForeColor = System.Drawing.Color.AliceBlue;
            this.labEName.Location = new System.Drawing.Point(132, 134);
            this.labEName.Name = "labEName";
            this.labEName.Size = new System.Drawing.Size(161, 24);
            this.labEName.TabIndex = 0;
            this.labEName.Text = "English Name ：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.Color.Transparent;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.ForeColor = System.Drawing.Color.AliceBlue;
            this.labSex.Location = new System.Drawing.Point(132, 186);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(162, 24);
            this.labSex.TabIndex = 0;
            this.labSex.Text = "性　　　　　別：";
            // 
            // labStarSign
            // 
            this.labStarSign.AutoSize = true;
            this.labStarSign.BackColor = System.Drawing.Color.Transparent;
            this.labStarSign.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStarSign.ForeColor = System.Drawing.Color.AliceBlue;
            this.labStarSign.Location = new System.Drawing.Point(132, 238);
            this.labStarSign.Name = "labStarSign";
            this.labStarSign.Size = new System.Drawing.Size(162, 24);
            this.labStarSign.TabIndex = 0;
            this.labStarSign.Text = "星　　　　　座：";
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCName.Location = new System.Drawing.Point(289, 77);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(158, 35);
            this.txtCName.TabIndex = 1;
            // 
            // txtEName
            // 
            this.txtEName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEName.Location = new System.Drawing.Point(289, 129);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(158, 35);
            this.txtEName.TabIndex = 1;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(289, 181);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(158, 35);
            this.txtSex.TabIndex = 1;
            // 
            // txtStarSign
            // 
            this.txtStarSign.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStarSign.Location = new System.Drawing.Point(289, 233);
            this.txtStarSign.Name = "txtStarSign";
            this.txtStarSign.Size = new System.Drawing.Size(158, 35);
            this.txtStarSign.TabIndex = 1;
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.LightBlue;
            this.btnSayHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSayHello.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSayHello.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnSayHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHello.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayHello.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHello.Image")));
            this.btnSayHello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHello.Location = new System.Drawing.Point(136, 299);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(135, 79);
            this.btnSayHello.TabIndex = 2;
            this.btnSayHello.Text = "SayHello";
            this.btnSayHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.LightBlue;
            this.btnSayHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSayHi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSayHi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnSayHi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayHi.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHi.Image")));
            this.btnSayHi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHi.Location = new System.Drawing.Point(312, 299);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(135, 79);
            this.btnSayHi.TabIndex = 3;
            this.btnSayHi.Text = "SayHI";
            this.btnSayHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Frm_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 427);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.txtStarSign);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.labStarSign);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labEName);
            this.Controls.Add(this.labCName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloForm";
            this.Text = "你好!C#!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCName;
        private System.Windows.Forms.Label labEName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labStarSign;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtStarSign;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
    }
}

