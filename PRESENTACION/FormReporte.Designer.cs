﻿namespace ModeloParcial405310.PRESENTACION
{
    partial class FormReporte
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
            this.sPCONSULTARMATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ModeloParcial405310.REPORTES.DataSet1();
            this.tMATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CONSULTAR_MATERIALESTableAdapter = new ModeloParcial405310.REPORTES.DataSet1TableAdapters.SP_CONSULTAR_MATERIALESTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_CONSULTAR_MATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARMATERIALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMATERIALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_MATERIALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPCONSULTARMATERIALESBindingSource
            // 
            this.sPCONSULTARMATERIALESBindingSource.DataMember = "SP_CONSULTAR_MATERIALES";
            this.sPCONSULTARMATERIALESBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMATERIALESBindingSource
            // 
            this.tMATERIALESBindingSource.DataMember = "T_MATERIALES";
            this.tMATERIALESBindingSource.DataSource = this.dataSet1;
            // 
            // sP_CONSULTAR_MATERIALESTableAdapter
            // 
            this.sP_CONSULTAR_MATERIALESTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_CONSULTAR_MATERIALESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ModeloParcial405310.REPORTES.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_CONSULTAR_MATERIALESBindingSource
            // 
            this.SP_CONSULTAR_MATERIALESBindingSource.DataMember = "SP_CONSULTAR_MATERIALES";
            this.SP_CONSULTAR_MATERIALESBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARMATERIALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_MATERIALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private REPORTES.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tMATERIALESBindingSource;
        private System.Windows.Forms.BindingSource sPCONSULTARMATERIALESBindingSource;
        private REPORTES.DataSet1TableAdapters.SP_CONSULTAR_MATERIALESTableAdapter sP_CONSULTAR_MATERIALESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_CONSULTAR_MATERIALESBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
    }
}