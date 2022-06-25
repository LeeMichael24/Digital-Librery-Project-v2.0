namespace Proyecto
{
    public class Ejemplar
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string coleccion { get; set; }
        public string autor { get; set; }
        public string pClave { get; set; }
        public string formato { get; set; }

        public Ejemplar()
        {
            this.id = 0;
            this.nombre = "";
            this.coleccion = "";
        }

        public Ejemplar(int id, string nombre, string coleccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.coleccion = coleccion;
        }
    }
}