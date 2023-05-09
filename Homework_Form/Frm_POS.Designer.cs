namespace Homework
{
    partial class Frm_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_POS));
            this.grpbMenu = new System.Windows.Forms.GroupBox();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnJuice = new System.Windows.Forms.Button();
            this.btnDonut = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.grpbTotalPrice = new System.Windows.Forms.GroupBox();
            this.labPriceDisplay = new System.Windows.Forms.Label();
            this.grpbPayment = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.labListDisplay = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpbMenu.SuspendLayout();
            this.grpbTotalPrice.SuspendLayout();
            this.grpbPayment.SuspendLayout();
            this.grpbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbMenu
            // 
            this.grpbMenu.Controls.Add(this.btnCoffee);
            this.grpbMenu.Controls.Add(this.btnJuice);
            this.grpbMenu.Controls.Add(this.btnDonut);
            this.grpbMenu.Controls.Add(this.btnBurger);
            this.grpbMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpbMenu.Location = new System.Drawing.Point(12, 39);
            this.grpbMenu.Name = "grpbMenu";
            this.grpbMenu.Size = new System.Drawing.Size(288, 404);
            this.grpbMenu.TabIndex = 0;
            this.grpbMenu.TabStop = false;
            this.grpbMenu.Text = "菜單Menu";
            // 
            // btnCoffee
            // 
            this.btnCoffee.Image = ((System.Drawing.Image)(resources.GetObject("btnCoffee.Image")));
            this.btnCoffee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCoffee.Location = new System.Drawing.Point(17, 56);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(119, 140);
            this.btnCoffee.TabIndex = 0;
            this.btnCoffee.Text = "咖啡\r\nCoffee\r\nNT.110";
            this.btnCoffee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnJuice
            // 
            this.btnJuice.Image = ((System.Drawing.Image)(resources.GetObject("btnJuice.Image")));
            this.btnJuice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJuice.Location = new System.Drawing.Point(154, 56);
            this.btnJuice.Name = "btnJuice";
            this.btnJuice.Size = new System.Drawing.Size(119, 140);
            this.btnJuice.TabIndex = 0;
            this.btnJuice.Text = "果汁\r\nJuice\r\nNT.85";
            this.btnJuice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJuice.UseVisualStyleBackColor = true;
            this.btnJuice.Click += new System.EventHandler(this.btnJuice_Click);
            // 
            // btnDonut
            // 
            this.btnDonut.Image = ((System.Drawing.Image)(resources.GetObject("btnDonut.Image")));
            this.btnDonut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonut.Location = new System.Drawing.Point(17, 228);
            this.btnDonut.Name = "btnDonut";
            this.btnDonut.Size = new System.Drawing.Size(119, 140);
            this.btnDonut.TabIndex = 0;
            this.btnDonut.Text = "甜甜圈\r\nDonut\r\nNT.39";
            this.btnDonut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonut.UseVisualStyleBackColor = true;
            this.btnDonut.Click += new System.EventHandler(this.btnDonut_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.Image = ((System.Drawing.Image)(resources.GetObject("btnBurger.Image")));
            this.btnBurger.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBurger.Location = new System.Drawing.Point(154, 228);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(119, 140);
            this.btnBurger.TabIndex = 0;
            this.btnBurger.Text = "漢堡\r\nBurger\r\nNT.150";
            this.btnBurger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // grpbTotalPrice
            // 
            this.grpbTotalPrice.Controls.Add(this.labPriceDisplay);
            this.grpbTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpbTotalPrice.Location = new System.Drawing.Point(306, 39);
            this.grpbTotalPrice.Name = "grpbTotalPrice";
            this.grpbTotalPrice.Size = new System.Drawing.Size(288, 168);
            this.grpbTotalPrice.TabIndex = 0;
            this.grpbTotalPrice.TabStop = false;
            this.grpbTotalPrice.Text = "總金額TotalPrice";
            // 
            // labPriceDisplay
            // 
            this.labPriceDisplay.BackColor = System.Drawing.Color.Black;
            this.labPriceDisplay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPriceDisplay.ForeColor = System.Drawing.Color.White;
            this.labPriceDisplay.Location = new System.Drawing.Point(15, 56);
            this.labPriceDisplay.Name = "labPriceDisplay";
            this.labPriceDisplay.Size = new System.Drawing.Size(253, 81);
            this.labPriceDisplay.TabIndex = 0;
            this.labPriceDisplay.Text = "NT.0元";
            this.labPriceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpbPayment
            // 
            this.grpbPayment.Controls.Add(this.label1);
            this.grpbPayment.Controls.Add(this.btnCash);
            this.grpbPayment.Controls.Add(this.btnCard);
            this.grpbPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpbPayment.Location = new System.Drawing.Point(306, 234);
            this.grpbPayment.Name = "grpbPayment";
            this.grpbPayment.Size = new System.Drawing.Size(288, 209);
            this.grpbPayment.TabIndex = 0;
            this.grpbPayment.TabStop = false;
            this.grpbPayment.Text = "付款方式Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(221)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(174, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "信用卡享九折";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(20, 76);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(110, 55);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(158, 76);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(110, 55);
            this.btnCard.TabIndex = 0;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.labListDisplay);
            this.grpbList.Controls.Add(this.btnClear);
            this.grpbList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpbList.Location = new System.Drawing.Point(600, 39);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(288, 404);
            this.grpbList.TabIndex = 0;
            this.grpbList.TabStop = false;
            this.grpbList.Text = "清單List";
            // 
            // labListDisplay
            // 
            this.labListDisplay.BackColor = System.Drawing.Color.White;
            this.labListDisplay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labListDisplay.ForeColor = System.Drawing.Color.Black;
            this.labListDisplay.Location = new System.Drawing.Point(18, 39);
            this.labListDisplay.Name = "labListDisplay";
            this.labListDisplay.Size = new System.Drawing.Size(253, 300);
            this.labListDisplay.TabIndex = 0;
            this.labListDisplay.Text = "請開始點餐";
            this.labListDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 44);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Frm_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 460);
            this.Controls.Add(this.grpbMenu);
            this.Controls.Add(this.grpbTotalPrice);
            this.Controls.Add(this.grpbPayment);
            this.Controls.Add(this.grpbList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_POS";
            this.Text = "POS";
            this.grpbMenu.ResumeLayout(false);
            this.grpbTotalPrice.ResumeLayout(false);
            this.grpbPayment.ResumeLayout(false);
            this.grpbPayment.PerformLayout();
            this.grpbList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbMenu;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnJuice;
        private System.Windows.Forms.Button btnDonut;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.GroupBox grpbTotalPrice;
        private System.Windows.Forms.Label labPriceDisplay;
        private System.Windows.Forms.GroupBox grpbPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.Label labListDisplay;
        private System.Windows.Forms.Button btnClear;
    }
}

