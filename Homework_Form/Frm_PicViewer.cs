using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_PicViewer : Form
    {
        public Frm_PicViewer()
        {
            InitializeComponent();
            pics = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11 };
            for (int i=0; i<pics.Length; i++)
            {
                pics[i].Click += PicClick;
            }
        }
        private PictureBox[] pics;

        private void PicClick(object sender, EventArgs e)
        {
            Frm_PicViewer_new newviewer = new Frm_PicViewer_new();
            PictureBox clickedPic = (PictureBox)sender;     //代表的是被點擊的PictureBox，透過sender取得物件的屬性值
            newviewer.NewImage = clickedPic.Image;      //在new有設定一個NewImage屬性以供傳接值
            newviewer.ShowDialog();
        }

    }
}
