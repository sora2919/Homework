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

namespace Homework_Form
{
    public partial class Frm_Alarm : Form
    {
        public Frm_Alarm()
        {
            InitializeComponent();
            timer.Start();
        }

        private bool isTimeSet = false;
        DateTime alarmtime = DateTime.Now;
        private bool isRed = false;
        int count = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            labNowTime.Text = "Now Time:" + DateTime.Now.ToString("HH:mm:ss");


            if (isTimeSet && DateTime.Now >= alarmtime)
            {
                if (isRed)
                {
                    BackColor = Color.Black;
                }
                else
                {
                    BackColor = Color.Red;
                    if (count > 15)
                    {
                        isTimeSet = false;
                        BackColor = default(Color);
                    }
                }
                isRed = !isRed;
                count++;
            }


        }

        private void chkSet_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = default(Color);
            if (chkSet.Checked == true)
            {
                //alarmtime = DateTime.ParseExact很嚴格，所以要先將字串改為HH:mm:ss格式才能正常運作
                string inputTime = matxtTimeSet.Text.Replace("時", ":").Replace("分", ":").Replace("秒", "");
                if (TimeSpan.TryParse(inputTime, out _))//TimeSpan.TryParse檢查字串是否為有效的時間格式，out _可以不用再設其實不會用到的變數
                {
                    alarmtime = DateTime.ParseExact(inputTime, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite);
                    if (alarmtime < DateTime.Now)
                    {
                        MessageBox.Show("請輸入比目前時間大的時間。");
                        chkSet.Checked = false;
                        isTimeSet = false;
                    }
                    else
                    {
                        isTimeSet = true;
                    }
                    //alarmtime = DateTime.ParseExact(inputTime, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite);

                }
                else
                {
                    MessageBox.Show("請輸入有效時間。");
                    chkSet.Checked = false;
                    isTimeSet = false;
                }
            }
            else { isTimeSet = false; }
            count = 0;

        }


    }
}
