using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_MyCalculate : Form
    {
        public Frm_MyCalculate()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckNumber())
            {
                decimal Num1= decimal.Parse(txtNum1.Text);
                decimal Num2= decimal.Parse(txtNum2.Text);
                decimal Result = Num1 + Num2;
                labAnswer.Text = Result.ToString();
            }    
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (CheckNumber())
            {
                decimal Num1 = decimal.Parse(txtNum1.Text);
                decimal Num2 = decimal.Parse(txtNum2.Text);
                decimal Result = Num1 - Num2;
                labAnswer.Text = Result.ToString();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (CheckNumber())
            {
                decimal Num1 = decimal.Parse(txtNum1.Text);
                decimal Num2 = decimal.Parse(txtNum2.Text);
                decimal Result = Num1 * Num2;
                labAnswer.Text = Result.ToString("f4");//小數點第幾位進位
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (CheckNumber())
            {
                decimal Num1 = decimal.Parse(txtNum1.Text);
                decimal Num2 = decimal.Parse(txtNum2.Text);
                if (Num2 == 0)
                {
                    MessageBox.Show("除數不得為0", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum2.Clear();
                }
                else {
                    decimal Result = Num1 / Num2;
                    labAnswer.Text = Result.ToString("f4");
                }
            }
        }
        //這邊測試是否為數字
        private bool CheckNumber()
        {
            bool TryNum1 = decimal.TryParse(txtNum1.Text, out decimal Num1);    //設bool確認TryParse結果
            //bool TryNum2 = decimal.TryParse(txtNum2.Text, out Num2);  可以直接寫在下面條件判斷trynum1先設定bool 跟2直接在if設定 如果不熟就先設

            if (!decimal.TryParse(txtNum1.Text,out Num1) || !decimal.TryParse(txtNum2.Text, out decimal Num2))
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!decimal.TryParse(txtNum2.Text, out decimal Num))  //可以直接在這判斷，前面就不用設bool TryNum2 = decimal.TryParse(txtNum2.Text, out Num2);
                { txtNum2.Clear(); txtNum2.Focus(); }
                if (TryNum1 == false)   
                { txtNum1.Clear();  txtNum1.Focus(); }  //Clear如果非數字強制清除    Focus可以將游標回到textbox中

                return false;   //到這邊如果有輸入非數字的話，回覆一個錯誤訊息，就會中止click繼續做接下來的動作
            }
            return true; //因為前面不是void所以一定要回傳值
        }


    }
}
