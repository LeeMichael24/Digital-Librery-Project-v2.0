using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmEditaEvento : Form
    {
        public frmEditaEvento(int idEvento, string TituloEvento, int Asistentes)
        {
            InitializeComponent();
            txtIdEvento.Text = idEvento.ToString();
            txtTituloEvento.Text = TituloEvento;
            txtAsistentes.Text = Asistentes.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EventosDAO.EditarEvento(txtTituloEvento.Text.ToString(), Convert.ToInt16(txtIdEvento.Text), Convert.ToInt16(txtAsistentes.Text)))
            {
                MessageBox.Show("Evento editado exitosamente!", "BINAES", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Realmente desea eliminar el evento: " + txtTituloEvento.Text, "Confirme",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (EventosDAO.borrarEvento(Convert.ToInt16(txtIdEvento.Text)))
                {
                    MessageBox.Show("Evento borrado exitosamente!", "BINAES", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
           
        }
        }
    }
