﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace Prueba2
{
    public partial class IngresoDeCamping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:53275/Gestion.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cedula = TextBox2.Text;
            int cedu;
            Int32.TryParse(cedula, out cedu);
            DateTime fechadesde;
            DateTime fechahasta;
            DateTime.TryParse(TextBox1.Text, out fechadesde);
            int precio = 50;
            string nombre = TextBox3.Text;
            string canti = TextBox4.Text;
            int cantidad;
            Int32.TryParse(canti, out cantidad);
            int preciofinal = precio * cantidad;
            fechahasta = fechadesde.AddDays(cantidad-1);
            string cadena = "camping";
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO clientes VALUES(@nombre ,@cantdias,@preciofinal,@tipo,@fechadesde,@fechahasta,@cedula) ", cn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cantdias", cantidad);
            cmd.Parameters.AddWithValue("@preciofinal", preciofinal);
            cmd.Parameters.AddWithValue("@tipo", cadena);
            cmd.Parameters.AddWithValue("@fechadesde", fechadesde);
            cmd.Parameters.AddWithValue("@fechahasta", fechahasta);
            cmd.Parameters.AddWithValue("@cedula", cedu);
            cn.Open();
                if ( cmd.ExecuteNonQuery() > 0)
                     {
                Label3.Text = "Agregado Sastifactoriamente";
                     }
            cn.Close();


        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 8)
            {
                TextBox2.ForeColor = Color.Green;
            }
          
            else
                TextBox2.ForeColor = Color.Red;
        }
    }
}