namespace Proyecto
{
    public class Coleccion
    {
        public int id_coleccion { get; set; }
        public string nombre_coleccion { get; set; }

        public Coleccion()
        {
            
        }

        public Coleccion(int idColeccion, string nombreColeccion)
        {
            id_coleccion = idColeccion;
            nombre_coleccion = nombreColeccion;
        }
    }
}