using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WANAKOKASABOT.entities;

namespace WANAKOKASABOT
{
    public partial class LoanInfo : Form
    {
        private BindingSource _BindingSource;
        LepaopaoCoopEntities _context = new LepaopaoCoopEntities();
        private int selectedloanid;
        private int id;


        public LoanInfo()
        {
            InitializeComponent();
        }

        public LoanInfo(int id, BindingSource bindingSource) : this()
        {
            this.id = id;
            _BindingSource = bindingSource;
        }

        private void LoanInfo_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'midtermDataSet1.Loan' table. You can move, or remove it, as needed.
            //this.loanTableAdapter.Fill(this.midtermDataSet1.Loan);
           // loanBindingSource.DataSource = _context.Loans.ToList();

            
            var clientinfo = _context.Tables.Where(q => q.Id == id).FirstOrDefault();
            label3.Text = clientinfo.Firstname + clientinfo.Lastname;
            label2.Text = clientinfo.Id.ToString();
            label5.Text = clientinfo.Residency.ToString();  
            label7.Text = clientinfo.Age.ToString();

            int specificclientid = clientinfo.Id;
            var loansForSpecificClient = _context.Loans.Where(loan => loan.ClientId == specificclientid).ToList();
            loanBindingSource.DataSource = loansForSpecificClient;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Artifakt Element", 9, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Artifakt Element", 9);

        }
        public void refresh() {
            var clientinfo = _context.Tables.Where(q => q.Id == id).FirstOrDefault();
            label3.Text = clientinfo.Firstname + clientinfo.Lastname;
            label2.Text = clientinfo.Id.ToString();
            label5.Text = clientinfo.Residency.ToString();
            label7.Text = clientinfo.Age.ToString();
            int specificclientid = clientinfo.Id;
            var loansForSpecificClient = _context.Loans.Where(loan => loan.ClientId == specificclientid).ToList();
            loanBindingSource.DataSource = loansForSpecificClient;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoanAdd client = new LoanAdd(loanBindingSource);
            client.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Loan selectedLoan = dataGridView1.SelectedRows[0].DataBoundItem as Loan;

            if (selectedLoan != null)
            {
                if (selectedLoan.Status_Paid == "paid")
                {
                    selectedLoan.Status_Paid = "unpaid";
                }
                else
                {
                    selectedLoan.Status_Paid = "paid";
                }
                _context.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var searchText = textBox1.Text;
            loanBindingSource.DataSource = _context.Loans.Where(q => (q.LoanId  + q.Status_Paid + q.Due_Date + q.Term).Contains(searchText)).ToList();
            textBox1.Text = "";
        }
    }
}
