using Homework;
using Homework_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework
{
    public partial class Frm_MainForm : Form
    {
        public Frm_MainForm()
        {
            InitializeComponent();
        }

        private Form currentForm = null;


        private void btnHello_Click(object sender, EventArgs e)
        {
            if (currentForm != null)            // 判斷是否有表單已經開啟
            {
                currentForm.Close();                // 關閉之前開啟的表單
            }
            Frm_HelloForm form = new Frm_HelloForm();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            if (currentForm != null)            // 判斷是否有表單已經開啟
            {
                currentForm.Close();                // 關閉之前開啟的表單
            }
            Frm_POS form = new Frm_POS();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnStudent_Struct_Click(object sender, EventArgs e)
        {
            if (currentForm != null)            // 判斷是否有表單已經開啟
            {
                currentForm.Close();                // 關閉之前開啟的表單
            }
            Frm_Student_Struct form = new Frm_Student_Struct();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            if (currentForm != null)            // 判斷是否有表單已經開啟
            {
                currentForm.Close();                // 關閉之前開啟的表單
            }
            Frm_MyCalculate form = new Frm_MyCalculate();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (currentForm != null)            // 判斷是否有表單已經開啟
            {
                currentForm.Close();                // 關閉之前開啟的表單
            }
            Frm_Loan form = new Frm_Loan();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            if (currentForm!=null)
            { currentForm.Close(); }
            Frm_Methods form= new Frm_Methods();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnScreen_Saver_Click(object sender, EventArgs e)
        {
            Frm_ScreenSaver form = new Frm_ScreenSaver();
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.Manual;
            form.Bounds = Screen.PrimaryScreen.Bounds;
            form.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            { currentForm.Close(); }
            Frm_ForDoWhile form = new Frm_ForDoWhile();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnStudent_Grade_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            { currentForm.Close(); }
            Frm_Student_Grade form = new Frm_Student_Grade();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            { currentForm.Close(); }
            Frm_PicViewer form = new Frm_PicViewer();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            { currentForm.Close(); }
            Frm_Alarm form = new Frm_Alarm();
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //總之如果將表單開在panel(子容器)不能選取textbox或maskedtextbox的文字是老毛病，一定要在父容器中才可以正確選取
            //https://stackoverflow.com/questions/2875075/windows-forms-unable-to-click-to-focus-a-maskedtextbox-in-a-non-toplevel-form
            splLeft.Panel2.Controls.Add(form);
            form.Show();
            currentForm = form;
        }

        private void btnOXGame_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            { currentForm.Close(); }
            Frm_OXGame form = new Frm_OXGame();
            form.TopLevel = false;
            splLeft.Panel2.Controls.Add(form);
            currentForm = form;
            form.Show();
        }
    }
}
