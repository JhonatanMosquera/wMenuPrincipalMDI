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
    public partial class frmDatosEstudiante : Form
    {
        public frmDatosEstudiante()
        { 
           
            InitializeComponent();

        }
        ///
       
        ///

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombreCompleto.Text) && !string.IsNullOrEmpty(txtCedula.Text))
            {
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    // Código a ejecutar si al menos uno de los RadioButton está marcado
                    if (cboDiaNacimiento.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboDiaNacimiento.SelectedItem.ToString())
                        && cboMesNacimiento.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboMesNacimiento.SelectedItem.ToString())
                        && cboAñoNacimiento.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboAñoNacimiento.SelectedItem.ToString())
                        && cboCiudadDondeVive.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboCiudadDondeVive.SelectedItem.ToString()))
                    {
                        try
                        {
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                            // Establecer el nombre de archivo predeterminado
                            saveFileDialog1.FileName = (txtNombreCompleto.Text);

                            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                            {
                                Stream strGuardar = saveFileDialog1.OpenFile();
                                StreamWriter wrtGuardar = new StreamWriter(strGuardar);


                                string mensajePredeterminado = "Nombre:";

                                // Escribir el mensaje predeterminado en el archivo.
                                wrtGuardar.WriteLine(mensajePredeterminado);
                                foreach (string linea in txtNombreCompleto.Lines)
                                {
                                    wrtGuardar.WriteLine(linea);
                                }
                                wrtGuardar.WriteLine("Cedula");
                                wrtGuardar.WriteLine(txtCedula.Text);
                                wrtGuardar.WriteLine("El sexo es:");
                                if (radioButton1.Checked)
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


                            }

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
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

                MessageBox.Show("Por favor escribir tu nombre y cedula");

                return;

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Clear();
            txtCedula.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cboDiaNacimiento.Text = "Dia";
            cboMesNacimiento.Text = "Mes";
            cboAñoNacimiento.Text = "Año";
            cboCiudadDondeVive.Text = "Ciudad donde vives";

        }

    
        

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombreCompleto.Text) && !string.IsNullOrEmpty(txtCedula.Text))
            {
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    // Código a ejecutar si al menos uno de los RadioButton está marcado
                    if (cboDiaNacimiento.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboDiaNacimiento.SelectedItem.ToString())
                        && cboMesNacimiento.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboMesNacimiento.SelectedItem.ToString())
                        && cboAñoNacimiento.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboAñoNacimiento.SelectedItem.ToString())
                        && cboCiudadDondeVive.SelectedIndex >= 0 && !string.IsNullOrEmpty(cboCiudadDondeVive.SelectedItem.ToString()))
                    {
                        try
                        {
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                            // Establecer el nombre de archivo predeterminado
                            saveFileDialog1.FileName = (txtNombreCompleto.Text);

                            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                            {
                                Stream strGuardar = saveFileDialog1.OpenFile();
                                StreamWriter wrtGuardar = new StreamWriter(strGuardar);


                                string mensajePredeterminado = "Nombre:";

                                // Escribir el mensaje predeterminado en el archivo.
                                wrtGuardar.WriteLine(mensajePredeterminado);
                                foreach (string linea in txtNombreCompleto.Lines)
                                {
                                    wrtGuardar.WriteLine(linea);
                                }
                                wrtGuardar.WriteLine("Cedula");
                                wrtGuardar.WriteLine(txtCedula.Text);
                                wrtGuardar.WriteLine("El sexo es:");
                                if (radioButton1.Checked)
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


                            }

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
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

                MessageBox.Show("Por favor escribir tu nombre y cedula");

                return;

            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
