namespace Proyecto
{
    public class Editorial
    {
        public int id_editorial { get; set; }
        public string nombre_editorial { get; set; }

        public Editorial()
        {

        }

        public Editorial(int idEditorial, string nombreEditorial)
        {
            id_editorial = idEditorial;
            nombre_editorial = nombreEditorial;
        }
    }
}