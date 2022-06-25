using System.Drawing;

namespace Proyecto
{
    public class Eventos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }
        public Bitmap imagen { get; set; }
        public int asistentes { get; set; }

        public Eventos()
        {
            this.id = 0;
            this.nombre = "";
            this.fechaInicio = "";
            this.fechaFinal = "";
            this.imagen = null;
            this.asistentes = 0;
        }

        public Eventos(int Id, string Nombre, string FechaInicio, string FechaFinal, Bitmap Imagen, int Asistentes)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.fechaInicio = FechaInicio;
            this.fechaFinal = FechaFinal;
            this.imagen = Imagen;
            this.asistentes = Asistentes;
        }
    }
}