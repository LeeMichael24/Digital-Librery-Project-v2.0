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
    }
}