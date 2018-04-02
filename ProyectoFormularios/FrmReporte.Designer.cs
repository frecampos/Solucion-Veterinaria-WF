namespace ProyectoFormularios
{
    partial class FrmReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BUSCARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetRegistros = new ProyectoFormularios.DatasetRegistros();
            this.txtEspecilidad = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BUSCARTableAdapter = new ProyectoFormularios.DatasetRegistrosTableAdapters.BUSCARTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BUSCARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BUSCARBindingSource
            // 
            this.BUSCARBindingSource.DataMember = "BUSCAR";
            this.BUSCARBindingSource.DataSource = this.DatasetRegistros;
            // 
            // DatasetRegistros
            // 
            this.DatasetRegistros.DataSetName = "DatasetRegistros";
            this.DatasetRegistros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEspecilidad
            // 
            this.txtEspecilidad.Location = new System.Drawing.Point(34, 29);
            this.txtEspecilidad.Name = "txtEspecilidad";
            this.txtEspecilidad.Size = new System.Drawing.Size(182, 20);
            this.txtEspecilidad.TabIndex = 0;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(236, 29);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.BUSCARBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFormularios.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(299, 294);
            this.reportViewer1.TabIndex = 2;
            // 
            // BUSCARTableAdapter
            // 
            this.BUSCARTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 294);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(471, 26);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(567, 26);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(93, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 466);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtEspecilidad);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BUSCARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEspecilidad;
        private System.Windows.Forms.Button btnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BUSCARBindingSource;
        private DatasetRegistros DatasetRegistros;
        private DatasetRegistrosTableAdapters.BUSCARTableAdapter BUSCARTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnExportar;
    }
}