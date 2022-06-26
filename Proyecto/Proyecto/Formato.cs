namespace Proyecto
{
    public class Formato
    {
        public int id_formato { get; set; }
        public string nombre_formato { get; set; }

        public Formato()
        {
            
        }

        public Formato(int idFormato, string nombreFormato)
        {
            id_formato = idFormato;
            nombre_formato = nombreFormato;
        }
    }
}