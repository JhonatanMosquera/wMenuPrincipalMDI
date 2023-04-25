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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void datosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDatosEstudiante frmDatosEstudiante = new frmDatosEstudiante();
            frmDatosAcademicos frmDatosAcademicos = new frmDatosAcademicos();
           
            frmDatosEstudiante.MdiParent = this;
        

            frmDatosEstudiante.Show();
     

            

        }

        private void datosAcademicostoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDatosAcademicos frmDatosAcademicos  = new frmDatosAcademicos();
            frmDatosEstudiante frmDatosEstudiante = new frmDatosEstudiante();
             frmDatosAcademicos.MdiParent = this;
          
            frmDatosAcademicos.Show();
           

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDatosEstudiante = this.ActiveMdiChild;
            if (frmDatosEstudiante != null )
            {
                frmDatosEstudiante.Close();
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
