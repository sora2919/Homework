namespace Homework
{
    partial class Frm_POS_Ver0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_POS_Ver0));
            this.labList = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panList = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.labWordPay = new System.Windows.Forms.Label();
            this.labWordDis = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.panPayment = new System.Windows.Forms.Panel();
            this.labWordTotal = new System.Windows.Forms.Label();
            this.panTotalPrice = new System.Windows.Forms.Panel();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnPanCake = new System.Windows.Forms.Button();
            this.labMenu = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.Panel();
            this.panList.SuspendLayout();
            this.panPayment.SuspendLayout();
            this.panTotalPrice.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.Color.White;
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.ForeColor = System.Drawing.Color.Black;
            this.labList.Location = new System.Drawing.Point(12, 34);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(201, 236);
            this.labList.TabIndex = 4;
            this.labList.Text = "請點選菜單";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(18, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "購物清單List";
            // 
            // panList
            // 
            this.panList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panList.Controls.Add(this.labList);
            this.panList.Controls.Add(this.btnClear);
            this.panList.Controls.Add(this.label7);
            this.panList.Location = new System.Drawing.Point(540, 62);
            this.panList.Name = "panList";
            this.panList.Size = new System.Drawing.Size(226, 327);
            this.panList.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(121, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(3, 57);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(92, 36);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.Location = new System.Drawing.Point(129, 57);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(90, 36);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // labWordPay
            // 
            this.labWordPay.AutoSize = true;
            this.labWordPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWordPay.Location = new System.Drawing.Point(18, 13);
            this.labWordPay.Name = "labWordPay";
            this.labWordPay.Size = new System.Drawing.Size(74, 21);
            this.labWordPay.TabIndex = 0;
            this.labWordPay.Text = "付款方式";
            // 
            // labWordDis
            // 
            this.labWordDis.AutoSize = true;
            this.labWordDis.BackColor = System.Drawing.Color.FloralWhite;
            this.labWordDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labWordDis.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWordDis.Location = new System.Drawing.Point(119, 96);
            this.labWordDis.Name = "labWordDis";
            this.labWordDis.Size = new System.Drawing.Size(100, 19);
            this.labWordDis.TabIndex = 2;
            this.labWordDis.Text = "信用卡付款9折!";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BackColor = System.Drawing.Color.Black;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labTotalPrice.Location = new System.Drawing.Point(18, 46);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(201, 31);
            this.labTotalPrice.TabIndex = 0;
            this.labTotalPrice.Text = "NT.0元";
            this.labTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panPayment
            // 
            this.panPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPayment.Controls.Add(this.btnCash);
            this.panPayment.Controls.Add(this.btnCard);
            this.panPayment.Controls.Add(this.labWordPay);
            this.panPayment.Controls.Add(this.labWordDis);
            this.panPayment.Location = new System.Drawing.Point(306, 199);
            this.panPayment.Name = "panPayment";
            this.panPayment.Size = new System.Drawing.Size(226, 132);
            this.panPayment.TabIndex = 2;
            // 
            // labWordTotal
            // 
            this.labWordTotal.AutoSize = true;
            this.labWordTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWordTotal.Location = new System.Drawing.Point(18, 13);
            this.labWordTotal.Name = "labWordTotal";
            this.labWordTotal.Size = new System.Drawing.Size(96, 21);
            this.labWordTotal.TabIndex = 0;
            this.labWordTotal.Text = "總金額Total";
            // 
            // panTotalPrice
            // 
            this.panTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTotalPrice.Controls.Add(this.labTotalPrice);
            this.panTotalPrice.Controls.Add(this.labWordTotal);
            this.panTotalPrice.Location = new System.Drawing.Point(306, 62);
            this.panTotalPrice.Name = "panTotalPrice";
            this.panTotalPrice.Size = new System.Drawing.Size(226, 104);
            this.panTotalPrice.TabIndex = 3;
            // 
            // btnWine
            // 
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.ForeColor = System.Drawing.Color.Black;
            this.btnWine.Image = ((System.Drawing.Image)(resources.GetObject("btnWine.Image")));
            this.btnWine.Location = new System.Drawing.Point(3, 71);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(120, 100);
            this.btnWine.TabIndex = 1;
            this.btnWine.Text = "紅酒\r\nWINE\r\nNT200";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnIceCream
            // 
            this.btnIceCream.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIceCream.ForeColor = System.Drawing.Color.Black;
            this.btnIceCream.Image = ((System.Drawing.Image)(resources.GetObject("btnIceCream.Image")));
            this.btnIceCream.Location = new System.Drawing.Point(129, 71);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(120, 100);
            this.btnIceCream.TabIndex = 1;
            this.btnIceCream.Text = "冰淇淋\r\nICECREAM\r\nNT80";
            this.btnIceCream.UseVisualStyleBackColor = true;
            this.btnIceCream.Click += new System.EventHandler(this.btnIceCream_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPizza.ForeColor = System.Drawing.Color.Black;
            this.btnPizza.Image = ((System.Drawing.Image)(resources.GetObject("btnPizza.Image")));
            this.btnPizza.Location = new System.Drawing.Point(3, 195);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(120, 100);
            this.btnPizza.TabIndex = 1;
            this.btnPizza.Text = "披薩\r\nPIZZA\r\nNT300";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnPanCake
            // 
            this.btnPanCake.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPanCake.ForeColor = System.Drawing.Color.Black;
            this.btnPanCake.Image = ((System.Drawing.Image)(resources.GetObject("btnPanCake.Image")));
            this.btnPanCake.Location = new System.Drawing.Point(129, 195);
            this.btnPanCake.Name = "btnPanCake";
            this.btnPanCake.Size = new System.Drawing.Size(120, 100);
            this.btnPanCake.TabIndex = 1;
            this.btnPanCake.Text = "鬆餅\r\nPANCAKE\r\nNT120";
            this.btnPanCake.UseVisualStyleBackColor = true;
            this.btnPanCake.Click += new System.EventHandler(this.btnPanCake_Click);
            // 
            // labMenu
            // 
            this.labMenu.AutoSize = true;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(3, 7);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(87, 21);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單Menu";
            // 
            // panMenu
            // 
            this.panMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMenu.Controls.Add(this.btnWine);
            this.panMenu.Controls.Add(this.btnIceCream);
            this.panMenu.Controls.Add(this.btnPizza);
            this.panMenu.Controls.Add(this.btnPanCake);
            this.panMenu.Controls.Add(this.labMenu);
            this.panMenu.Location = new System.Drawing.Point(34, 62);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(254, 327);
            this.panMenu.TabIndex = 4;
            // 
            // Frm_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panList);
            this.Controls.Add(this.panPayment);
            this.Controls.Add(this.panTotalPrice);
            this.Controls.Add(this.panMenu);
            this.Name = "Frm_POS";
            this.Text = "Frm_POS";
            this.panList.ResumeLayout(false);
            this.panList.PerformLayout();
            this.panPayment.ResumeLayout(false);
            this.panPayment.PerformLayout();
            this.panTotalPrice.ResumeLayout(false);
            this.panTotalPrice.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label labWordPay;
        private System.Windows.Forms.Label labWordDis;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Panel panPayment;
        private System.Windows.Forms.Label labWordTotal;
        private System.Windows.Forms.Panel panTotalPrice;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnPanCake;
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Panel panMenu;
    }
}