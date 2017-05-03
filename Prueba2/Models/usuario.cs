using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Prueba2.Models
{
    public class Usuario
    {
        private string nombre;

        public string Nombre { get; set; }


        public static bool ingresarusuario(string nombre)
        {
            bool bandera = false;
            SqlConnection cn = new SqlConnection(@"server=NUC-02132\SQLEXPRESS ; database=prueba ; integrated security= true;");
            SqlCommand cmd = new SqlCommand("Insert into Clientes VALUES(@usuario)");
            try
            {
                cn.Open();
                cmd.Parameters.AddWithValue("@usuario",nombre);
                cmd.ExecuteNonQuery();
                bandera = true;

            }
            catch
            {
                cn.Close();
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return bandera;


        }
    }
}