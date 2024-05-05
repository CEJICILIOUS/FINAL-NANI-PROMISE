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
    public partial class ClientUpdate : Form
    {
        private int _Id;
        private BindingSource _BindingSource;
        private readonly LepaopaoCoopEntities _context = new LepaopaoCoopEntities ();

        public ClientUpdate()
        {
            InitializeComponent();
        }
        public ClientUpdate(int Id, BindingSource bindingSource) : this()
        {
            _Id = Id;
            _BindingSource = bindingSource;

        }

        private void ClientUpdate_Load(object sender, EventArgs e)
        {
            var clientinfo = _context.Tables.Where(q => q.Id == _Id).FirstOrDefault();
            textBox1.Text = clientinfo.Firstname;
            textBox2.Text = clientinfo.Lastname;
            textBox3.Text = clientinfo.Residency;
            textBox4.Text = clientinfo.Age.ToString();
            textBox5.Text = clientinfo.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all the fields in order to Update.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ClientIdToBeDeleted = textBox5.Text.Trim();

                var ClientToDelete = _context.Tables.FirstOrDefault(q => q.Id.ToString() == ClientIdToBeDeleted);

                ClientToDelete.Firstname = textBox1.Text.Trim();
                ClientToDelete.Lastname = textBox2.Text.Trim();
                ClientToDelete.Residency = textBox3.Text.Trim();
                ClientToDelete.Age = Int32.Parse(textBox4.Text.Trim());

                _context.SaveChanges();

                _BindingSource.DataSource = _context.Tables.ToList();

                this.Close();
            }
        }
    }
}
