using System.Drawing;

namespace Proyecto
{
    public class Area
    {
        public int AreaID { get; set; }
        public string AreaNombre { get; set; }
        public string AreaDescripcion { get; set; }
        public string AreaHorario { get; set; }
        public int AreaPiso { get; set; }
        
        public Area()
        {
            this.AreaID = 0;
            this.AreaNombre = "";
            this.AreaDescripcion = "";
            this.AreaHorario = "";
        }
        public Area(int id, string nombre, string descripcion, string horario)
        {
            this.AreaID = id;
            this.AreaNombre = nombre;
            this.AreaDescripcion = descripcion;
            this.AreaHorario = horario;
        }
        //public Bitmap ejemplo { get; set; }
    }
}