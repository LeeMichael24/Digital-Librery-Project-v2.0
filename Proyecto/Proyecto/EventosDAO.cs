using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using Proyecto.Properties;

namespace Proyecto
{
    public class EventosDAO
    {
        public static List<Eventos> mostrarTodo()
        {
            string cadena = Resources.cadena_conexion;
            List<Eventos> lista = new List<Eventos>();
            
            //Conexion SQL
            using (SqlConnection connection = new SqlConnection(cadena)){
                
                string query = "SELECT id_evento, titulo_evento, imagen, fechahora_inicio, fechahora_final, asistentes_esperado FROM EVENTO";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Eventos Eve = new Eventos();
                        Eve.id = Convert.ToInt32(reader["id_evento"].ToString());
                        Eve.nombre = reader["titulo_evento"].ToString();
                        Eve.fechaInicio = reader["fechahora_inicio"].ToString();
                        Eve.fechaFinal = reader["fechahora_final"].ToString();
                        Eve.imagen = new Bitmap(reader["imagen"].ToString());
                        Eve.asistentes = Convert.ToInt32(reader["asistentes_esperado"].ToString());
                        lista.Add(Eve);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        public static bool EditarEvento(string titulo, int id, int asistentes)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "UPDATE EVENTO SET titulo_evento = @titulo_evento, asistentes_esperado = @asistentes_esperados WHERE id_evento = @id_evento";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@titulo_evento", titulo);
                    command.Parameters.AddWithValue("@asistentes_esperados", asistentes);
                    command.Parameters.AddWithValue("@id_evento", id);
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

        public static bool borrarEvento(int id)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM OBJETIVO WHERE id_evento = @id;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();

                    string query2 = "DELETE FROM EVENTO WHERE id_evento = @id";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@id", id);
                    command2.ExecuteNonQuery();
                    
                    string query3 = "DELETE FROM EVENTO WHERE id_evento = @id";
                    SqlCommand command3 = new SqlCommand(query3, connection);
                    command3.Parameters.AddWithValue("@id", id);
                    command3.ExecuteNonQuery();
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