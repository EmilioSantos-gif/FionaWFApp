using FionaWFApp.FionaWFApPBDDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FionaWFApp.FionaWFApPBDDataSet;

namespace FionaWFApp
{
    public partial class frmRecibo : Form
    {
        public string tipoDocumento;
        public string noDocumento;
        public frmRecibo()
        {
            InitializeComponent();
        }

        private void frmRecibo_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'FionaWFApPBDDataSet.Persona' table. You can move, or remove it, as needed.
            rtpvRecibo.DataBindings.Clear();

            //PersonaTableAdapter personaTableAdapter = new PersonaTableAdapter();
            //PersonaDataTable personaDataTable = personaTableAdapter.GetPersonaByDocumento(tipoDocumento, noDocumento);

            FionaWFAppBDEntities ctx = new FionaWFAppBDEntities();

            var data = ctx.SPUltimaPersona();

            
            ReportDataSource dataSource = new ReportDataSource("DataSet1", data);

            rtpvRecibo.LocalReport.DataSources.Clear();
            rtpvRecibo.LocalReport.DataSources.Add(dataSource);


            this.rtpvRecibo.RefreshReport();
        }
            // TODO: This line of code loads data into the 'FionaWFApPBDDataSet.Persona' table. You can move, or remove it, as needed.
            //this.PersonaTableAdapter.Fill(this.FionaWFApPBDDataSet.Persona);
    }
}
