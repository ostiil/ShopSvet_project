using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSvet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();

        }

        private void AvtorizButton_Click(object sender, EventArgs e)
        {
            AvtorizForm avtorizForm = new AvtorizForm();
            avtorizForm.Show();
            //this.Hide();
        }

        private void продукцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.AddButton.Enabled = false;
            product.RedactButton.Enabled = false;
            product.RemoveButton.Enabled = false;
            product.Show();
            //this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходныеДокументыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Owner = this;
            export.Show();
        }
    }
}
