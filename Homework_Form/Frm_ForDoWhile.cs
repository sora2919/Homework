using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_ForDoWhile : Form
    {
        public Frm_ForDoWhile()
        {
            InitializeComponent();
        }



        private void btnTree_Click(object sender, EventArgs e)
        {
            string Result = "";
            if (!int.TryParse(txtRows.Text,out int s))
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                for (int i = 0; i < int.Parse(txtRows.Text); i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Result += "*";
                    }
                    Result += "\n";
                }
                labShow.Text = $"{Result}";
            }

        }

        private void btn99_Click(object sender, EventArgs e)
        {
            string result="九九乘法表:\n";
            for (int j = 1; j <= 9; j++)
            {
                for (int i = 2; i <= 9; i++)
                {
                    if(i*j<10)
                    {
                        result += $"{i}×{j}= {i * j}\t|";
                    }
                    else
                    {
                        result += $"{i}×{j}={i * j}\t|";
                    }
                }
                result += "\n";
            }
            labShow.Text = $"{result}";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            string trans=Convert.ToString(100, 2);
            labShow.Text = $"{trans}";
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            string result = "樂透號碼:";
            Random random = new Random();
            List<int> lotterynums = new List<int>();
            do
            {
                int number = random.Next(1, 50);
                if (!lotterynums.Contains(number))
                {
                    lotterynums.Add(number);
                }
            } while (lotterynums.Count < 6);
            foreach(int number in lotterynums)
            {
                result+= $" {number}";
            }
            labShow.Text = $"{result}";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShow.Text = "結果";
        }

        //for
        private void btnFor_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int sum = 0;
            if (!int.TryParse(txtFrom.Text,out int s))
                {
                MessageBox.Show("請輸入數字");
                 }
            else
            {
                int from = int.Parse(txtFrom.Text);
                int to = int.Parse(txtTo.Text);
                int step = int.Parse(txtStep.Text);
                List<int> list = new List<int>();   

                for(int i = from; i <= to; i=i + step)
                {
                    list.Add(i);
                    sum = list.Sum();
                }
                labShow.Text = $"{from}到{to}相隔{step - 1}\n加總為{sum}";
            }
        }

        //do
        private void btnDo_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int from = int.Parse(txtFrom.Text);
            int to = int.Parse(txtTo.Text);
            int step = int.Parse(txtStep.Text);
            List<int> list = new List<int>();
            int i = from;

            if (!int.TryParse(txtFrom.Text, out int s))
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                do
                {
                    list.Add(i);
                    i+= step;

                } while (i <= to);

                int sum = list.Sum();
                labShow.Text = $"{from}到{to}相隔{step-1}\n加總為{sum}";
            }
        }
        //while
        private void btnWhile_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int from = int.Parse(txtFrom.Text);
            int to = int.Parse(txtTo.Text);
            int step = int.Parse(txtStep.Text);
            List<int> list = new List<int>();
            int i = from;

            if (!int.TryParse(txtFrom.Text, out int s))
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                while (i <= to)
                {
                    list.Add(i);
                    i += step;
                }
                int sum = list.Sum();
                labShow.Text = $"{from}到{to}相隔{step - 1}\n加總為{sum}";
            }
        }
    }
}
