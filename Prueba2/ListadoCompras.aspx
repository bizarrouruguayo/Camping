<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoCompras.aspx.cs" Inherits="Prueba2.ListadoCompras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
  
 
 
    
    

    <title>Administrador</title>
     <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="../vendor/metisMenu/metisMenu.min.css" rel="stylesheet">
    <link href="../dist/css/sb-admin-2.css" rel="stylesheet">
    <link href="../vendor/morrisjs/morris.css" rel="stylesheet">
    <link href="../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <style type="text/css">
        #form1 {
            height: 748px;
        }
    </style>
    
</head>
<body>
    <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.html">Menu Administrador</a>
            </div>



         <ul class="nav navbar-top-links navbar-right">
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-user fa-fw"></i> <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li class="divider"></li>
                        <li><a href="http://localhost:53275/default.aspx"><i class="fa fa-sign-out fa-fw"></i> Salir</a>
                        </li>
                    </ul>
                </li>
            </ul>
      </nav>
      <div class="row" class="col-lg-12">
                <div class="col-lg-12 col-md-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-line-chart fa-5x"" aria-hidden="true"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge">Listado de Alquileres</div>
                                    <div>Kiyu</div>
                                </div>
                            </div>
                        </div>
                      </div>
                </div>
          </div>
        <form id="form1" runat="server">
     
            <br />
            <br />
            <div align="center">
            <asp:Label ID="Label1" runat="server" Text="Compras "></asp:Label>
            </div>

            &nbsp;
            <br />
&nbsp;
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass= "table table-striped table-bordered table-condensed" CellPadding="6" >
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="totalcompra" HeaderText="totalcompra" SortExpression="totalcompra" />
                    <asp:BoundField DataField="fechacompra" HeaderText="fechacompra" SortExpression="fechacompra" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                </Columns>
            </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [totalcompra], [fechacompra], [id] FROM [compras]"></asp:SqlDataSource>
             <br />
            <asp:Button class="btn btn-lg btn-danger btn-block" ID="Button3" runat="server" OnClick="Button3_Click" Text="Ver Detalles" />
            <br />
             <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <asp:GridView ID="GridView2" runat="server" CssClass= "table table-striped table-bordered table-condensed" CellPadding="6">
            </asp:GridView>
            <br />
            <asp:Button class="btn btn-lg btn-info btn-block" ID="Button4" runat="server" OnClick="Button4_Click" Text="GenerarPDF" />
            <asp:Button class="btn btn-lg btn-info btn-block" ID="Button5" runat="server" OnClick="Button5_Click" target="_blank"  Text="VerPdf" />
            <asp:Button class="btn btn-lg btn-danger btn-block" ID="Button2" runat="server" Text="Atras" OnClick="Button2_Click" />
   
           
   
        </form>
        
   
           
    <script src="../vendor/jquery/jquery.min.js"></script>
    <script src="../vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="../vendor/metisMenu/metisMenu.min.js"></script>
    <script src="../vendor/raphael/raphael.min.js"></script>
    <script src="../vendor/morrisjs/morris.min.js"></script>
    <script src="../data/morris-data.js"></script>
    <script src="../dist/js/sb-admin-2.js"></script>
</body>
</html>

