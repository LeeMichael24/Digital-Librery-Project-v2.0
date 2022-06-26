using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Properties;

namespace Proyecto
{
    public partial class frmPrincipal : Form
    {
        // public static string strMas;
        SqlConnection cn = new SqlConnection(Resources.cadena_conexion);
        private List<Bitmap> ImagenesInicioSlide;
        public frmPrincipal()
        {
            InitializeComponent();
            ImagenesInicioSlide = new List<Bitmap>();
            //ImagenesInicioSlide.Add(Resources._6);
            //ImagenesInicioSlide.Add(Resources._5);
            //ImagenesInicioSlide.Add(Resources._4);
            //ImagenesInicioSlide.Add(Resources._3);
           // ImagenesInicioSlide.Add(Resources._2);

        }
        
        private void btmColeccion_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 2;
            //Asegurarse que salga vacio cada textbox
            txtAuditorio_piso01.Clear();
            txtBiblio_piso01.Clear();
            txtComputo_piso01.Clear();
            txtInclusion_piso01.Clear();
            txtLudico_piso01.Clear();
            
            txtBiblioteca_piso02.Clear();
            txtComputo_piso02.Clear();
            txtProyeccion_piso02.Clear();
            txtLudico_piso02.Clear();
            
            txtBiblioteca_piso03.Clear();
            txtComputo_piso03.Clear();
            txtProyeccion_piso03.Clear();
            
            txtBiblioteca04.Clear();
            txtComputo04.Clear();
            txtProyeccion04.Clear();
            txtInvestigacion04.Clear();
            
