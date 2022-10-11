
namespace FionaWFApp
{
    partial class frmReporteGeneral
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FionaWFApPBDDataSet = new FionaWFApp.FionaWFApPBDDataSet();
            this.PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonaTableAdapter = new FionaWFApp.FionaWFApPBDDataSetTableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FionaWFApPBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSPersonas";
            reportDataSource1.Value = this.PersonaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FionaWFApp.rptPersonasGeneral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FionaWFApPBDDataSet
            // 
            this.FionaWFApPBDDataSet.DataSetName = "FionaWFApPBDDataSet";
            this.FionaWFApPBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonaBindingSource
            // 
            this.PersonaBindingSource.DataMember = "Persona";
            this.PersonaBindingSource.DataSource = this.FionaWFApPBDDataSet;
            // 
            // PersonaTableAdapter
            // 
            this.PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteGeneral";
            this.Text = "frmReporteGeneral";
            this.Load += new System.EventHandler(this.frmReporteGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FionaWFApPBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonaBindingSource;
        private FionaWFApPBDDataSet FionaWFApPBDDataSet;
        private FionaWFApPBDDataSetTableAdapters.PersonaTableAdapter PersonaTableAdapter;
    }
}