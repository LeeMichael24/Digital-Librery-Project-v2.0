namespace Proyecto
{
    public class Autor
    {
        public int id_autor { get; set; }
        public string nombre_autor { get; set; }

        public Autor()
        {
            
        }

        public Autor(int idAutor, string nombreAutor)
        {
            id_autor = idAutor;
            nombre_autor = nombreAutor;
        }
    }
}