       //Para area biblioteca piso 01
            foreach (var a in AreaDAO.FiltrarPorPiso(1, "Biblioteca variada"))
            {
                txtBiblio_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area ludica piso 01
            foreach (var a in AreaDAO.FiltrarPorPiso(3, "Salon para todas las edades"))
            {
                txtLudico_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area auditorio piso 01
            foreach (var a in AreaDAO.FiltrarPorPiso(1, "Auditorium para conferencias/peliculas"))
            {
                txtAuditorio_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area computacion piso 01 
            foreach (var a in AreaDAO.FiltrarPorPiso(1, "Area de computo"))
            {
                txtComputo_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            
            foreach (var a in AreaDAO.FiltrarPorPiso(1, "Area con informacion sobre la comunidad LGTBI"))
            {
                txtInclusion_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            foreach (var a in AreaDAO.FiltrarPorPiso(1, "Area con informacion sobre las personas con capacidades especiales"))
            {
                txtInclusion_piso01.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Piso 02
            //Para area biblioteca piso 02
            foreach (var a in AreaDAO.FiltrarPorPiso(2, "Biblioteca variada"))
            {
                txtBiblioteca_piso02.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area ludica piso 02
            foreach (var a in AreaDAO.FiltrarPorPiso(2, "Salon para menores de edad"))
            {
                txtLudico_piso02.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area proyeccion piso 02
            foreach (var a in AreaDAO.FiltrarPorPiso(2, "Salon para proyectar cortos/peliculas infantiles"))
            {
                txtProyeccion_piso02.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area computo piso 02
            foreach (var a in AreaDAO.FiltrarPorPiso(2, "Area de computo"))
            {
                txtComputo_piso02.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            
            
            //Para piso 03
            //Para area de proyeccion piso 03
            foreach (var a in AreaDAO.FiltrarPorPiso(3, "Salon para proyectar cortos/peliculas educativas"))
            {
                txtProyeccion_piso03.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area de computo piso 03
            foreach (var a in AreaDAO.FiltrarPorPiso(3, "Area de computo"))
            {
                txtComputo_piso03.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area de biblioteca piso 03
            foreach (var a in AreaDAO.FiltrarPorPiso(3, "Biblioteca variada"))
            {
                txtBiblioteca_piso03.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            
            //Para piso 04
            //Para area proyeccion piso 04
            foreach (var a in AreaDAO.FiltrarPorPiso(4, "Salon para proyectar cortos/peliculas divertidas"))
            {
                txtProyeccion04.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area computo piso 04
            foreach (var a in AreaDAO.FiltrarPorPiso(4, "Area de computo"))
            {
                txtComputo04.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area investigacion
            foreach (var a in AreaDAO.FiltrarPorPiso(4, "Area de investigacion"))
            {
                txtInvestigacion04.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            //Para area biblioteca 04
            foreach (var a in AreaDAO.FiltrarPorPiso(4, "Biblioteca variada"))
            {
                txtBiblioteca04.AppendText(a.AreaNombre + ": " + a.AreaDescripcion + "  Horarios: " + a.AreaHorario + Environment.NewLine);
            }
            
            
            
            
            /*List<Area> inclusion = funcionesUtilitarias.funcionMostrar(1, "salon para menores de edad"); //Mando 1 porque es el primer piso
            txtInclusion_piso01.AppendText(inclusion.AreaNombre + ": " + inclusion.AreaDescripcion + " - ");
            txtInclusion_piso01.AppendText(inclusion.AreaHorario + Environment.NewLine);
            //Para area computacion piso 01
            List<Area> computo = funcionesUtilitarias.funcionMostrar(1, "Area de computo"); //Mando 1 porque es el primer piso
            txtComputo_piso01.AppendText(computo.AreaNombre + ": " + computo.AreaDescripcion + " - ");
            txtComputo_piso01.AppendText(computo.AreaHorario + Environment.NewLine);
            //Para area auditorium piso 01
            List<Area> auditorio = funcionesUtilitarias.funcionMostrar(1, "Auditorium para conferencias/peliculas"); //Mando 1 porque es el primer piso
            txtAuditorio_piso01.AppendText(auditorio.AreaNombre + ": " + auditorio.AreaDescripcion + " - ");
            txtAuditorio_piso01.AppendText(auditorio.AreaHorario + Environment.NewLine);*/
        }

        private void btmBusqueda_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 3;
            
        }

        private void btmPrestamo_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 4;
            
            
        }

        private void consulta()
        {
           
            string strSentencia;
            strSentencia = "select a.id_ejemplar, a.nombre, b.nombre_editorial, c.nombre_autor " +
                           " from EJEMPLAR a, EDITORIAL b, AUTOR c " +
                           " where a.id_editorial = b.id_editorial " +
                           " and a.id_autor = c.id_autor " +
                           " and a.id_ejemplar not in (select id_ejemplar from PRESTA ) " +
                           " and a.id_ejemplar not in (select id_ejemplar from RESERVA) ";

            SqlCommand cmd = new SqlCommand(strSentencia, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPrestamo.DataSource = dt;
            cn.Close();
        }


        private void btmPlanta1_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 0;
        }

        private void btmPlanta2_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 2;
        }

        private void btmPlanta4_Click(object sender, EventArgs e)
        {
            tabControlAreasPiso.SelectedIndex = 3;
        }

        private void tabInicio_Click(object sender, EventArgs e)
        {
            
        }
        private void btmInicio_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 0;
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            string target = "https://www.google.com/maps/place/Biblioteca+Nacional+Francisco+Gavidia,+4+Calle+Ote.,+San+Salvador/@13.6969018,-89.1933095,17z/data=!3m1!4b1!4m5!3m4!1s0x8f6330e9bea6d59b:0x910e93d503e1f523!8m2!3d13.6969251!4d-89.191056";
            System.Diagnostics.Process.Start(target);
        }
        
        private void btmEvento_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 1;
        }

        private void configurarDgvBusqueda()
        {
            if (cmbBusqueda.Text == "Título")
            {
                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = EjemplarDAO.buscarTitle(txtBusqueda.Text.Trim());
            }
            else if (cmbBusqueda.Text == "Autor")
            {
                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = EjemplarDAO.buscarAutor(txtBusqueda.Text.Trim());
            }
            else if (cmbBusqueda.Text == "Palabra Clave")
            {
                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = EjemplarDAO.buscarpClave(txtBusqueda.Text.Trim());
            }
            else if (cmbBusqueda.Text == "Formato")
            {
                dgvBusqueda.DataSource = null;
                dgvBusqueda.DataSource = EjemplarDAO.buscarFormato(txtBusqueda.Text.Trim());
            }
            
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Configurar combo box
            cmbBusqueda.Text = "Título";
            
            //DGV Eventos
            gdvEventos.DataSource = null;
            gdvEventos.DataSource = EventosDAO.mostrarTodo();
            DataGridViewImageColumn columnaIma = (DataGridViewImageColumn) gdvEventos.Columns["imagen"];
            columnaIma.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gdvEventos.RowTemplate.Height = 100;
            
            //DGV Busqueda Inicial
            configurarDgvBusqueda1();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            configurarDgvBusqueda();
        }
        
        private void configurarDgvBusqueda1()
        {
            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = EjemplarDAO.obtenerTodos();
            
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta();
            
        }

        private void dgvPrestamo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strNom;
            strNom = dgvPrestamo.CurrentRow.Cells[1].Value.ToString();
            
            if(MessageBox.Show("Quiere dar a préstamo el ejemplar: " +strNom + "?","Confirme",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                insertar_prestamo(Convert.ToInt16(dgvPrestamo.CurrentRow.Cells[0].Value.ToString()));
                consulta();
            }
        }
        
        private void insertar_prestamo(int idEjemplar)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            int iRes;

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            cmd.CommandText = "insert presta (fechahora_prestamo, fechahora_devolucion, id_usuario, id_ejemplar) values (GETDATE(),GETDATE(),1, @parametro1)";
            
            cmd.Parameters.AddWithValue("@parametro1", idEjemplar);

            iRes = cmd.ExecuteNonQuery(); //devuelve 1 si todo salió bien, de lo contrario 0

            if (iRes > 0)
            {
                MessageBox.Show("Se creó corectamente el préstamo");
            }
            else
            {
                MessageBox.Show("Error en la actualización, favor verifique");
            }

            cn.Close();
        }

        private void btnEliminarPrestamos_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Realmente desea eliminar registros de préstamos","Confirme",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eliminar_prestamos();
                consulta();
            }
            
        }
        
        private void eliminar_prestamos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            int iRes;

            if (cn.State == ConnectionState.Closed) //cuando actualizamos tablas, es de verificar el estado de la conexión
            {
                cn.Open();
            }

            cmd.CommandText = "delete from presta ";
            
            iRes = cmd.ExecuteNonQuery();

            if (iRes > 0)
            {
                MessageBox.Show("Se borraron los registros");
            }
            else
            {
                MessageBox.Show("Error en la actualización, favor verifique");
            }

            cn.Close();
        }

        private void btnInsertarEjemplar_Click(object sender, EventArgs e)
        {
            using (frmCambiosEjemplar Ventana = new frmCambiosEjemplar())
            {
                DialogResult Resultado = Ventana.ShowDialog();
            }
        }
    }
}