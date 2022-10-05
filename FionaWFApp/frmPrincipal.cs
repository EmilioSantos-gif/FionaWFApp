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
            String TipoDocumento, NoDocumento, Nombres, Apellidos, Sector, Direccion, Telefono, Correo, Sexo, Descripcion, Estado;
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

            //context.Persona.Add(newPersona());

            try
            {
                // Your code...
                // Could also be before try if you know the exception occurs in SaveChanges

                if(context.SaveChanges() == 1)
                {
                    MessageBox.Show("Persona registrada satisfactoriamente");

                    log.Info($"Se registro persona: {persona}");
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

        private Persona newPersona()
        {
            return new Persona
            {
                TipoDocumento = "C",
                NoDocumento = "40219326557",
                Nombres = "Alejandro",
                Apellidos = "Rodriguez",
                Sector = "Maria Auxiliadora",
                Direccion = "Calle primera, casa #2",
                Telefono = "8095864715",
                Correo = "alexrodriguez@gmail.com",
                FechaNacimiento = new DateTime(),
                Sexo = "M",
                ValorEstimadoPerdida = 152000.12m,
                Descripcion = "Perdidas provocadas a vivienda",
                Estado = "Pendiente"
            };
        }
    }
}
