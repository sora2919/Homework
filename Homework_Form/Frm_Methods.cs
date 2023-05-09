using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Homework_Form
{
    public partial class Frm_Methods : Form
    {
        public Frm_Methods()
        {
            InitializeComponent();
        }

        //奇數偶數
        private void btnOddEven_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum.Text,out int num))
            {
                MessageBox.Show("請輸入整數");
            }
            else
            {
                if (int.Parse(txtNum.Text)%2==0)
                { labShow.Text = $"您輸入的數字為偶數"; }
                else { labShow.Text = $"您輸入的數字為奇數"; }
            }
        }

        //清除
        private void btnClear_Click(object sender, EventArgs e)
        {
                labShow.Text = "結果";
        }

        //陣列中共有幾個奇偶數
        private void btnHowManyOddEven_Click(object sender, EventArgs e)
        {
            int[] howmanyoddeved = { 546, 794, 487, 1217, 11, 687, 746, 1557, 6, 841 };
            //labShow.Text = "陣列:";
            //foreach (int item in howmanyoddeved) 
            //{
            //    string result = Convert.ToString(item);
            //    labShow.Text += $"{result}、";
            //}
            labShow.Text = $"陣列：[{string.Join("、", howmanyoddeved)}]";  //用這個方式更好列也好排版
            int countOdd=0, countEven=0;
            for(int i=0; i < 10; i++)
            {
                int count = howmanyoddeved[i];
                if (count % 2 == 0) 
                {
                    countEven++;
                }
                else { countOdd++;}
            }
            labShow.Text += $"\n偶數的個數: {countEven}, 奇數的個數: {countOdd}";
        }

        //陣列中最大最小數
        private void btnArrayMaxMin_Click(object sender, EventArgs e)
        {
            int[] howmanyoddeved = { 546, 794, 487, 1217, 11, 687, 746, 1557, 6, 841 };
            labShow.Text = $"陣列：[{string.Join("、", howmanyoddeved)}]\n最大值為:{howmanyoddeved.Max()}、最小值為:{howmanyoddeved.Min()}";
            
        }

        //找含有c或C的字 參考書20LINQ
        private void btnHonManyC_Click(object sender, EventArgs e)
        {
            string[] Names = { "Alice", "Carol", "奧莉薇亞", "William", "蘇菲亞", "Lucas", "Jackson", "艾瑪", "CC" };
            labShow.Text = $"陣列內的名字有：[{string.Join("、", Names)}]";
            int result = Names.Count(countC => countC.ToLower().Contains("c"));//將全部的字都轉為小寫就可以只搜尋小寫c
            labShow.Text += $"\n共有{result}個名字含有C或c";
            var NameWithC = Names.Where(names => names.Contains("c") || names.Contains("C"));//這邊傳回的是IEnumerable<string>，不是單純字串，所以要用var讓他自己判斷
            labShow.Text += $"\n這些名字分別是：{string.Join("、", NameWithC)}";
        }

        //找出名字最長者
        private void btnLongestName_Click(object sender, EventArgs e)
        {
            string[] Names = { "Alice", "Carol", "奧莉薇亞", "William", "蘇菲亞", "Lucas", "Jackson", "艾瑪", "CC" };
            labShow.Text = $"陣列內的名字有：[{string.Join("、", Names)}]";
            //var findLongest = Names.OrderByDescending(names => names.Length).First();   //最後面.First()才可只取第一個項目，但第二位就不會顯示
            //所以先找出最長長度是多少字
            int longestLenth= Names.Max(names => names.Length);
            var findLongest = Names.Where(names => names.Length == longestLenth);
            labShow.Text += $"\n名字最長的是：{string.Join("、", findLongest)}，都是{longestLenth}字";
        }

        //外面1的[10,10]陣列
        private void btn10_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];
            for(int i = 0; i < 10; i++)
            {
                for(int j=0;j<10;j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)//外圍
                    {
                        array[i,j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += array[i, j] + "　";
                }
                result += "\n";
            }
            labShow.Text = $"{result}";
        }

        //外面0的[10,10]陣列
        private void btn01_Click(object sender, EventArgs e)
        {
            int[,]array = new int[10, 10];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        array[i, j] = 0;
                    }
                    else { array[i, j] = 1; }
                }
            }

            string result="";
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    result+= array[i, j] + "　";
                }
                result += "\n";
            }
            labShow.Text = $"{result}";
        }

        //1010交錯[10,10]陣列
        private void btn101010_Click(object sender, EventArgs e)
        {
            int[,] array=new int[10, 10];
            //for (int i = 0; i < 10; i++) 
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            if (j % 2 == 0)
            //            {
            //                array[i, j] = 1;
            //            }
            //            else { array[i, j] = 0; }
            //        }
            //        else 
            //        {
            //            if (j % 2 == 0)
            //            {
            //                array[i, j] = 0;
            //            }
            //            else { array[i, j] = 1; }
            //        }
            //    }
            //}
            //更簡短方式，直接由i+j判斷餘數方式來決定要填入1或0
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    array[i, j] = (i + j+1) % 2;//取餘數
                }
            
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += array[i, j] + "　";
                }
                result += "\n";
            }
            labShow.Text = $"{result}";
        }

        //SWAP
        private void btnSwap_Click(object sender, EventArgs e)
        {
            int num1=100, num2=200;
            int temp;
            labShow.Text = $"換位前N1={num1}、N2={num2}";
            temp = num1;
            num1 = num2;
            num2 = temp;
            labShow.Text += $"\n換位後N1={num1}、N2={num2}";
        }

        //sum
        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] array = { 546, 794, 487, 1217, 11, 687, 746, 1557, 6, 841 };
            labShow.Text = $"陣列：{string.Join("、", array)}";
            int sum = 0;
            foreach(int s in array)
            {
                sum += s;
            }
            labShow.Text += $"\n總和為{sum}";
        }

        //MAX
        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] array = { 546, 794, 487, 1217, 11, 687, 746, 1557, 6, 841 };
            labShow.Text = $"陣列：{string.Join("、", array)}";
            int max = array.OrderByDescending(x => x).First();
            labShow.Text += $"\n最大值{max}";
        }

        //MIN
        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] array = { 546, 794, 487, 1217, 11, 687, 746, 1557, 6, 841 };
            labShow.Text = $"陣列：{string.Join("、",array)}";
            int min=array.OrderBy(x=> x).First();
            labShow.Text += $"\n最小值為{min}";
        }
    }
}
