using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_POS_Ver0 : Form
    {
        public Frm_POS_Ver0()
        {
            InitializeComponent();
        }


        int WineCount, IceCreamCount, PizzaCount, PancakeCount, 
            WinePrice=200, IceCreamPrice=80, PizzaPrice=300, PancakePrice=120,TotalPrice;

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (TotalPrice <= 0)
            { MessageBox.Show("尚未點餐!", "確認付款",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            else
            MessageBox.Show($"以信用卡付款共{Math.Round(TotalPrice * 0.9, 0, MidpointRounding.AwayFromZero)}元", "確認付款",MessageBoxButtons.OKCancel);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (TotalPrice <= 0)
            { MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            MessageBox.Show($"以現金付款共{TotalPrice}元","確認付款", MessageBoxButtons.OKCancel);
        }


        //這裡是點選清除清單全部起始化
        private void btnClear_Click(object sender, EventArgs e)
        {
            labList.Text = "請點選菜單";
            labTotalPrice.Text = "NT.0元";
            WineCount = IceCreamCount = PizzaCount = PancakeCount = TotalPrice = 0;

        }


        //★★★★★這邊是菜單按鈕們
        private void btnPizza_Click(object sender, EventArgs e)
        {
            PizzaCount++;
            AddToList();
        }

        private void btnPanCake_Click(object sender, EventArgs e)
        {
            PancakeCount++;
            AddToList();
        }

        private void btnIceCream_Click(object sender, EventArgs e)
        {
            IceCreamCount++;
            AddToList();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            WineCount++;
            AddToList();
        }


        //★★★★★這邊是做一個可以讓字串分行又算價錢的方法
        void AddToList()
        {
            string List = "";   //沒加這句重製的話下面的句子會一直累加，也可以把一開始的文字清空洗掉

            if (WineCount > 0)  //沒有加這個的話沒選的東西都會顯示0出來
            {
                List += $"紅酒× {WineCount}份，共{WineCount * WinePrice}元\r\n";
            }

            if (IceCreamCount > 0)
            {
                List += $"冰淇淋× {IceCreamCount}份，共{IceCreamCount*IceCreamPrice}元\r\n";
            }

            if (PizzaCount > 0)
            {
                List += $"披薩× {PizzaCount}份，共{PizzaCount*PizzaPrice}元\r\n";
            }

            if (PancakeCount > 0)
            {
                List += $"鬆餅× {PancakeCount}份，共{PancakeCount*PancakePrice}元\r\n";
            }

            TotalPrice = WineCount * WinePrice + IceCreamCount * IceCreamPrice + PizzaCount * PizzaPrice + PancakeCount * PancakePrice;
            labList.Text = List;
            labTotalPrice.Text = $"NT.{TotalPrice}元";
        }
    }
}
