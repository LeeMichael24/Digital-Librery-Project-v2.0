using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Proyecto.Properties;

namespace Proyecto
{
    public static class EjemplarDAO
    {
        public static List<Ejemplar> obtenerTodos(){
            string cadena = Resources.cadena_conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT EJEMPLAR.id_ejemplar, EJEMPLAR.nombre, COLECCION.nombre_coleccion, AUTOR.nombre_autor " +
                "FROM EJEMPLAR, COLECCION, AUTOR WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion AND EJEMPLAR.id_autor = AUTOR.id_autor";
                
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Ejemplar Eje = new Ejemplar();
                        Eje.id = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        Eje.nombre = reader["nombre"].ToString();
                        Eje.coleccion = reader["nombre_coleccion"].ToString();
                        Eje.autor = reader["nombre_autor"].ToString();
                        lista.Add(Eje);
                    }   
                }
                connection.Close();
            }
            return lista;
        }

        public static List<Ejemplar> buscarTitle(string unTitulo)
        {
            string cadena = Resources.cadena_conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJEMPLAR.id_ejemplar, EJEMPLAR.nombre, COLECCION.nombre_coleccion, AUTOR.nombre_autor " +
                    "FROM EJEMPLAR, COLECCION, AUTOR WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion AND " +
                    "EJEMPLAR.id_autor = AUTOR.id_autor  AND EJEMPLAR.nombre = @Tbuscado";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tbuscado", unTitulo);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Ejemplar Eje = new Ejemplar();
                        Eje.id = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        Eje.nombre = reader["nombre"].ToString();
                        Eje.coleccion = reader["nombre_coleccion"].ToString();
                        Eje.autor = reader["nombre_autor"].ToString();
                        lista.Add(Eje);
                    }   
                }
                connection.Close();
            }
            return lista;
        }

        public static List<Ejemplar> buscarAutor(string Autor){
            string cadena = Resources.cadena_conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT EJEMPLAR.id_ejemplar, EJEMPLAR.nombre, COLECCION.nombre_coleccion, AUTOR.nombre_autor " +
                "FROM EJEMPLAR, COLECCION, AUTOR WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion AND EJEMPLAR.id_autor = AUTOR.id_autor "
                + "AND AUTOR.nombre_autor = @Abuscado";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Abuscado", Autor);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Ejemplar Eje = new Ejemplar();
                        Eje.id = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        Eje.nombre = reader["nombre"].ToString();
                        Eje.coleccion = reader["nombre_coleccion"].ToString();
                        Eje.autor = reader["nombre_autor"].ToString();
                        lista.Add(Eje);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        public static List<Ejemplar> buscarpClave(string unaPalabra)
        {
            string cadena = Resources.cadena_conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT EJEMPLAR.id_ejemplar, EJEMPLAR.nombre, COLECCION.nombre_coleccion, AUTOR.nombre_autor, PALABRACLAVE.palabra " +
                "FROM EJEMPLAR, COLECCION, AUTOR, PALABRACLAVE WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion AND EJEMPLAR.id_autor = AUTOR.id_autor " + 
                "AND EJEMPLAR.id_ejemplar = PALABRACLAVE.id_ejemplar AND PALABRACLAVE.palabra = @Pbuscado";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Pbuscado", unaPalabra);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Ejemplar Eje = new Ejemplar();
                        Eje.id = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        Eje.nombre = reader["nombre"].ToString();
                        Eje.coleccion = reader["nombre_coleccion"].ToString();
                        Eje.autor = reader["nombre_autor"].ToString();
                        Eje.pClave = reader["palabra"].ToString();
                        lista.Add(Eje);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        public static List<Ejemplar> buscarFormato(string unFormato)
        {
            string cadena = Resources.cadena_conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT EJEMPLAR.id_ejemplar, EJEMPLAR.nombre, COLECCION.nombre_coleccion, AUTOR.nombre_autor,  FORMATO.nombre_formato " +
                "FROM EJEMPLAR, COLECCION, AUTOR, FORMATO WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion AND EJEMPLAR.id_autor = AUTOR.id_autor " +
                "AND EJEMPLAR.id_formato = FORMATO.id_formato AND FORMATO.nombre_formato = @Fbuscado";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Fbuscado", unFormato);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Ejemplar Eje = new Ejemplar();
                        Eje.id = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        Eje.nombre = reader["nombre"].ToString();
                        Eje.coleccion = reader["nombre_coleccion"].ToString();
                        Eje.autor = reader["nombre_autor"].ToString();
                        Eje.formato = reader["nombre_formato"].ToString();
                        lista.Add(Eje);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        
        public static List<Editorial> ObtenerEditorials(){
            string cadena = Resources.cadena_conexion;
            List<Editorial> lista = new List<Editorial>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT EDITORIAL.id_editorial, EDITORIAL.nombre_editorial FROM EDITORIAL";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Editorial cat = new Editorial();
                        cat.id_editorial = Convert.ToInt32(reader["id_editorial"].ToString());
                        cat.nombre_editorial = reader["nombre_editorial"].ToString();
                        lista.Add(cat);
                    }   }
                connection.Close();
            }
            return lista;
        }

        public static List<Autor> ObtenerAutors(){
            string cadena = Resources.cadena_conexion;
            List<Autor> lista = new List<Autor>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT AUTOR.id_autor, AUTOR.nombre_autor FROM AUTOR";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Autor cat = new Autor();
                        cat.id_autor = Convert.ToInt32(reader["id_autor"].ToString());
                        cat.nombre_autor = reader["nombre_autor"].ToString();
                        lista.Add(cat);
                    }   }
                connection.Close();
            }
            return lista;
        }
        
        public static List<Formato> ObtenerFormatos(){
            string cadena = Resources.cadena_conexion;
            List<Formato> lista = new List<Formato>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT FORMATO.id_formato, FORMATO.nombre_formato FROM FORMATO";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Formato cat = new Formato();
                        cat.id_formato = Convert.ToInt32(reader["id_formato"].ToString());
                        cat.nombre_formato = reader["nombre_formato"].ToString();
                        lista.Add(cat);
                    }   }
                connection.Close();
            }
            return lista;
        }
        
        public static List<Coleccion> ObtenerColecciones(){
            string cadena = Resources.cadena_conexion;
            List<Coleccion> lista = new List<Coleccion>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT COLECCION.id_coleccion, COLECCION.nombre_coleccion FROM COLECCION";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Coleccion cat = new Coleccion();
                        cat.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                        cat.nombre_coleccion = reader["nombre_coleccion"].ToString();
                        lista.Add(cat);
                    }   }
                connection.Close();
            }
            return lista;
        }
        
        public static bool AgregarEjemplar(string nombre, string fecha, int editorial, int autor, int formato, int coleccion)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "INSERT INTO EJEMPLAR(nombre, fecha_publicacion, id_editorial, id_autor,id_formato, id_coleccion) " +
                    " VALUES (@nombre, @fecha, @editorial, 1, 1, 1)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@editorial", editorial);
                    command.Parameters.AddWithValue("@autor", autor);
                    command.Parameters.AddWithValue("@formato", formato);
                    command.Parameters.AddWithValue("@coleccion", coleccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                resultado = false;
            }
            return resultado;
        }
        
        
        
        public static bool EditarEjemplar(string nombre, int id)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "UPDATE EJEMPLAR SET EJEMPLAR.nombre = @nombre WHERE EJEMPLAR.id_ejemplar = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                resultado = false;
            }
            return resultado;
        }
        
        
        public static bool EliminarEjemplar(string nombre, int id)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM EJEMPLAR WHERE EJEMPLAR.nombre = @nombre AND EJEMPLAR.id_ejemplar = @id;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                resultado = false;
            }
            return resultado;
        }
    }
    
}