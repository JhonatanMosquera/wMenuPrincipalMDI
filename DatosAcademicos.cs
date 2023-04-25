﻿using System;
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
    /// Descripción: Registro de los datos académicos. 
    /// </summary>
    
    public partial class frmDatosAcademicos : Form
    {
        public frmDatosAcademicos()
        {
            InitializeComponent();
        }


        //Salir del formulario 
        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        //Limpiar formulario.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboMateria.Text = string.Empty;
            cboSemestre.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        //Guardar datos
        #region
        //Menú
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(cboMateria.Text) && !string.IsNullOrEmpty(cboSemestre.Text))
            {
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    try
                    {

                        //Guardamos en el archivo txt.
                        if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                        {
                            Stream strGuardar = saveFileDialog1.OpenFile();
                            StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                            wrtGuardar.WriteLine("Materia que cursa: ");
                            wrtGuardar.WriteLine(cboMateria.Text);
                            wrtGuardar.WriteLine("Semestre que cursa: ");
                            wrtGuardar.WriteLine(cboSemestre.Text);
                            wrtGuardar.WriteLine("El estudiante está: ");
                            if (radioButton1.Checked)
                            {
                                wrtGuardar.WriteLine("Activo");
                            }
                            else
                            {
                                wrtGuardar.WriteLine("Inactivo");
                            }
                            wrtGuardar.Close();
                            MessageBox.Show("Tus datos han sido registrados correctamente");
                        }

                    }


                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }



                }
                else
                {
                    MessageBox.Show("Verifique que haya seleccionado si está activo o no ");
                }

            }
            else
            {
                MessageBox.Show("Verifique que haya seleccionado materia y semestre que cursa");
            }

        }
        //Botón
        private void button1_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(cboMateria.Text) && !string.IsNullOrEmpty(cboSemestre.Text))
            {
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    try
                    {
                        //Guardamos en el archivo txt.
                        if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                        {
                            Stream strGuardar = saveFileDialog1.OpenFile();
                            StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                            wrtGuardar.WriteLine("Materia que cursa: ");
                            wrtGuardar.WriteLine(cboMateria.Text);
                            wrtGuardar.WriteLine("Semestre que cursa: ");
                            wrtGuardar.WriteLine(cboSemestre.Text);

                            wrtGuardar.WriteLine("El estudiante está: ");
                            if (radioButton1.Checked)
                            {
                                wrtGuardar.WriteLine("Activo");
                            }
                            else
                            {
                                wrtGuardar.WriteLine("Inactivo");
                            }
                            wrtGuardar.Close();
                            MessageBox.Show("Tus datos han sido registrados correctamente");
                        }
                    }


                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Verifique que haya seleccionado si está activo o no ");
                }

            }
            else
            {
                MessageBox.Show("Verifique que haya seleccionado materia y semestre que cursa");
            }

        }
        #endregion 
    }
}

