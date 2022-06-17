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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "svetBDDataSet1.товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.svetBDDataSet1.товар);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Owner = this;
            add.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            
            this.товарTableAdapter.Update(this.svetBDDataSet1.товар);
            this.svetBDDataSet1.Tables["товар"].AcceptChanges();
            this.dataGridView1.Refresh();
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Owner = this;
            add.NametextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            add.DescriptionstextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            add.PostavtextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            add.PricetextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            add.Text = "Редактировать запись";
            add.AddButton.Enabled = false;
            add.ChangeButton.Enabled = true;
            add.Show();
            

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            else if (radioButton2.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "наименование")
            {
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            else if (comboBox1.SelectedItem == "поставщик")
            {
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            else if (comboBox1.SelectedItem == "цена за шт")
            {
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
            }
        }

        private void SbrosButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
        }
    }
}
