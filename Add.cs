using System;
using System.Data;
using System.Windows.Forms;

namespace ShopSvet
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Product product = this.Owner as Product;
            if (product != null)
            {
                DataRow nRow = product.svetBDDataSet1.Tables["товар"].NewRow();
                int rowCount = product.dataGridView1.RowCount + 1;
                nRow[0] = product.dataGridView1.RowCount;
                nRow[1] = NametextBox.Text;
                nRow[2] = DescriptionstextBox.Text;
                nRow[3] = PostavtextBox.Text;
                nRow[4] = PricetextBox.Text;
                product.svetBDDataSet1.Tables["товар"].Rows.Add(nRow);
                product.товарTableAdapter.Update(product.svetBDDataSet1.товар);
                product.svetBDDataSet1.Tables["товар"].AcceptChanges();
                product.dataGridView1.Refresh();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Product product = this.Owner as Product;
            int rowCount = product.dataGridView1.SelectedRows[0].Index;
            //DataRow nRow = product.svetBDDataSet1.Tables["товар"].Rows[1];
            product.dataGridView1.Rows[rowCount].Cells[0].Value = product.dataGridView1.RowCount;
            product.dataGridView1.Rows[rowCount].Cells[1].Value = NametextBox.Text;
            product.dataGridView1.Rows[rowCount].Cells[2].Value = DescriptionstextBox.Text;
            product.dataGridView1.Rows[rowCount].Cells[3].Value = PostavtextBox.Text;
            product.dataGridView1.Rows[rowCount].Cells[4].Value = PricetextBox.Text;
            //product.svetBDDataSet1.Tables["товар"].Rows.Add()
            product.товарTableAdapter.Update(product.svetBDDataSet1.товар);
            product.svetBDDataSet1.Tables["товар"].AcceptChanges();
            product.dataGridView1.Refresh();
        }
    }
}
