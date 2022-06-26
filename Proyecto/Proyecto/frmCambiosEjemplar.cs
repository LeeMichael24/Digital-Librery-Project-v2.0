﻿using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCambiosEjemplar : Form
    {
        public frmCambiosEjemplar()
        {
            InitializeComponent();
        }

        private void frmCambiosEjemplar_Load(object sender, EventArgs e)
        {
            //Combo Editorial
            cmbEditorial.DataSource = null;
            cmbEditorial.ValueMember = "id_editorial";
            cmbEditorial.DisplayMember = "nombre_editorial";
            cmbEditorial.DataSource = EjemplarDAO.ObtenerEditorials();
            
            // Combo Autor
            cmbAutor.DataSource = null;
            cmbAutor.ValueMember = "id_autor";
            cmbAutor.DisplayMember = "nombre_autor";
            cmbAutor.DataSource = EjemplarDAO.ObtenerAutors();
            
            // Combo Coleccion
            cmbColeccion.DataSource = null;
            cmbColeccion.ValueMember = "id_coleccion";
            cmbColeccion.DisplayMember = "nombre_coleccion";
            cmbColeccion.DataSource = EjemplarDAO.ObtenerColecciones();
            
            // Combo Formato
            cmbFormato.DataSource = null;
            cmbFormato.ValueMember = "id_formato";
            cmbFormato.DisplayMember = "nombre_formato";
            cmbFormato.DataSource = EjemplarDAO.ObtenerFormatos();
        }

        private void btnAgregarCambio_Click(object sender, EventArgs e)
        {
            int editorial, autor = 0, formato = 0 , coleccion = 0;
            string nombre = txtNEjemplar.Text;
            string fecha = txtFecha.Text;
            editorial = Convert.ToInt32(cmbEditorial.SelectedIndex.ToString());
            
            

            //Validar los campos (en el formulario)
            if (nombre.Length > 0 && fecha.Length > 0)
            {
                if (EjemplarDAO.AgregarEjemplar(nombre, fecha, editorial, autor, formato, coleccion)){
                    MessageBox.Show("Ejemplar agregado exitosamente!", "BINAES",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNEjemplar.Clear();
                    txtFecha.Clear();
                }else
                    MessageBox.Show("Error! Pruebe más tarde!", "BINAES",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error! Los campos están vacíos!", "POO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtEditName.Text;
            int id = Convert.ToInt32(txtEditID.Text);
            
            //Validar los campos (en el formulario)
            if (nombre.Length > 0 && id > 0)
            {
                if (EjemplarDAO.EditarEjemplar(nombre, id)){
                    MessageBox.Show("Ejemplar editado exitosamente!", "BINAES",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEditName.Clear();
                    txtEditID.Clear();
                }else
                    MessageBox.Show("Error! Pruebe más tarde!", "BINAES",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error! Los campos están vacíos!", "BINAES",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            this.Close( );
        }

        private void btnEliminarEje_Click(object sender, EventArgs e)
        {
            string nombre = txtEliminarEje.Text;
            int id = Convert.ToInt32(txtEliminarID.Text);
            
            //Validar los campos (en el formulario)
            if (nombre.Length > 0 && id > 0)
            {
                if (EjemplarDAO.EliminarEjemplar(nombre, id)){
                    MessageBox.Show("Ejemplar eliminado exitosamente!", "BINAES",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEditName.Clear();
                    txtEditID.Clear();
                }else
                    MessageBox.Show("Error! Pruebe más tarde!", "BINAES",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error! Los campos están vacíos!", "BINAES",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            this.Close( );
        }
    }
    
    
}