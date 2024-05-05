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
    public partial class ClientInfo : Form
    {
        LepaopaoCoopEntities _context = new LepaopaoCoopEntities();
        private int _id;
        private int selectedclientid;

        public ClientInfo()
        {
            InitializeComponent();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midtermDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.midtermDataSet.Table);
            tableBindingSource.DataSource = _context.Tables.ToList();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Artifakt Element", 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Artifakt Element", 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientAdd client = new ClientAdd(tableBindingSource);
            client.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            selectedclientid = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoanInfo client = new LoanInfo(selectedclientid, tableBindingSource);
            client.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var ClientToDelete = _context.Tables.FirstOrDefault(q => q.Id == selectedclientid);

                _context.Tables.Remove(ClientToDelete);
                _context.SaveChanges();

                tableBindingSource.DataSource = _context.Tables.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientUpdate update = new ClientUpdate(selectedclientid, tableBindingSource);
            update.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var searchText = textBox1.Text;
            tableBindingSource.DataSource = _context.Tables.Where(q => (q.Firstname + q.Lastname + q.Residency + q.Age).Contains(searchText)).ToList();
            textBox1.Text = "";
        }
    }
}
