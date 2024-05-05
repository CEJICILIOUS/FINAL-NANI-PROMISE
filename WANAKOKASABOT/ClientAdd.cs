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

    public partial class ClientAdd : Form
    {
        private BindingSource _BindingSource;
        private readonly LepaopaoCoopEntities _context = new LepaopaoCoopEntities();

        public ClientAdd()
        {
            InitializeComponent();
        }

        public ClientAdd(BindingSource clientinfobindingsource):this()
        {
            _BindingSource = clientinfobindingsource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Table client = new Table();
                client.Firstname = textBox1.Text.Trim();
                client.Lastname = textBox2.Text.Trim();
                client.Residency = textBox3.Text.Trim();
                client.Age = Int32.Parse(textBox4.Text.Trim());

                _context.Tables.Add(client);
                _context.SaveChanges();

                _BindingSource.DataSource = _context.Tables.ToList();
                this.Close();
            }
        }

    }
}
