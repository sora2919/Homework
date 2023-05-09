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
    public partial class Frm_Student_Grade : Form
    {
        public Frm_Student_Grade()
        {
            InitializeComponent();
            rtxtShow.Text = $"姓名\t國文\t英文\t數學\t總分\t平均\t\t最高\t\t最低\n";
        }

        //常用
        List<studentScore>listu=new List<studentScore>();//將每個學生的分數存到這
        studentScore score = new studentScore();//單個學生的分數資訊
        Random random = new Random();
        int sumChi = 0;
        int sumEng = 0;
        int sumMath = 0;

        public struct studentScore//分數struct
        {
            public string Name;
            public int ScoreChi;
            public int ScoreEng;
            public int ScoreMath;
            public int ScoreSum;
            public double ScoreAVG;
            public int ScoreMax;
            public int ScoreMin;
            public string HighestSub;
            public string LowestSub;

            public void getScore(string _Name, int _ScoreChi, int _ScoreEng, int _ScoreMath) //抓分數 有空再回來改分數同樣的狀況
            {
                Name = _Name;
                ScoreChi = _ScoreChi;
                ScoreEng = _ScoreEng;
                ScoreMath = _ScoreMath;
                ScoreSum = ScoreChi + ScoreEng + ScoreMath;
                ScoreAVG = Math.Round(ScoreSum / 3d, 1, MidpointRounding.AwayFromZero);
                int[] arr=new int[] { ScoreChi, ScoreEng, ScoreMath};
                ScoreMax = arr.Max();
                ScoreMin= arr.Min();

                if (ScoreChi == ScoreMax)
                    HighestSub = "國文";
                else if (ScoreEng == ScoreMax)
                    HighestSub = "英文";
                else if (ScoreMath == ScoreMax)
                    HighestSub = "數學";


                if (ScoreChi == ScoreMin)
                    LowestSub = "國文";
                else if (ScoreEng == ScoreMin)
                    LowestSub = "英文";
                else if (ScoreMath == ScoreMin)
                    LowestSub = "數學";
            }
        }

        //SHOW分數
        void ShowScore()
        {
            rtxtShow.Text = $"姓名\t國文\t英文\t數學\t總分\t平均\t\t最高\t\t最低\n";
            foreach (studentScore score in listu)
            {
                rtxtShow.Text += $"{score.Name}\t{score.ScoreChi}\t{score.ScoreEng}\t{score.ScoreMath}\t{score.ScoreSum}\t{score.ScoreAVG}\t\t{score.HighestSub}{score.ScoreMax}\t\t{score.LowestSub}{score.ScoreMin}\n";
                sumChi += score.ScoreChi;
                sumEng += score.ScoreEng;
                sumMath += score.ScoreMath;
            }
            btnSumUp.Enabled = true;

        }

        //確認格子是否有填對格式
        public bool checkForms()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名");
                return false;
            }
            else if (!int.TryParse(txtScoreChi.Text, out int s)|| !int.TryParse(txtScoreEng.Text, out int t)|| !int.TryParse(txtScoreMath.Text, out int u))
            {
                MessageBox.Show("請輸入數字");
                return false;
            }
            return true;
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            if (checkForms())
            {
                sumChi = 0;
                sumEng = 0;
                sumMath = 0;
                score.getScore(txtName.Text, int.Parse(txtScoreChi.Text), int.Parse(txtScoreEng.Text), int.Parse(txtScoreMath.Text));
                listu.Add(score);
                ShowScore();
            }
            

        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            sumChi = 0;
            sumEng = 0;
            sumMath = 0;
            int i=listu.Count+1;
            score.getScore(i.ToString(), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101));
            listu.Add(score);
            ShowScore();
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            sumChi = 0;
            sumEng = 0;
            sumMath = 0;
            for (int j = 0; j < 20; j++)
            {
                int i = listu.Count + 1;
                score.getScore(i.ToString(), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101));
                listu.Add(score);
            }

            ShowScore();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listu.Clear();
            ShowScore();
            sumChi = 0;
            sumEng = 0;
            sumMath = 0;
            rtxtAll.Text = "";
            btnSumUp.Enabled = false;
            btnRandom20.Enabled = true;
            btnAddRandom.Enabled = true;
            btnAddInput.Enabled = true;
        }

        private void btnSumUp_Click(object sender, EventArgs e)
        {
            btnRandom20.Enabled = false;
            btnAddRandom.Enabled = false;
            btnAddInput.Enabled = false;
            rtxtAll.Text = $"總分\t{sumChi}\t{sumEng}\t{sumMath}\n" +
                $"平均\t{(double)sumChi/listu.Count:f1}\t{(double)sumEng / listu.Count:f1}\t{(double)sumMath / listu.Count:f1}\n" +
                $"最高\t{listu.Max(s => s.ScoreChi)}\t{listu.Max(s => s.ScoreEng)}\t{listu.Max(s => s.ScoreMath)}\n" +
                $"最低\t{listu.Min(s => s.ScoreChi)}\t{listu.Min(s => s.ScoreEng)}\t{listu.Min(s => s.ScoreMath)}\n";

        }

        private void Frm_Student_Grade_Load(object sender, EventArgs e)
        {
            btnSumUp.Enabled = false;
        }
    }
}
