using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FionaWFApp
{
    public partial class frmReporteGeneral : Form
    {
        public frmReporteGeneral()
        {
            InitializeComponent();
        }

        private void frmReporteGeneral_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FionaWFApPBDDataSet.Persona' table. You can move, or remove it, as needed.
            this.PersonaTableAdapter.Fill(this.FionaWFApPBDDataSet.Persona);

            this.reportViewer1.RefreshReport();
        }
    }
}
