using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ShopSvet
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void Export_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "svetBDDataSet.товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter1.Fill(this.svetBDDataSet.товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "svetBDDataSet.товар". При необходимости она может быть перемещена или удалена.
            //this.товарTableAdapter1.Fill(this.svetBDDataSet.товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "svetBDDataSet1.товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.svetBDDataSet1.товар);

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;
            //книга
            Excel.Workbook wBook;
            Excel.Worksheet wSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 15;
            wSheet = (Excel.Worksheet)wBook.Sheets[1];
            wSheet.Name = "Товары";
            xlApp.Cells[1, 1] = "Код";
            xlApp.Cells[1, 2] = "Наименование";
            xlApp.Cells[1, 3] = "Описание";
            xlApp.Cells[1, 4] = "Поставщик";
            xlApp.Cells[1, 5] = "Цена за шт";
            for (int i=0; i<dataGridView1.Rows.Count-1; i++)
            {
                for (int j=0; j< dataGridView1.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            wSheet.Cells.HorizontalAlignment = 3;
            xlApp.Visible = true;
        }
    }
}
