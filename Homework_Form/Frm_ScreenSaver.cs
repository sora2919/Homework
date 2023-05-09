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
    public partial class Frm_ScreenSaver : Form
    {
        public Frm_ScreenSaver()
        {
            InitializeComponent();
        }

        int usaSpeedX = 15;
        int usaSpeedY = 10;
        private Point isMouseMove;

        private void Frm_ScreenSaver_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true; //減少執行時圖片閃爍
            isMouseMove = Control.MousePosition;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            picUsa.Left += usaSpeedX;
            picUsa.Top += usaSpeedY;
            if(picUsa.Right> this.ClientSize.Width||picUsa.Left<0)
            {
                usaSpeedX = -usaSpeedX;
            }
            if (picUsa.Bottom> this.ClientSize.Height||picUsa.Top<0)
            {
                usaSpeedY = -usaSpeedY;
            }
        }

        private void Frm_ScreenSaver_MouseHover(object sender, EventArgs e)
        {

        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseMove != Control.MousePosition)
            {
                timerStop.Start();
            }
        }
    }
}
