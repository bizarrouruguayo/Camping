using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;





namespace Prueba2
{
    public partial class ParadorVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT nombre from productos ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
              
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT nombre from productos where nombre like '%'+@param+'%'", cn);
            cmd.Parameters.AddWithValue("@param", TextBox1.Text);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string asd = "";
            int id = -1;
            int precio;
            Int32.TryParse(TextBox2.Text, out precio);
            SqlParameter[] sqls = new SqlParameter[2];
            sqls[0] = new SqlParameter("totalcompra", precio);
            sqls[1] = new SqlParameter("fechacompra", DateTime.Today);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmmd = new SqlCommand("InsertarCompras", con);
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddRange(sqls);
                  
                SqlParameter retValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            retValue.Direction = ParameterDirection.ReturnValue;
            cmmd.Parameters.Add(retValue);
      
            con.Open();
            SqlDataReader dr = cmmd.ExecuteReader();
              id = Convert.ToInt32(retValue.Value);
            con.Close();


            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox ch = (CheckBox)GridView1.Rows[i].FindControl("checkBox1");
                if (ch.Checked == true)
                {
                    asd = GridView1.Rows[i].Cells[1].Text;
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                    SqlCommand cmd = new SqlCommand(" insert into detallecompra values (@pardos,@preciocompra)  ", cn);

                    cmd.Parameters.AddWithValue("@pardos", id);
                    cmd.Parameters.AddWithValue("@preciocompra", asd );
                   
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmdd = new SqlCommand("SELECT nombre from productos ", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:53275/Gestion.aspx");
        }
    }
}


















