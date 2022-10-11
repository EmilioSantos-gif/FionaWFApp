
namespace FionaWFApp
{
    partial class frmRecibo
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
            this.PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FionaWFApPBDDataSet = new FionaWFApp.FionaWFApPBDDataSet();
            this.rtpvRecibo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonaTableAdapter = new FionaWFApp.FionaWFApPBDDataSetTableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FionaWFApPBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaBindingSource
            // 
            this.PersonaBindingSource.DataMember = "Persona";
            this.PersonaBindingSource.DataSource = this.FionaWFApPBDDataSet;
            // 
            // FionaWFApPBDDataSet
            // 
            this.FionaWFApPBDDataSet.DataSetName = "FionaWFApPBDDataSet";
            this.FionaWFApPBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtpvRecibo
            // 
            this.rtpvRecibo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonaBindingSource;
            this.rtpvRecibo.LocalReport.DataSources.Add(reportDataSource1);
            this.rtpvRecibo.LocalReport.ReportEmbeddedResource = "FionaWFApp.rptPersonaRecibo.rdlc";
            this.rtpvRecibo.Location = new System.Drawing.Point(0, 0);
            this.rtpvRecibo.Name = "rtpvRecibo";
            this.rtpvRecibo.ServerReport.BearerToken = null;
            this.rtpvRecibo.Size = new System.Drawing.Size(800, 450);
            this.rtpvRecibo.TabIndex = 0;
            // 
            // PersonaTableAdapter
            // 
            this.PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtpvRecibo);
            this.Name = "frmRecibo";
            this.Text = "frmRecibo";
            this.Load += new System.EventHandler(this.frmRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FionaWFApPBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rtpvRecibo;
        private System.Windows.Forms.BindingSource PersonaBindingSource;
        private FionaWFApPBDDataSet FionaWFApPBDDataSet;
        private FionaWFApPBDDataSetTableAdapters.PersonaTableAdapter PersonaTableAdapter;
    }
}