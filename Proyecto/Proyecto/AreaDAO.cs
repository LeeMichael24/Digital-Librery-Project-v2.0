using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Proyecto.Properties;

namespace Proyecto
{
    public static class AreaDAO
    {
        public static List<Area> FiltrarPorPiso(int idPiso, string descripcionArea)
        {
            string cadena = Resources.cadena_conexion;
            List<Area> listaArea = new List<Area>();

            //Conexion a SQL
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT AREA.id_area, AREA.nombre_area, AREA.descripcion_area, AREA.horario_publico, PISO.id_piso" +
                    " FROM AREA INNER JOIN PERTENECE ON AREA.id_area = PERTENECE.id_area INNER JOIN PISO ON PISO.id_piso = " +
                    "PERTENECE.id_piso WHERE PISO.id_piso = @idPiso AND AREA.descripcion_area = @descripcionArea";
                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@idPiso", idPiso);
                command.Parameters.AddWithValue("@descripcionArea", descripcionArea);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        Area areap = new Area();
                        
                        areap.AreaID = Convert.ToInt32(reader["id_area"].ToString());
                        areap.AreaNombre = reader["nombre_area"].ToString();
                        areap.AreaDescripcion = reader["descripcion_area"].ToString();
                        areap.AreaHorario = reader["horario_publico"].ToString();
                        areap.AreaPiso = Convert.ToInt32(reader["id_piso"].ToString());
                        
                        listaArea.Add(areap);
                        
                        //area.ejemplo = new Bitmap(reader["ruta"].ToString());
                    }   
                }
                connection.Close();
            }
            return listaArea;
        }
    }
}