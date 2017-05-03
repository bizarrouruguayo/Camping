 CREATE PROCEDURE InsertarCompras
    (
        @totalcompra int,
        @fechacompra datetime
    )

    AS
    INSERT INTO compras(totalcompra , fechacompra) VALUES (@totalcompra,@fechacompra)
    RETURN SCOPE_IDENTITY()
	
	create table compras(
	id int identity(0,1),
	totalcompra int, 
	fechacompra datetime

	)

	create table detallecompra(
	id int , 
	producto varchar(50) 

	)

	