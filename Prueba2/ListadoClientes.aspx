<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoClientes.aspx.cs" Inherits="Prueba2.Informes" %>
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
            <div align="center">
            <asp:Label ID="Label1" runat="server" Text=" Camping   "></asp:Label>
            </div>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [nombre], [cantidadDias], [preciofinal], [FechaDesde], [FechaHasta], [cedula] FROM [clientes] WHERE ([tipo] = @tipo)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="camping" Name="tipo" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
       
            &nbsp;
            <br />
&nbsp;
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CssClass= "table table-striped table-bordered table-condensed" CellPadding="6" >
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="cantidadDias" HeaderText="cantidadDias" SortExpression="cantidadDias" />
                    <asp:BoundField DataField="preciofinal" HeaderText="preciofinal" SortExpression="preciofinal" />
                    <asp:BoundField DataField="FechaDesde" HeaderText="FechaDesde" SortExpression="FechaDesde" />
                    <asp:BoundField DataField="FechaHasta" HeaderText="FechaHasta" SortExpression="FechaHasta" />
                    <asp:BoundField DataField="cedula" HeaderText="cedula" SortExpression="cedula" />
                </Columns>
            </asp:GridView>
             <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

    
            <div align="center">
                <asp:Label ID="Label2" runat="server" Text="Apartamentos  "></asp:Label>
            </div>
            <br>

            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass= "table table-striped table-bordered table-condensed" CellPadding="6" >
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="cantidadDias" HeaderText="cantidadDias" SortExpression="cantidadDias" />
                    <asp:BoundField DataField="preciofinal" HeaderText="preciofinal" SortExpression="preciofinal" />
                    <asp:BoundField DataField="FechaDesde" HeaderText="FechaDesde" SortExpression="FechaDesde" />
                    <asp:BoundField DataField="FechaHasta" HeaderText="FechaHasta" SortExpression="FechaHasta" />
                    <asp:BoundField DataField="cedula" HeaderText="cedula" SortExpression="cedula" />
                </Columns>
            </asp:GridView>
             <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br>
            <br>
            <br>
            <br>

            
   
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [nombre], [cantidadDias], [preciofinal], [FechaDesde], [FechaHasta], [cedula] FROM [clientes] WHERE ([tipo] = @tipo)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Apartamentos" Name="tipo" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:Button class="btn btn-lg btn-info btn-block" ID="Button4" runat="server" OnClick="Button4_Click" Text="GenerarPDF" />
            <asp:Button class="btn btn-lg btn-info btn-block" ID="Button5" runat="server" OnClick="Button5_Click" target="_blank"  Text="VerPdf" />
            <asp:Button class="btn btn-lg btn-danger btn-block" ID="Button1" runat="server" Text="Atras" OnClick="Button2_Click" />
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

