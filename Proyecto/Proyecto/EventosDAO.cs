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
                        Eve.asistentes = Convert.ToInt32(reader["asistentes_esperado"].ToString());
                        Eve.imagen = new Bitmap(Resources.mapa);
                        lista.Add(Eve);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
    }
}