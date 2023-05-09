using System;
using System.Collections;
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
    public partial class Frm_OXGame : Form
    {
        public Frm_OXGame()
        {
            InitializeComponent();
            SetBtn();
        }


        bool isNowO = true;
        private Button[,] btnArr = new Button[3, 3];


        private void SetBtn()
        {
            btnArr[0, 0] = btn00;
            btnArr[0, 1] = btn01;
            btnArr[0, 2] = btn02;
            btnArr[1, 0] = btn10;
            btnArr[1, 1] = btn11;
            btnArr[1, 2] = btn12;
            btnArr[2, 0] = btn20;
            btnArr[2, 1] = btn21;
            btnArr[2, 2] = btn22;
            foreach (Button btn in btnArr)
            {
                btn.Click += SetOX;
            }
        }

        //按下去就有OOXX
        private void SetOX(object sender, EventArgs e) //object sender:表示触发事件的控件对象 例如button的点击事件，那么这个sender就代表这个button自己
                                                       //EventArgs e：表示事件数据的类的基类 键盘按下的键等事件的额外信息
        {
            Button btn = (Button)sender;
            if (btn.Text != "")
            {return;}

            if (isNowO==true)
            {
                btn.Text = "O";
            }
            else
            {
                btn.Text = "X";
            }
            isNowO = !isNowO;

            if (CheckWin())
            {
                string winner = isNowO ? "X" : "O";
                MessageBox.Show($"{winner} 獲勝!");
                Application.Restart(); 
            }
            else
            {
                if (AllButtonsClicked())
                {
                    MessageBox.Show("平手!沒輸沒贏!");
                    Application.Restart();
                }
            }

        }

        //檢查按鈕有沒有成線
        private bool CheckLine(Button b1, Button b2, Button b3)
        {
            if (b1.Text == "" || b2.Text == "" || b3.Text == "")
            {
                return false;
            }

            return b1.Text == b2.Text && b2.Text == b3.Text;
        }

        //檢查勝利者
        private bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (CheckLine(btnArr[i, 0], btnArr[i, 1], btnArr[i, 2]))
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (CheckLine(btnArr[0, i], btnArr[1, i], btnArr[2, i]))
                {
                    return true;
                }
            }

            if (CheckLine(btnArr[0, 0], btnArr[1, 1], btnArr[2, 2]))
            {
                return true;
            }
            if (CheckLine(btnArr[0, 2], btnArr[1, 1], btnArr[2, 0]))
            {
                return true;
            }

            return false;
        }

        //檢查按鈕是不是都點了
        private bool AllButtonsClicked()
        {
            foreach (Button b in btnArr)
            {
                if (b.Text == "")
                {
                    return false;
                }
            }

            return true;
        }


        //按鈕事件
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //按鍵事件
        private void Frm_OXGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode==Keys.R)
            {
                Application.Restart();
            }
        }



    }
}
