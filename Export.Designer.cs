namespace ShopSvet
{
    partial class Export
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.svetBDDataSet1 = new ShopSvet.svetBDDataSet1();
            this.ExportButton = new System.Windows.Forms.Button();
            this.товарTableAdapter = new ShopSvet.svetBDDataSet1TableAdapters.товарTableAdapter();
            this.svetBDDataSet = new ShopSvet.svetBDDataSet();
            this.товарBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter1 = new ShopSvet.svetBDDataSetTableAdapters.товарTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗаЕдDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svetBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svetBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.описаниеТовараDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.ценаЗаЕдDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(541, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "товар";
            this.товарBindingSource.DataSource = this.svetBDDataSet1;
            // 
            // svetBDDataSet1
            // 
            this.svetBDDataSet1.DataSetName = "svetBDDataSet1";
            this.svetBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(128, 178);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(194, 32);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "Экспортировать данные";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // svetBDDataSet
            // 
            this.svetBDDataSet.DataSetName = "svetBDDataSet";
            this.svetBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource1
            // 
            this.товарBindingSource1.DataMember = "товар";
            this.товарBindingSource1.DataSource = this.svetBDDataSet;
            // 
            // товарTableAdapter1
            // 
            this.товарTableAdapter1.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // описаниеТовараDataGridViewTextBoxColumn
            // 
            this.описаниеТовараDataGridViewTextBoxColumn.DataPropertyName = "Описание товара";
            this.описаниеТовараDataGridViewTextBoxColumn.HeaderText = "Описание товара";
            this.описаниеТовараDataGridViewTextBoxColumn.Name = "описаниеТовараDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // ценаЗаЕдDataGridViewTextBoxColumn
            // 
            this.ценаЗаЕдDataGridViewTextBoxColumn.DataPropertyName = "Цена за ед";
            this.ценаЗаЕдDataGridViewTextBoxColumn.HeaderText = "Цена за ед";
            this.ценаЗаЕдDataGridViewTextBoxColumn.Name = "ценаЗаЕдDataGridViewTextBoxColumn";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 234);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экпортировать";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svetBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svetBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn поле1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поле2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поле3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поле4DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ExportButton;
        private svetBDDataSet1 svetBDDataSet1;
        private svetBDDataSet1TableAdapters.товарTableAdapter товарTableAdapter;
        private svetBDDataSet svetBDDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource1;
        private svetBDDataSetTableAdapters.товарTableAdapter товарTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗаЕдDataGridViewTextBoxColumn;
    }
}