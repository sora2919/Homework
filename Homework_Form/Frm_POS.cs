using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_POS : Form
    {
        public Frm_POS()
        {
            InitializeComponent();
        }

        int CountCoffee, CountJuice, CountDonut, CountBurger;
        double TotalPrice;
        int PriceCoffee = 110, PriceJuice = 85, PriceDonut = 39, PriceBurger = 150;

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (TotalPrice == 0)
            {
                MessageBox.Show("尚未點餐","確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("原價" + TotalPrice + "元，\n使用信用卡付款九折，折扣後共" + Math.Round(TotalPrice * 0.9, 0, MidpointRounding.AwayFromZero) + "元", "以信用卡付款", MessageBoxButtons.OKCancel);
        }
        //★★★★★★這個!!Math.Round!!不是真正的四捨五入!!後面要加MidpointRounding.AwayFromZero★★★★★★

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (TotalPrice == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("共" + TotalPrice + "元", "以現金付款", MessageBoxButtons.OKCancel);
        }

        //★★★★★這邊是菜單按鈕們
        private void btnDonut_Click(object sender, EventArgs e)
        {
            CountDonut++;
            AddToList();
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            CountBurger++;
            AddToList();
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            CountJuice++;
            AddToList();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            CountCoffee++;
            AddToList();
        }

        //★★★★★這裡是點選清除清單全部起始化
        private void btnClear_Click(object sender, EventArgs e)
        {
            CountCoffee = CountJuice = CountDonut = CountBurger = 0;
            TotalPrice = 0;
            labListDisplay.Text = "請開始點餐";
            labPriceDisplay.Text = "NT.0元"; 
        }


        //★★★★★這邊是做一個可以讓字串分行又算價錢的方法
        public void AddToList()
        {
            string List = "";   //沒加這句重製的話下面的句子會一直累加，也可以把一開始的文字清空洗掉
            if (CountCoffee > 0) //沒有加這個的話沒選的東西都會顯示0出來
            {
                List += $"咖啡×{CountCoffee}杯、共NT.{CountCoffee* PriceCoffee}元\r\n";
            }

            if (CountJuice > 0)
            {
                List += $"果汁×{CountJuice}杯、共NT.{CountJuice * PriceJuice}元\r\n";
            }

            if (CountDonut > 0) 
            {
                List += $"甜甜圈×{CountDonut}個、共NT.{CountDonut * PriceDonut}元\r\n";
            }

            if(CountBurger > 0) 
            {
                List += $"漢堡×{CountBurger}個、共NT.{CountBurger * PriceBurger}元\r\n";
            }

            TotalPrice = CountCoffee * PriceCoffee + CountJuice * PriceJuice + CountDonut * PriceDonut + CountBurger * PriceBurger;
            labListDisplay.Text= List;
            labPriceDisplay.Text = $"NT.{TotalPrice}元";
            
        }
    }
}
