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
    public partial class Frm_PicViewer_new : Form
    {
        public Frm_PicViewer_new()
        {
            InitializeComponent();
        }
        public Image NewImage   //屬性是提供彈性機制以讀取、寫入或計算私用欄位值的成員
        {
            get { return newShow.Image; }
            set { newShow.Image = value; }
        }
    }
}
