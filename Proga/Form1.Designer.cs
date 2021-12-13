namespace Proga
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.azsDataSet = new Proga.azsDataSet();
            this.azsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carFillingStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_Filling_StationTableAdapter = new Proga.azsDataSetTableAdapters.Car_Filling_StationTableAdapter();
            this.list_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listStationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listdataNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listdataPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listdataAmountOfFuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carFillingStationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 64);
            this.button2.TabIndex = 25;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 64);
            this.button1.TabIndex = 24;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.list_Address,
            this.dataGridViewTextBoxColumn1,
            this.listStationIDDataGridViewTextBoxColumn,
            this.listdataNameDataGridViewTextBoxColumn,
            this.listdataPriceDataGridViewTextBoxColumn,
            this.listdataAmountOfFuelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carFillingStationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(329, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(839, 227);
            this.dataGridView1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Остаток литра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Название топлива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Станция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Адрес";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 13;
            // 
            // azsDataSet
            // 
            this.azsDataSet.DataSetName = "azsDataSet";
            this.azsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // azsDataSetBindingSource
            // 
            this.azsDataSetBindingSource.DataSource = this.azsDataSet;
            this.azsDataSetBindingSource.Position = 0;
            // 
            // carFillingStationBindingSource
            // 
            this.carFillingStationBindingSource.DataMember = "Car_Filling_Station";
            this.carFillingStationBindingSource.DataSource = this.azsDataSetBindingSource;
            // 
            // car_Filling_StationTableAdapter
            // 
            this.car_Filling_StationTableAdapter.ClearBeforeFill = true;
            // 
            // list_Address
            // 
            this.list_Address.DataPropertyName = "list_Address";
            this.list_Address.HeaderText = "list_Address";
            this.list_Address.MinimumWidth = 8;
            this.list_Address.Name = "list_Address";
            this.list_Address.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "list_Address";
            this.dataGridViewTextBoxColumn1.HeaderText = "list_Address";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // listStationIDDataGridViewTextBoxColumn
            // 
            this.listStationIDDataGridViewTextBoxColumn.DataPropertyName = "list_Station_ID";
            this.listStationIDDataGridViewTextBoxColumn.HeaderText = "list_Station_ID";
            this.listStationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listStationIDDataGridViewTextBoxColumn.Name = "listStationIDDataGridViewTextBoxColumn";
            this.listStationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // listdataNameDataGridViewTextBoxColumn
            // 
            this.listdataNameDataGridViewTextBoxColumn.DataPropertyName = "list_data_Name";
            this.listdataNameDataGridViewTextBoxColumn.HeaderText = "list_data_Name";
            this.listdataNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listdataNameDataGridViewTextBoxColumn.Name = "listdataNameDataGridViewTextBoxColumn";
            this.listdataNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // listdataPriceDataGridViewTextBoxColumn
            // 
            this.listdataPriceDataGridViewTextBoxColumn.DataPropertyName = "list_data_Price";
            this.listdataPriceDataGridViewTextBoxColumn.HeaderText = "list_data_Price";
            this.listdataPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listdataPriceDataGridViewTextBoxColumn.Name = "listdataPriceDataGridViewTextBoxColumn";
            this.listdataPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // listdataAmountOfFuelDataGridViewTextBoxColumn
            // 
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.DataPropertyName = "list_data_AmountOfFuel";
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.HeaderText = "list_data_AmountOfFuel";
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.Name = "listdataAmountOfFuelDataGridViewTextBoxColumn";
            this.listdataAmountOfFuelDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carFillingStationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource azsDataSetBindingSource;
        private azsDataSet azsDataSet;
        private System.Windows.Forms.BindingSource carFillingStationBindingSource;
        private azsDataSetTableAdapters.Car_Filling_StationTableAdapter car_Filling_StationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listStationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listdataNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listdataPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listdataAmountOfFuelDataGridViewTextBoxColumn;
    }
}

