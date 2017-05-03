create table compras (
id int identity(0,1) primary key,
totalcompra int ,
fechacompra datetime ,
lineadetalle varchar(50)
)

create table detallecompra(
identificador int references compras(id),
producto varchar(50),


)

insert into compras values (255,'20/10/2002','chori')

create trigger altacompra
on compras
after insert
as
begin
insert into detallecompra (identificador,producto)
select id , lineadetalle
from inserted
end

