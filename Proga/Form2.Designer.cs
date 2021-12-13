namespace Proga
{
    partial class Form2
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
            this.carFillingStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azsDataSet = new Proga.azsDataSet();
            this.car_Filling_StationTableAdapter = new Proga.azsDataSetTableAdapters.Car_Filling_StationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carFillingStationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // carFillingStationBindingSource
            // 
            this.carFillingStationBindingSource.DataMember = "Car_Filling_Station";
            this.carFillingStationBindingSource.DataSource = this.azsDataSet;
            // 
            // azsDataSet
            // 
            this.azsDataSet.DataSetName = "azsDataSet";
            this.azsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_Filling_StationTableAdapter
            // 
            this.car_Filling_StationTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 464);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carFillingStationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private azsDataSet azsDataSet;
        private System.Windows.Forms.BindingSource carFillingStationBindingSource;
        private azsDataSetTableAdapters.Car_Filling_StationTableAdapter car_Filling_StationTableAdapter;
    }
}