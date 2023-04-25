using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wMenuPrincipalMDI
{
    /// <summary>
    /// Nombres: Jhonatan Stiven Mosquera Moreno , Paola Ruiz Osorio
    /// Fecha:24/04/2023
    /// Descripción: Registro de datos estudiantes y datos academicos. 
    /// </summary>
    
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        //Inicializamos los formularios y los llamamos ( Visualizamos )
        #region
        private void datosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Formulario datos estudiante 
            frmDatosEstudiante frmDatosEstudiante = new frmDatosEstudiante();
            frmDatosEstudiante.MdiParent = this;
            frmDatosEstudiante.Show();
            
        }

        private void datosAcademicostoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Formulario datos academicos 
            frmDatosAcademicos frmDatosAcademicos = new frmDatosAcademicos();
            frmDatosAcademicos.MdiParent = this;
            frmDatosAcademicos.Show();
            

        }
        #endregion
        //Cierra el formulario que se haya abierto anteriormente.
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form frmDatosEstudiante = this.ActiveMdiChild;
            if (frmDatosEstudiante != null)
            {
                frmDatosEstudiante.Close();
            }

            Form frmDatosAcademicos = this.ActiveMdiChild;
            if (frmDatosAcademicos != null)
            {
                frmDatosAcademicos.Close();
            }

        }

        //Sale de la aplicación.
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
