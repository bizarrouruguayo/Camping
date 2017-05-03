using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Prueba2
{
    public partial class AgregarArticulos : System.Web.UI.Page
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

           
            string nombre = TextBox3.Text;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO productos VALUES(@nombre ,@precio) ", cn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@precio", 0);
          
            cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label3.Text = "Agregado Sastifactoriamente";
            }
            cn.Close();


        }
    }
}

