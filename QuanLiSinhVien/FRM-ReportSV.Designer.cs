namespace QuanLiSinhVien
{
    partial class FRM_ReportSV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.qlsinhvien15a10DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qlsinhvien15a10DataSet = new QuanLiSinhVien.qlsinhvien15a10DataSet();
            this.qlsinhvien15a10DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLiSinhVien.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qlsinhvien15a10DataSet4 = new QuanLiSinhVien.qlsinhvien15a10DataSet4();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienTableAdapter = new QuanLiSinhVien.qlsinhvien15a10DataSet4TableAdapters.sinhvienTableAdapter();
            this.sinhvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienTableAdapter1 = new QuanLiSinhVien.qlsinhvien15a10DataSetTableAdapters.sinhvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // qlsinhvien15a10DataSetBindingSource1
            // 
            this.qlsinhvien15a10DataSetBindingSource1.DataSource = this.qlsinhvien15a10DataSet;
            this.qlsinhvien15a10DataSetBindingSource1.Position = 0;
            // 
            // qlsinhvien15a10DataSet
            // 
            this.qlsinhvien15a10DataSet.DataSetName = "qlsinhvien15a10DataSet";
            this.qlsinhvien15a10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlsinhvien15a10DataSetBindingSource
            // 
            this.qlsinhvien15a10DataSetBindingSource.DataSource = this.qlsinhvien15a10DataSet;
            this.qlsinhvien15a10DataSetBindingSource.Position = 0;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataStudent";
            reportDataSource1.Value = this.sinhvienBindingSource;
            reportDataSource2.Name = "Student";
            reportDataSource2.Value = this.sinhvienBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLiSinhVien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 452);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // qlsinhvien15a10DataSet4
            // 
            this.qlsinhvien15a10DataSet4.DataSetName = "qlsinhvien15a10DataSet4";
            this.qlsinhvien15a10DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.qlsinhvien15a10DataSet4;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhvienBindingSource1
            // 
            this.sinhvienBindingSource1.DataMember = "sinhvien";
            this.sinhvienBindingSource1.DataSource = this.qlsinhvien15a10DataSet;
            // 
            // sinhvienTableAdapter1
            // 
            this.sinhvienTableAdapter1.ClearBeforeFill = true;
            // 
            // FRM_ReportSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_ReportSV";
            this.Text = "FRM_ReportSV";
            this.Load += new System.EventHandler(this.FRM_ReportSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvien15a10DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource qlsinhvien15a10DataSetBindingSource;
        private qlsinhvien15a10DataSet qlsinhvien15a10DataSet;
        private System.Windows.Forms.BindingSource qlsinhvien15a10DataSetBindingSource1;
        private qlsinhvien15a10DataSet4 qlsinhvien15a10DataSet4;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private qlsinhvien15a10DataSet4TableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private System.Windows.Forms.BindingSource sinhvienBindingSource1;
        private qlsinhvien15a10DataSetTableAdapters.sinhvienTableAdapter sinhvienTableAdapter1;
    }
}