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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }

        public class PMT
        {
            private double _loan;       //Field變數最前方習慣加底線
            private double _rate;
            private int _year;
            private double _pmt;
            private double _totalPayment;

            public PMT(double loan, double rate, int year)
            {
                _loan = loan;
                _rate = rate / 1200;
                _year = year;
                _pmt = (_loan * _rate) / (1 - Math.Pow(1 + _rate, -_year * 12));
                _totalPayment = _pmt * _year * 12;

                Pmt = _pmt;     //因為這兩個數在代參數時沒有在()內，所以在呼叫?後不會代值進去，因此這邊要特別幫他們代值進去
                TotalPayment = _totalPayment;
            }

            public double Loan { get; set; }
            public double Rate { get; set; }
            public int Year { get; set; }
            public double Pmt { get; set; }
            public double TotalPayment { get; set; }
        }

        public bool TryNum() 
        {
            if (!double.TryParse(txtLoan.Text, out double loan))
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoan.Clear();
                txtLoan.Focus();
                return false;
            }
            else if (!double.TryParse(txtYear.Text, out double year))
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Clear();
                txtYear.Focus();
                return false;
            }
            else if (!double.TryParse(txtRate.Text, out double rate))
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Clear();
                txtRate.Focus();
                return false;
            }
            return true;
        }

        PMT result;
        private void btnPMT_Click(object sender, EventArgs e)
        {
            //PMT = (貸款金額 × 月利率 × ((1 + 月利率)^貸款月數)) ÷ (((1 + 月利率)^貸款月數) - 1)
            //https://www.fintechgo.com.tw/FinVIP/FinancialCalculator/LOAN_PMT
            //double PMT = (loan * rate) / (1 - Math.Pow(1 + rate, -year * 12)); 嘗試改成方法這行留著備用
            if (TryNum()) 
            {
                double loan = double.Parse(txtLoan.Text);
                double rate = double.Parse(txtRate.Text);
                int year = int.Parse(txtYear.Text);
                result = new PMT(loan, rate, year);
                result.Loan = loan;
                result.Rate = rate;
                result.Year = year;
                MessageBox.Show($"月付金額：{Math.Round(result.Pmt):c0}元");

            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double loan = double.Parse(txtLoan.Text);
            double rate = double.Parse(txtRate.Text);
            int year = int.Parse(txtYear.Text);
            result = new PMT(loan, rate, year);
            result.Loan = loan;
            result.Rate = rate;
            result.Year = year;
            MessageBox.Show($"總付款金額為：{Math.Round(result.TotalPayment):c0}元");

        }

        
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                if (TryNum())
                {
                    double loan = double.Parse(txtLoan.Text);
                    double rate = double.Parse(txtRate.Text);
                    int year = int.Parse(txtYear.Text);
                    result = new PMT(loan, rate, year);
                    result.Loan = loan;
                    result.Rate = rate;
                    result.Year = year;
                    Frm_LoanReport report = new Frm_LoanReport(result);
                    report.ShowDialog();
                }
            }
            else
            {
                Frm_LoanReport report = new Frm_LoanReport(result);
                report.ShowDialog();
            }
            //共享機制之邏輯，於此專案有兩種方式來實作，一則透過新增類別的方式來宣告定義共享變數；
            //另一則透過表單A呼叫表單B的同時，於表單B中實作具有參數形式的建構子，且利用此建構子，技巧地將共享變數由表單A予以傳遞過來給表單B
        }


    }
}
