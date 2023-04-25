using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wMenuPrincipalMDI
{
    /// <summary>
    /// Nombres: Jhonatan Stiven Mosquera Moreno , Paola Ruiz Osorio
    /// Fecha:24/04/2023
    /// Descripción: Registro de datos estudiantes.
    /// </summary>
    
    public partial class frmDatosEstudiante : Form
    {
        public frmDatosEstudiante()
        {

            InitializeComponent();

        }
        string nombreEstudiante = "";




        //Limpiar formulario.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Clear();
            txtCedula.Clear();
            rdFemenino.Checked = false;
            rdMasculino.Checked = false;
            cboDiaNacimiento.SelectedIndex = -1;
            cboMesNacimiento.SelectedIndex = -1;
            cboAñoNacimiento.SelectedIndex = -1;
            cboCiudadDondeVive.SelectedIndex = -1;

        }

        //Guardar desde el boton GUARDAR
        #region
        //Boton.
        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombreCompleto.Text) && !string.IsNullOrEmpty(txtCedula.Text))
            {
                if (int.TryParse(txtCedula.Text, out int cedula))
                {


                    if (rdFemenino.Checked || rdMasculino.Checked)
                    {

                        if (cboDiaNacimiento.SelectedIndex >= 0 && cboMesNacimiento.SelectedIndex >= 0
                        && cboAñoNacimiento.SelectedIndex >= 0 && cboCiudadDondeVive.SelectedIndex >= 0)

                        {
                            try
                            {
                                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                                // Establecer el nombre de archivo predeterminado
                                saveFileDialog1.FileName = (txtNombreCompleto.Text);

                                //Guardamos en el archivo txt.
                                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                                {
                                    Stream strGuardar = saveFileDialog1.OpenFile();
                                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                                    wrtGuardar.WriteLine("Nombre:");
                                    wrtGuardar.WriteLine(txtNombreCompleto.Text);
                                    wrtGuardar.WriteLine("Cedula");
                                    wrtGuardar.WriteLine(txtCedula.Text);
                                    wrtGuardar.WriteLine("El sexo es:");

                                    if (rdFemenino.Checked)
                                    {
                                        wrtGuardar.WriteLine("Femenino");
                                    }
                                    else
                                    {
                                        wrtGuardar.WriteLine("Masculino");
                                    }

                                    wrtGuardar.WriteLine("Fecha de nacimiento");
                                    wrtGuardar.Write(cboDiaNacimiento.Text);
                                    wrtGuardar.Write("/");
                                    wrtGuardar.Write(cboMesNacimiento.Text);
                                    wrtGuardar.Write("/");
                                    wrtGuardar.WriteLine(cboAñoNacimiento.Text);
                                    wrtGuardar.WriteLine("La ciudad donde vives es:");
                                    wrtGuardar.WriteLine(cboCiudadDondeVive.Text);
                                    wrtGuardar.Close();

                                    nombreEstudiante = txtNombreCompleto.Text;
                                    MessageBox.Show("Hola " + nombreEstudiante + " tus datos han sido registrados correctamente");

                                }

                            }
                            catch (Exception)
                            {

                                MessageBox.Show("No se pudo guardar tus datos vuelve a intentarlo");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Verifique que la fecha de nacimiento y ciudad donde vives esté marcada");
                            return;
                        }
                    }


                    else
                    {
                        MessageBox.Show("Verifique que el genero este marcado");

                        return;
                    }
                }

                else
                {

                    MessageBox.Show("No ingresate un valor numerico");

                    return;

                }
            }
            else
            {
                MessageBox.Show(" Por favor escribir tu nombre y cedula");

                return;
            }


        }

        //Menú
        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombreCompleto.Text) && !string.IsNullOrEmpty(txtCedula.Text))
            {
                if (int.TryParse(txtCedula.Text, out int cedula))
                {

                    if (rdFemenino.Checked || rdMasculino.Checked)
                    {

                        if (cboDiaNacimiento.SelectedIndex >= 0 && cboMesNacimiento.SelectedIndex >= 0
                        && cboAñoNacimiento.SelectedIndex >= 0 && cboCiudadDondeVive.SelectedIndex >= 0)

                        {
                            try
                            {
                                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                                // Establecer el nombre de archivo predeterminado.
                                saveFileDialog1.FileName = (txtNombreCompleto.Text);

                                //Guardamos en el archivo txt.
                                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                                {
                                    Stream strGuardar = saveFileDialog1.OpenFile();
                                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                                    wrtGuardar.WriteLine("Nombre:");
                                    wrtGuardar.WriteLine(txtNombreCompleto.Text);
                                    wrtGuardar.WriteLine("Cedula");
                                    wrtGuardar.WriteLine(txtCedula.Text);
                                    wrtGuardar.WriteLine("El sexo es:");

                                    if (rdFemenino.Checked)
                                    {
                                        wrtGuardar.WriteLine("Femenino");
                                    }
                                    else
                                    {
                                        wrtGuardar.WriteLine("Masculino");
                                    }

                                    wrtGuardar.WriteLine("Fecha de nacimiento");
                                    wrtGuardar.Write(cboDiaNacimiento.Text);
                                    wrtGuardar.Write("/");
                                    wrtGuardar.Write(cboMesNacimiento.Text);
                                    wrtGuardar.Write("/");
                                    wrtGuardar.WriteLine(cboAñoNacimiento.Text);
                                    wrtGuardar.WriteLine("La ciudad donde vives es:");
                                    wrtGuardar.WriteLine(cboCiudadDondeVive.Text);
                                    wrtGuardar.Close();

                                    nombreEstudiante = txtNombreCompleto.Text;
                                    MessageBox.Show("Hola " + nombreEstudiante + " tus datos han sido registrados correctamente");

                                }

                            }
                            catch (Exception)
                            {

                                MessageBox.Show("No se pudo guardar tus datos vuelve a intentarlo");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Verifique que la fecha de nacimiento y ciudad donde vives esté marcada");
                            return;
                        }
                    }


                    else
                    {
                        MessageBox.Show("Verifique que el genero este marcado");

                        return;
                    }
                }

                else
                {

                    MessageBox.Show("No ingresate un valor numérico");

                    return;

                }
            }
            else
            {
                MessageBox.Show(" Por favor escribir tu nombre y cedula");

                return;
            }


        }
        #endregion

        //Salir del formulario.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

   
