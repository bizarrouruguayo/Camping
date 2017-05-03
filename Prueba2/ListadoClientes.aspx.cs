using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;

namespace Prueba2
{
    public partial class Informes : System.Web.UI.Page
    {
        string total = "";
        string total2 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT sum(preciofinal) from clientes where tipo='camping' ", cn);
            SqlCommand cmd1 = new SqlCommand("SELECT sum(preciofinal) from clientes where tipo='Apartamentos' ", cn);
            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
       

            if (rd.Read())
            {
                Label3.Text = "La cantidad total recaudada es de " + rd[0].ToString();
               total =  Label3.Text = "La cantidad total recaudada es de " + rd[0].ToString();
                rd.Close();
                cn.Close();
            }
            cn.Open();
            SqlDataReader rd1 = cmd1.ExecuteReader();
          
         
            if (rd1.Read())
            {
                Label4.Text = "La cantidad total recaudada es de " + rd1[0].ToString();
                total2 = Label4.Text = "La cantidad total recaudada es de " + rd1[0].ToString();
                rd1.Close();
            }
            cn.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:53275/Gestion.aspx");
        }
        
        protected void Button4_Click(object sender, EventArgs e)
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Reporte.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Reporte");
            doc.AddCreator("Bruno Sosa");

            // Abrimos el archivo
            doc.Open();

            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("                                             Listado de Alquileres   Camping   "));
            doc.Add(Chunk.NEWLINE);
            
            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(5);
            tblPrueba.WidthPercentage = 100;
            PdfPTable tblPruebados = new PdfPTable(5);
            tblPruebados.WidthPercentage = 100;


            // Configuramos el título de las columnas de la tabla


            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre  ", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase(" Cantidad Dias ", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clPaiss = new PdfPCell(new Phrase("Precio Total", _standardFont));
            clPaiss.BorderWidth = 0;
            clPaiss.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("Fecha Desde ", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            PdfPCell clPaisss = new PdfPCell(new Phrase("Cedula ", _standardFont));
            clPaisss.BorderWidth = 0;
            clPaisss.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPaiss);
            tblPrueba.AddCell(clPais);
            tblPrueba.AddCell(clPaisss);

            // Configuramos el título de las columnas de la tabla


            PdfPCell clNombre2 = new PdfPCell(new Phrase("Nombre  ", _standardFont));
            clNombre2.BorderWidth = 0;
            clNombre2.BorderWidthBottom = 0.75f;

            PdfPCell clApellido2 = new PdfPCell(new Phrase(" Cantidad Dias ", _standardFont));
            clApellido2.BorderWidth = 0;
            clApellido2.BorderWidthBottom = 0.75f;

            PdfPCell clPaiss2 = new PdfPCell(new Phrase("Precio Total", _standardFont));
            clPaiss2.BorderWidth = 0;
            clPaiss2.BorderWidthBottom = 0.75f;

            PdfPCell clPais2 = new PdfPCell(new Phrase("Fecha Desde ", _standardFont));
            clPais2.BorderWidth = 0;
            clPais2.BorderWidthBottom = 0.75f;

            PdfPCell clPaisss2 = new PdfPCell(new Phrase("Cedula ", _standardFont));
            clPaisss2.BorderWidth = 0;
            clPaisss2.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPruebados.AddCell(clNombre2);
            tblPruebados.AddCell(clApellido2);
            tblPruebados.AddCell(clPaiss2);
            tblPruebados.AddCell(clPais2);
            tblPruebados.AddCell(clPaisss2);

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {

                clNombre = new PdfPCell(new Phrase(GridView1.Rows[i].Cells[0].Text, _standardFont));
                clNombre.BorderWidth = 0;

                clApellido = new PdfPCell(new Phrase(GridView1.Rows[i].Cells[1].Text, _standardFont));
                clApellido.BorderWidth = 0;

                clPaiss = new PdfPCell(new Phrase(GridView1.Rows[i].Cells[2].Text, _standardFont));
                clPaiss.BorderWidth = 0;

                clPais = new PdfPCell(new Phrase(GridView1.Rows[i].Cells[3].Text, _standardFont));
                clPais.BorderWidth = 0;

                clPaisss = new PdfPCell(new Phrase(GridView1.Rows[i].Cells[5].Text, _standardFont));
                clPaisss.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clApellido);
                tblPrueba.AddCell(clPaiss);
                tblPrueba.AddCell(clPais);
                tblPrueba.AddCell(clPaisss);

            }
          
            for (int i = 0; i < GridView2.Rows.Count; i++)
            {

                clNombre2 = new PdfPCell(new Phrase(GridView2.Rows[i].Cells[0].Text, _standardFont));
                clNombre2.BorderWidth = 0;

                clApellido2 = new PdfPCell(new Phrase(GridView2.Rows[i].Cells[1].Text, _standardFont));
                clApellido2.BorderWidth = 0;

                clPaiss2 = new PdfPCell(new Phrase(GridView2.Rows[i].Cells[2].Text, _standardFont));
                clPaiss2.BorderWidth = 0;

                clPais2 = new PdfPCell(new Phrase(GridView2.Rows[i].Cells[3].Text, _standardFont));
                clPais2.BorderWidth = 0;

                clPaisss2 = new PdfPCell(new Phrase(GridView2.Rows[i].Cells[5].Text, _standardFont));
                clPaisss2.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblPruebados.AddCell(clNombre2);
                tblPruebados.AddCell(clApellido2);
                tblPruebados.AddCell(clPaiss2);
                tblPruebados.AddCell(clPais2);
                tblPruebados.AddCell(clPaisss2);

            }
         
            

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);
            doc.Add(new Paragraph("                                               "));
            doc.Add(new Paragraph(total));
            doc.Add(new Paragraph("                                               "));
            doc.Add(new Paragraph("                                             Listado de Alquileres   Apartamentos   "));
            doc.Add(new Paragraph("                                               "));
            doc.Add(tblPruebados);
            doc.Add(new Paragraph("                                               "));
            doc.Add(new Paragraph(total2));
            doc.Close();
            writer.Close();
        }
    
          protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.WriteFile("C:/Reporte.pdf");
            Response.Flush();
            Response.Close();
        }

       
    }
}