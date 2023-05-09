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
    public partial class Frm_GuessNum2 : Form
    {
        public Frm_GuessNum2()
        {
            InitializeComponent();
        }

        Random ran = new Random();
        int min = 1;
        int max = 100;


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
