using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace Prueba2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

     

        public void Button1_Click(object sender, EventArgs e)
        {
           

            string usuario = TextBox1.Text;
            string contrasenia = TextBox2.Text;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOS WHERE usuario=@usu and contrasenia =@pass",cn);
            cmd.Parameters.AddWithValue("@usu",usuario);
            cmd.Parameters.AddWithValue("@pass", contrasenia);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
           
                if (reader.Read())
                {
                 
                    Response.Redirect("Gestion.aspx");

                 }
          
            cn.Close();
   
            



        }

        
    }
}