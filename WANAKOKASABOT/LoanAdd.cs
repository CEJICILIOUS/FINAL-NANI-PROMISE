using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WANAKOKASABOT.entities;

namespace WANAKOKASABOT
{
    public partial class LoanAdd : Form
    {
        private BindingSource _BindingSource;
        private readonly LepaopaoCoopEntities _context = new LepaopaoCoopEntities();

        public LoanAdd()
        {
            InitializeComponent();
        }

        public LoanAdd(BindingSource loaninfobindingsource) : this()
        {
            _BindingSource = loaninfobindingsource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.ClientId = Int32.Parse(clientid.Text.Trim());
            loan.Loan_Amt = Int32.Parse(loanamnt.Text.Trim());
            loan.Interest = Int32.Parse(interest.Text.Trim());
            loan.Term = termcombobox.Text.Trim();
            loan.No_OfPymnt = Int32.Parse(noofpayment.Text.Trim());
            loan.Deduction = Int32.Parse(deduction.Text.Trim());
            loan.Interested_Amt = Int32.Parse(interestedamnt.Text.Trim());
            loan.Rcv_Amt = Int32.Parse(receivableamnt.Text.Trim());
            loan.Total_Payable = Int32.Parse(totalpayable.Text.Trim());
            loan.Status_Paid = status.Text.Trim();
            loan.Due_Date = dateTimePicker1.Value;


            _context.Loans.Add(loan);
            _context.SaveChanges();

           // _context.Loans.Where(q => q.ClientId ==)
            _BindingSource.DataSource = _context.Loans.ToList();
            this.Close();
        }
        private void CalculateInterestedAmount()
        { 
            if (double.TryParse(loanamnt.Text.Trim(), out double loanAmt) &&
                double.TryParse(interest.Text.Trim(), out double interestRate))
            {
               
                double interestedAmt = loanAmt * (interestRate / 100);

            
                interestedamnt.Text = interestedAmt.ToString();
            }
        }

        private void LoanAdd_Load(object sender, EventArgs e)
        {

        }

        private void loanamnt_KeyDown(object sender, KeyEventArgs e)
        {
            CalculateInterestedAmount();
        }

        private void interest_KeyDown(object sender, KeyEventArgs e)
        {
            CalculateInterestedAmount();
        }
    }
}
