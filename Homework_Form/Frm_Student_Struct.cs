using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_Student_Struct : Form
    {
        public Frm_Student_Struct()
        {
            InitializeComponent();
        }

        //★★★★這邊是建構struct
        public struct SaveScore
        {
            public  string Name;
            public int ScoreChi;
            public int ScoreEng;
            public int ScoreMath;
            public SaveScore(string StuName, int StuScoreChi, int StuScoreEng, int StuScoreMath)
            {
                Name = StuName;
                ScoreChi = StuScoreChi;
                ScoreEng = StuScoreEng;
                ScoreMath = StuScoreMath;
            }

        }
        //★★★★★建構結束




        // //★★★★★這裡宣告常用數值
        string DisName;
        int DisScoChi, DisScoEng, DisScoMath;
        string[] Subject = new string[3] { "國文", "英文", "數學" };


        //查詢最高最低分數

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int[] Scores = new int[3];
            Scores[0] = DisScoChi;
            Scores[1] = DisScoEng;
            Scores[2] = DisScoMath;
            //這邊最高分數
            int s =Scores.Max();
            List<string>highest=new List<string>();     //因為不確定有多少個分數一樣，所以設定list
            for(int i = 0; i < Scores.Length; i++)
            {
                if (Scores[i] == s)
                {
                    highest.Add(Subject[i]);
                }
            }
            //這邊最低分數
            int t=Scores.Min();
            List<string> lowest=new List<string>();
            for(int i = 0; i < Scores.Length; i++)
            {
                if (Scores[i] == t)
                {
                    lowest.Add(Subject[i]);
                }
            }
            labDisplayHighLow.Text = $"最高科目成績為{string.Join("、", highest)}:{Scores.Max()}分\n最低科目成績為{string.Join("、", lowest)}:{Scores.Min()}分";

        }



        //儲存分數資料
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSubChi.Text, out int s))
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubChi.Clear();
                txtSubChi.Focus();
            }

            else if (!int.TryParse(txtSubEng.Text, out int t))
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubEng.Clear();
                txtSubEng.Focus();
            }

            else if(!int.TryParse(txtSubMath.Text, out int u))
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubMath.Clear();
                txtSubMath.Focus();
            }
            else
            {
                SaveScore result = new SaveScore(txtStuName.Text, int.Parse(txtSubChi.Text), int.Parse(txtSubEng.Text), int.Parse(txtSubMath.Text));
                DisName = result.Name;
                DisScoChi = result.ScoreChi;
                DisScoEng = result.ScoreEng;
                DisScoMath = result.ScoreMath;
            }

        }


        //顯示已儲存的分數
        private void btnLoad_Click(object sender, EventArgs e)
        {
            labDisplayScore.Text = $"學生姓名：{DisName}\n國文：{DisScoChi}\n英文：{DisScoEng}\n數學：{DisScoMath}";
        }


    }
}
