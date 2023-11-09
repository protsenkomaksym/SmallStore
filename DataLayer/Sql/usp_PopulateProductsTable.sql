create procedure usp_PopulateProductsTable
as
begin

delete from product

create table #product
(
	name varchar(50),
	stock int not null,
	price decimal(18,2) not null
);

declare @i int = 0
declare @name varchar(50)

while @i < 15
begin

	set @name = CONCAT('Client-', FLOOR(rand()*10000))
	insert into #product select @name,  FLOOR(rand()*25), rand()*25

	set @i = @i + 1
end

insert into product
select name, stock, price from #product

select * from #product

end