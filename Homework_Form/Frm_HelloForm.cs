using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_HelloForm : Form
    {
        public Frm_HelloForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello，我是"+txtCName.Text+ "，\n英文名字是"+txtEName.Text+"。\n性別是"+txtSex.Text+"，星座是"+txtStarSign.Text+"。\n很高興認識你^^");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi，我是{txtCName.Text}，\n英文名字是{txtEName.Text}。\n性別是{txtSex.Text}，星座是{txtStarSign.Text}。\n很高興認識你^^");
        }
    }
}
