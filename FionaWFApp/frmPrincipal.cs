using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace FionaWFApp
{
    public partial class frmPrincipal : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string TipoDocumento, NoDocumento, Nombres, Apellidos, Sector, Direccion, Telefono, Correo, Sexo, Descripcion, Estado;
            DateTime FechaNacimiento;
            decimal ValorEstimadoPerdida;
            
            TipoDocumento = txtTipoDocumento.Text;
            NoDocumento = txtNoDocumento.Text;
            Nombres = txtNombres.Text;
            Apellidos = txtApellidos.Text;
            Sector = txtSector.Text;
            Direccion = txtDireccion.Text;
            Telefono = txtTelefono.Text;
            Correo = txtCorreo.Text;
            FechaNacimiento = dtpFechaNacimiento.Value;
            Sexo = txtSexo.Text;
            
            if(!decimal.TryParse(txtValorPerdida.Text, out ValorEstimadoPerdida))
            {
                MessageBox.Show($"No se pudo parsear el valor perdida: {txtValorPerdida.Text}");
            }
            
            Descripcion = txtDescripcion.Text;
            Estado = txtEstado.Text;
            
            //Persona persona = newPersona();
            
            Persona persona = new Persona
            {
                TipoDocumento = TipoDocumento,
                NoDocumento = NoDocumento,
                Nombres = Nombres,
                Apellidos = Apellidos,
                Sector = Sector,
                Direccion = Direccion,
                Telefono = Telefono,
                Correo = Correo,
                FechaNacimiento = FechaNacimiento,
                Sexo = Sexo,
                ValorEstimadoPerdida = ValorEstimadoPerdida,
                Descripcion = Descripcion,
                Estado = Estado
            };
            
            FionaWFAppBDEntities context = new FionaWFAppBDEntities();
            context.Persona.Add(persona);

            try
            {
                // Your code...
                // Could also be before try if you know the exception occurs in SaveChanges

                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("Persona registrada satisfactoriamente");

                    frmRecibo recibo = new frmRecibo();
                    recibo.tipoDocumento = persona.TipoDocumento;
                    recibo.noDocumento = persona.NoDocumento;
                    recibo.ShowDialog();

                    log.Info($"Se registro persona: {persona.Nombres} {persona.Apellidos} {persona.NoDocumento} {persona.Descripcion}");
                    
                } else
                {
                    MessageBox.Show("No se pudo registrar la persona");
                }
            }
            catch (DbEntityValidationException err)
            {
                foreach (var eve in err.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                //throw;
            }
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteGeneral frmReporteGeneral = new frmReporteGeneral();
            frmReporteGeneral.MdiParent = this;
            frmReporteGeneral.Show();
        }
    }
}
