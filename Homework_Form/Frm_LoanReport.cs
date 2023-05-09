using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework_Form.Frm_Loan;

namespace Homework_Form
{
    public partial class Frm_LoanReport : Form
    {
        private PMT shareVariable;
        public Frm_LoanReport(PMT pmt)
        {
            InitializeComponent();
            shareVariable = pmt;
        }

        private void Frm_LoanReport_Load(object sender, EventArgs e)
        {
            if (shareVariable != null)
            {
                labLoan.Text = shareVariable.Loan.ToString("C0");
                labRate.Text = shareVariable.Rate.ToString()+"%";
                labYear.Text = shareVariable.Year.ToString()+"年";
                labPMT.Text = shareVariable.Pmt.ToString("C0");
                labTotal.Text = shareVariable.TotalPayment.ToString("C0");
            }
        }
    }
}
